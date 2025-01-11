using FugyunFolderCreator;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Media;
using System.Xml;
using System.Xml.Linq;

namespace FugyunMessageDisplay
{
    public partial class MainForm : Form
    {
        #region プロパティ

        /// <summary>
        /// メッセージフォーム
        /// </summary>
        MessageForm MsgForm { get; set; }

        /// <summary>
        /// メッセージリスト
        /// </summary>
        List<string> MsgList { get; set; } = new List<string>();

        /// <summary>
        /// メッセージ表示フラグ
        /// （true：表示中・false：非表示）
        /// </summary>
        bool DisplayMsgFlg { get; set; } = false;

        /// <summary>
        /// 表示間隔
        /// </summary>
        private int DisplayIntervalTime { get; set; } = 0;

        /// <summary>
        /// 表示時間
        /// </summary>
        private int DisplayTime { get; set; } = 0;

        /// <summary>
        /// 表示間隔時間カウント
        /// </summary>
        private int DisplayIntervalTimeCount { get; set; } = 0;

        /// <summary>
        /// 表示時間カウント
        /// </summary>
        private int DisplayTimeCount { get; set; } = 0;

        /// <summary>
        /// 表示位置
        /// </summary>
        private int DisplayIndex { get; set; } = 0;

        /// <summary>
        /// 繰り返し前ウィンドウ表示方法
        /// </summary>
        private FormWindowState BeforeLoopFormWindowState { get; set; }

        /// <summary>
        /// 画面幅
        /// </summary>
        private int ScreenWidth { get; set; }

        /// <summary>
        /// 画面高さ
        /// </summary>
        private int ScreenHeight { get; set; }

        /// <summary>
        /// フォントリスト
        /// </summary>
        private List<string> FontList { get; set; } = new List<string>();

        /// <summary>
        /// メディアプレイヤー
        /// </summary>
        private MediaPlayer Player { get; set; } = new MediaPlayer();

        #endregion

        #region コンストラクタ

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            // 画面サイズを保持する。
            ScreenWidth = Screen.GetBounds(this).Width;
            ScreenHeight = Screen.GetBounds(this).Height;

            // 位置ニューメリックダウンの最大値を設定する。
            TopNumericUpDown.Maximum = ScreenHeight;
            LeftNumericUpDown.Maximum = ScreenWidth;

            // ラベルを設定する。
            TopLocationLabel.Text = $"（指定可能範囲：０～{ConvertNumberWide(ScreenHeight)}）";
            LeftLocationLabel.Text = $"（指定可能範囲：０～{ConvertNumberWide(ScreenWidth)}）";

            // フォントリストに、インストールされているフォントを設定する。
            FontList = new InstalledFontCollection().Families.Select(family => family.Name).ToList();
        }

        #endregion

        #region イベント

        /// <summary>
        /// フォーム・ドラッグ開始処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            // 形式を判定する。
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                // ファイルをドロップする場合、マウスカーソルをコピーにする。
                e.Effect = DragDropEffects.Copy;
            }
        }

        /// <summary>
        /// フォーム・ドラッグドロップ処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            var filePathAr = e.Data.GetData(DataFormats.FileDrop, false) as string[];
            foreach (string filePath in filePathAr)
            {
                // 拡張子を判定する。
                if (string.Equals(".xml", Path.GetExtension(filePath).ToLower()))
                {
                    // 設定ファイル読み込み処理を呼び出す。
                    SettingRead(filePath);
                    break;
                }
            }
        }

        /// <summary>
        /// フォント設定ボタン押下処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void FontSettingButton_Click(object sender, EventArgs e)
        {
            FontDialog.Font = SampleLabel.Font;
            if (Equals(FontDialog.ShowDialog(this), DialogResult.OK))
            {
                SampleLabel.Font = FontDialog.Font;
            }
        }

        /// <summary>
        /// 文字色設定ボタン押下処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void FontColorButton_Click(object sender, EventArgs e)
        {
            using (ColorDialog dialog = new ColorDialog())
            {
                dialog.Color = SampleLabel.ForeColor;
                if (Equals(dialog.ShowDialog(this), DialogResult.OK))
                {
                    SampleLabel.ForeColor = dialog.Color;
                }
            }
        }

        /// <summary>
        /// 背景色設定ボタン押下処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void BackColorButton_Click(object sender, EventArgs e)
        {
            using (ColorDialog dialog = new ColorDialog())
            {
                dialog.Color = SampleLabel.BackColor;
                if (Equals(dialog.ShowDialog(this), DialogResult.OK))
                {
                    SampleLabel.BackColor = dialog.Color;
                }
            }
        }

        /// <summary>
        /// メッセージ透明度ニューメリックアップダウン・フォーカス喪失処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void OpacityNumericUpDown_Leave(object sender, EventArgs e)
        {
            NumericUpDown_Leave(OpacityNumericUpDown, "100");
        }

        /// <summary>
        /// 画面中央ラジオボタンチェック変更後処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void CenterRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            LocationRadioButtonCheckedChanged();
        }

        /// <summary>
        /// 任意ラジオボタンチェック変更後処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void AnyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            LocationRadioButtonCheckedChanged();
        }

        /// <summary>
        /// 上からの位置ニューメリックアップダウン・フォーカス喪失処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void TopNumericUpDown_Leave(object sender, EventArgs e)
        {
            NumericUpDown_Leave(TopNumericUpDown, "0");
        }

        /// <summary>
        /// 左からの位置ニューメリックアップダウン・フォーカス喪失処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void LeftNumericUpDown_Leave(object sender, EventArgs e)
        {
            NumericUpDown_Leave(LeftNumericUpDown, "0");
        }

        /// <summary>
        /// 無しラジオボタンチェック変更後処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void SoundNoneRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SoundRadioButtonCheckedChanged();
        }

        /// <summary>
        /// 音１ラジオボタンチェック変更後処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void Sound1RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SoundRadioButtonCheckedChanged();
        }

        /// <summary>
        /// 音２ラジオボタンチェック変更後処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void Sound2RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SoundRadioButtonCheckedChanged();
        }

        /// <summary>
        /// 任意ラジオボタンチェック変更後処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void Sound3RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SoundRadioButtonCheckedChanged();
        }

        /// <summary>
        /// ファイル選択ボタン押下処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void SoundFileSelectButton_Click(object sender, EventArgs e)
        {
            if (Equals(SoundOpenFileDialog.ShowDialog(this), DialogResult.OK))
            {
                SoundFilePathTextBox.Text = SoundOpenFileDialog.FileName;
                ActiveControl = SoundFilePathTextBox;
                SoundFilePathTextBox.SelectionStart = SoundFilePathTextBox.Text.Length;
            }
        }

        /// <summary>
        /// 確認用メッセージを表示ボタン押下処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void DisplayConfirmMessageButton_Click(object sender, EventArgs e)
        {
            // メッセージフォームのインスタンスの有無を判定する。
            if (!Equals(null, MsgForm))
            {
                // 存在する場合、メッセージフォームを閉じる。
                MsgForm.Close();
            }

            // メッセージフォーム表示処理を呼び出す。
            DisplayMessageForm(true);
        }

        /// <summary>
        /// 確認用メッセージを閉じるボタン押下処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void CloseConfirmMessageButton_Click(object sender, EventArgs e)
        {
            // メッセージフォームのインスタンスの有無を判定する。
            if (!Equals(null, MsgForm))
            {
                // 存在する場合、メッセージフォームを閉じる。
                MsgForm.Close();
            }
        }

        /// <summary>
        /// メッセージ表示間隔ニューメリックアップダウン・フォーカス喪失処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void DisplayIntervalNumericUpDown_Leave(object sender, EventArgs e)
        {
            NumericUpDown_Leave(DisplayIntervalNumericUpDown, "5");
        }

        /// <summary>
        /// メッセージ表示時間ニューメリックアップダウン・フォーカス喪失処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void DisplayNumericUpDown_Leave(object sender, EventArgs e)
        {
            NumericUpDown_Leave(DisplayNumericUpDown, "5");
        }

        /// <summary>
        /// 定期表示開始ボタン押下処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void LoopStartButton_Click(object sender, EventArgs e)
        {
            CustomMessageBox msgBox = new CustomMessageBox();

            try
            {
                // メッセージフォームのインスタンスの有無を判定する。
                if (!Equals(null, MsgForm))
                {
                    // 存在する場合、メッセージフォームを閉じる。
                    MsgForm.Close();
                }

                // 表示するメッセージ未入力チェック
                if (string.IsNullOrWhiteSpace(DisplayMessageTextBox.Text))
                {
                    msgBox.MessageBoxSetting(
                        "エラー",
                        "表示するメッセージが入力されていません。",
                        1,
                        Const.ButtonTextListOkOnly,
                        0,
                        2);
                    msgBox.ShowDialog(this);
                    return;
                }

                if (Sound3RadioButton.Checked)
                {
                    // 音楽ファイル未入力チェック
                    if (string.IsNullOrWhiteSpace(SoundFilePathTextBox.Text))
                    {
                        msgBox.MessageBoxSetting(
                            "エラー",
                            "再生する音楽ファイルが選択されていません。",
                            1,
                            Const.ButtonTextListOkOnly,
                            0,
                            2);
                        msgBox.ShowDialog(this);
                        return;
                    }

                    // 音楽ファイル存在チェック
                    if (!File.Exists(SoundFilePathTextBox.Text))
                    {
                        msgBox.MessageBoxSetting(
                            "エラー",
                            "再生する音楽ファイルが存在しません。",
                            1,
                            Const.ButtonTextListOkOnly,
                            0,
                            2);
                        msgBox.ShowDialog(this);
                        return;
                    }
                }

                // コントロール活性状態設定処理を呼び出す。
                SetControlEnabled(false);

                // テキストの内容を、メッセージリストに設定する。
                MsgList = Regex.Split(DisplayMessageTextBox.Text, string.Concat(Environment.NewLine, Environment.NewLine, Environment.NewLine)).ToList();

                // 表示間隔を設定する。
                DisplayIntervalTime = (int)DisplayIntervalNumericUpDown.Value;

                // 表示時間を設定する。
                DisplayTime = (int)DisplayNumericUpDown.Value;

                // ウィンドウ表示方法を保持する。
                BeforeLoopFormWindowState = WindowState;

                // タスクトレイ常駐チェックボックスのチェックを判定する。
                if (TaskTrayCheckBox.Checked)
                {
                    ShowInTaskbar = false;
                    MainNotifyIcon.Visible = true;
                    Visible = false;
                }
                else
                {
                    WindowState = FormWindowState.Minimized;
                }

                // 処理を開始する。
                MessageTimer.Start();
            }
            catch (Exception ex)
            {
                msgBox.MessageBoxSetting(
                    "エラー",
                    ex.Message,
                    1,
                    Const.ButtonTextListOkOnly,
                    0,
                    2);
                msgBox.ShowDialog(this);
            }
        }

        /// <summary>
        /// 定期表示停止ボタン押下処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void LoopStopButton_Click(object sender, EventArgs e)
        {
            // メッセージタイマーを停止する。
            MessageTimer.Stop();

            // 音楽を停止する。
            Player.Stop();

            // メッセージが表示されている場合、メッセージを非表示にする。
            if (!Equals(null, MsgForm))
            {
                MsgForm.Close();
            }

            // コントロール活性状態設定処理を呼び出す。
            SetControlEnabled(true);

            // ウィンドウ表示方法を戻す。
            WindowState = BeforeLoopFormWindowState;

            // タスクトレイに常駐、かつメッセージが表示されている場合、
            // メインフォームがアクティブフォームにならないので、一度トップに表示させ、プロパティを戻す。
            TopMost = true;
            TopMost = false;

            // 各カウントプロパティを初期化する。
            DisplayIntervalTimeCount = 0;
            DisplayTimeCount = 0;
            DisplayIndex = 0;
            DisplayMsgFlg = false;
        }

        /// <summary>
        /// 設定保存ボタン押下処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void SettingSaveButton_Click(object sender, EventArgs e)
        {
            CustomMessageBox msgBox = new CustomMessageBox();

            try
            {
                if (Equals(SaveSettingFileDialog.ShowDialog(this), DialogResult.OK))
                {
                    int soundValue = 0;
                    if (Sound1RadioButton.Checked)
                    {
                        soundValue = 1;
                    }
                    else if (Sound2RadioButton.Checked)
                    {
                        soundValue = 2;
                    }
                    else if (Sound3RadioButton.Checked)
                    {
                        soundValue = 3;
                    }

                    string settingXmlFormat = $@"<?xml version=""1.0"" encoding=""utf-8""?>
<Setting>
	<DisplayMessage>{DisplayMessageTextBox.Text}</DisplayMessage>
	<BackColorTransparentCheck>{(BackColorTransparentCheckBox.Checked ? 1 : 0)}</BackColorTransparentCheck>
	<Opacity>{OpacityNumericUpDown.Value}</Opacity>
	<Center>{(CenterRadioButton.Checked ? 1 : 0)}</Center>
	<Top>{TopNumericUpDown.Value}</Top>
	<Left>{LeftNumericUpDown.Value}</Left>
	<SoundValue>{soundValue}</SoundValue>
	<SoundFilePath>{SoundFilePathTextBox.Text}</SoundFilePath>
	<DisplayInterval>{DisplayIntervalNumericUpDown.Value}</DisplayInterval>
	<Display>{DisplayNumericUpDown.Value}</Display>
	<TaskTray>{(TaskTrayCheckBox.Checked ? 1 : 0)}</TaskTray>
	<Font>
		<ForeColor>{SampleLabel.ForeColor.ToArgb()}</ForeColor>
		<BackColor>{SampleLabel.BackColor.ToArgb()}</BackColor>
		<Name>{SampleLabel.Font.Name}</Name>
		<Size>{SampleLabel.Font.Size}</Size>
		<Bold>{(SampleLabel.Font.Bold ? 1 : 0)}</Bold>
		<Italic>{(SampleLabel.Font.Italic ? 1 : 0)}</Italic>
	</Font>
</Setting>";

                    File.WriteAllText(SaveSettingFileDialog.FileName, settingXmlFormat, Encoding.UTF8);

                    msgBox.MessageBoxSetting(
                        "設定ファイル保存完了",
                        "設定ファイルが保存されました。",
                        0,
                        Const.ButtonTextListOkOnly,
                        0);
                    msgBox.ShowDialog(this);
                }
            }
            catch (Exception ex)
            {
                msgBox.MessageBoxSetting(
                    "エラー",
                    ex.Message,
                    1,
                    Const.ButtonTextListOkOnly,
                    0,
                    2);
                msgBox.ShowDialog(this);
            }
        }

        /// <summary>
        /// 設定読み込みボタン押下処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void SettingReadButton_Click(object sender, EventArgs e)
        {
            if (Equals(SettingFileOpenFileDialog.ShowDialog(this), DialogResult.OK))
            {
                // 設定ファイル読み込み処理を呼び出す。
                SettingRead(SettingFileOpenFileDialog.FileName);
            }
        }

        /// <summary>
        /// 設定初期化ボタン押下処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void SettingInitButton_Click(object sender, EventArgs e)
        {
            CustomMessageBox msgBox = new CustomMessageBox();
            msgBox.MessageBoxSetting(
                "設定初期化確認",
                "設定を初期化しますか？",
                3,
                Const.ButtonTextListForQustion,
                1);
            msgBox.ShowDialog(this);

            if (Equals(CustomMessageBox.RETURN_BUTTON1, msgBox.MessageBoxResult))
            {
                DisplayMessageTextBox.Clear();
                BackColorTransparentCheckBox.IsAccessible = false;
                OpacityNumericUpDown.Value = 100;
                AnyRadioButton.Checked = true;
                TopNumericUpDown.Value = 0;
                LeftNumericUpDown.Value = 0;
                Sound1RadioButton.Checked = true;
                SoundFilePathTextBox.Clear();
                DisplayIntervalNumericUpDown.Value = 5;
                DisplayNumericUpDown.Value = 5;
                TaskTrayCheckBox.Checked = false;

                SampleLabel.ForeColor = InitSampleLabel.ForeColor;
                SampleLabel.BackColor = InitSampleLabel.BackColor;
                SampleLabel.Font = InitSampleLabel.Font;

                LocationRadioButtonCheckedChanged();
                SoundRadioButtonCheckedChanged();

                ActiveControl = DisplayMessageTextBox;
            }
        }

        /// <summary>
        /// メッセージタイマー・間隔処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">パラメータ</param>
        private void MessageTimer_Tick(object sender, EventArgs e)
        {
            // メッセージ表示フラグを判定する。
            // （カウントプロパティを使用した場合、連続して処理が行われる可能性があるため、フラグを使用する。）
            if (DisplayMsgFlg)
            {
                // 表示中の場合

                // 表示時間を判定する。
                if (Equals(DisplayTime, DisplayTimeCount))
                {
                    // 一致する場合

                    // メッセージを非表示にする。
                    MsgForm.Close();

                    // 表示時間カウントを初期化する。
                    DisplayTimeCount = 0;

                    // メッセージ表示フラグに、【非表示】を設定する。
                    DisplayMsgFlg = false;
                }
                else
                {
                    // 不一致の場合
                    DisplayTimeCount++;
                }
            }
            else
            {
                // 非表示の場合

                // 表示間隔を判定する。
                if (Equals(DisplayIntervalTime, DisplayIntervalTimeCount))
                {
                    // 一致する場合

                    // メッセージ表示フラグに、【表示中】を設定する。
                    DisplayMsgFlg = true;

                    // メッセージを表示する。
                    DisplayMessageForm(false);

                    // 表示間隔時間カウントを初期化する。
                    DisplayIntervalTimeCount = 0;

                    // 表示位置を判定する。
                    if (Equals(MsgList.Count - 1, DisplayIndex))
                    {
                        DisplayIndex = 0;
                    }
                    else
                    {
                        DisplayIndex++;
                    }
                }
                else
                {
                    // 不一致の場合
                    DisplayIntervalTimeCount++;
                }
            }
        }

        /// <summary>
        /// 繰り返し表示停止メニュー押下処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">パラメータ</param>
        private void LoopStopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainNotifyIcon.Visible = false;
            ShowInTaskbar = true;
            Visible = true;

            // 繰り返し表示停止ボタン押下処理を呼び出す。
            LoopStopButton_Click(sender, e);
        }

        /// <summary>
        /// 終了メニュー押下処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">パラメータ</param>
        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region ヘルパーメソッド

        /// <summary>
        /// 半角数値→全角数値変換処理
        /// </summary>
        /// <param name="narrowNumber">半角数値</param>
        /// <returns>変換した全角数値</returns>
        private string ConvertNumberWide(int narrowNumber)
        {
            string narrowNumberStr = narrowNumber.ToString(), convertNumber = string.Empty;
            foreach (char number in narrowNumberStr)
            {
                string value = Const.FullWidthNumberList.ElementAtOrDefault(int.Parse(number.ToString()));
                if (!string.IsNullOrEmpty(value))
                {
                    convertNumber = string.Concat(convertNumber, value);
                }
            }

            return convertNumber;
        }

        /// <summary>
        /// ニューメリックアップダウン・フォーカス喪失処理
        /// </summary>
        /// <param name="numericUpDown">ニューメリックアップダウン</param>
        /// <param name="setValue">設定値</param>
        private void NumericUpDown_Leave(
            NumericUpDown numericUpDown,
            string setValue)
        {
            TextBox numericUpDownTextBox = numericUpDown.Controls[1] as TextBox;
            if (string.IsNullOrWhiteSpace(numericUpDownTextBox.Text))
            {
                numericUpDownTextBox.Text = setValue;
                numericUpDownTextBox.SelectionStart = numericUpDownTextBox.Text.Length;
            }
        }

        /// <summary>
        /// 位置ラジオボタンチェック変更後処理
        /// </summary>
        private void LocationRadioButtonCheckedChanged()
        {
            if (CenterRadioButton.Checked)
            {
                TopNumericUpDown.Enabled = false;
                LeftNumericUpDown.Enabled = false;
            }
            else
            {
                TopNumericUpDown.Enabled = true;
                LeftNumericUpDown.Enabled = true;
            }
        }

        /// <summary>
        /// メッセージフォーム表示処理
        /// </summary>
        /// <param name="confirmFlg">確認フラグ（true：確認・false：確認以外）</param>
        private void DisplayMessageForm(bool confirmFlg)
        {
            MsgForm = new MessageForm();
            MsgForm.MessageLabel.ForeColor = SampleLabel.ForeColor;
            MsgForm.MessageLabel.BackColor = SampleLabel.BackColor;
            MsgForm.MessageLabel.Font = SampleLabel.Font;

            // 確認フラグを判定する。
            if (confirmFlg)
            {
                // 確認の場合
                MsgForm.MessageLabel.Text = SampleLabel.Text;
            }
            else
            {
                // 確認以外の場合
                MsgForm.MessageLabel.Text = MsgList[DisplayIndex];
            }

            // 背景色透明化チェックボックスのチェックを判定する。
            if (BackColorTransparentCheckBox.Checked)
            {
                // チェックが入っている場合
                MsgForm.MessageLabel.BackColor = TransparencyKey;
            }
            else
            {
                // チェックが外れている場合
                MsgForm.MessageLabel.BackColor = SampleLabel.BackColor;
            }

            // メッセージ不透明度を設定する。
            MsgForm.Opacity = (double)OpacityNumericUpDown.Value * 0.01;

            // 画面中央ラジオボタンのチェックを判定する。
            if (CenterRadioButton.Checked)
            {
                MsgForm.MessageLabel.Top = (ScreenHeight / 2) - (MsgForm.MessageLabel.Height / 2);
                MsgForm.MessageLabel.Left = (ScreenWidth / 2) - (MsgForm.MessageLabel.Width / 2);
            }
            else
            {
                MsgForm.MessageLabel.Top = (int)TopNumericUpDown.Value;
                MsgForm.MessageLabel.Left = (int)LeftNumericUpDown.Value;
            }

            // メッセージを表示する。
            MsgForm.Show(this);

            // ビープ音ラジオボタンを判定する。
            if (Sound1RadioButton.Checked)
            {
                SystemSounds.Beep.Play();
            }
            else if (Sound2RadioButton.Checked)
            {
                Console.Beep();
            }
            else if (Sound3RadioButton.Checked)
            {
                // 音楽ファイルの有無を判定する。
                if (File.Exists(SoundFilePathTextBox.Text))
                {
                    // 存在する場合、音楽ファイルを開き、再生する。
                    // （再生する度に開かないと、音楽が再生されないため、ここで音楽ファイルを開いている。）
                    Player.Open(new Uri(SoundFilePathTextBox.Text, UriKind.Absolute));
                    Player.Play();
                }
            }
        }

        /// <summary>
        /// メッセージ表示音ラジオボタンチェック変更後処理
        /// </summary>
        private void SoundRadioButtonCheckedChanged()
        {
            if (Sound3RadioButton.Checked)
            {
                SoundFilePathTextBox.Enabled = true;
                SoundFilePathTextBox.BackColor = System.Drawing.Color.Azure;
                SoundFileSelectButton.Enabled = true;
            }
            else
            {
                SoundFilePathTextBox.Enabled = false;
                SoundFilePathTextBox.BackColor = System.Drawing.Color.LightGray;
                SoundFileSelectButton.Enabled = false;
            }
        }

        /// <summary>
        /// コントロール活性状態設定処理
        /// </summary>
        /// <param name="setEnabledFlg">活性設定フラグ（true：活性・false：非活性）</param>
        public void SetControlEnabled(bool setEnabledFlg)
        {
            DisplayMessageTextBox.Enabled = setEnabledFlg;
            FontSettingButton.Enabled = setEnabledFlg;
            FontColorButton.Enabled = setEnabledFlg;
            BackColorButton.Enabled = setEnabledFlg;
            BackColorTransparentCheckBox.Enabled = setEnabledFlg;
            OpacityNumericUpDown.Enabled = setEnabledFlg;
            CenterRadioButton.Enabled = setEnabledFlg;
            AnyRadioButton.Enabled = setEnabledFlg;
            TopNumericUpDown.Enabled = setEnabledFlg;
            LeftNumericUpDown.Enabled = setEnabledFlg;
            DisplayConfirmMessageButton.Enabled = setEnabledFlg;
            CloseConfirmMessageButton.Enabled = setEnabledFlg;
            SoundNoneRadioButton.Enabled = setEnabledFlg;
            Sound1RadioButton.Enabled = setEnabledFlg;
            Sound2RadioButton.Enabled = setEnabledFlg;
            Sound3RadioButton.Enabled = setEnabledFlg;
            SoundFilePathTextBox.Enabled = setEnabledFlg;
            SoundFileSelectButton.Enabled = setEnabledFlg;
            DisplayIntervalNumericUpDown.Enabled = setEnabledFlg;
            DisplayNumericUpDown.Enabled= setEnabledFlg;
            TaskTrayCheckBox.Enabled = setEnabledFlg;
            LoopStartButton.Enabled = setEnabledFlg;
            SettingSaveButton.Enabled = setEnabledFlg;
            SettingReadButton.Enabled = setEnabledFlg;
            SettingInitButton.Enabled = setEnabledFlg;

            // 活性設定フラグを判定する。
            if (setEnabledFlg)
            {
                // 活性の場合
                DisplayMessageTextBox.BackColor = System.Drawing.Color.Azure;

                // 位置ラジオボタンチェック変更後処理を呼び出す。
                LocationRadioButtonCheckedChanged();

                // メッセージ表示音ラジオボタンチェック変更後処理を呼び出す。
                SoundRadioButtonCheckedChanged();
            }
            else
            {
                // 非活性の場合
                DisplayMessageTextBox.BackColor = System.Drawing.Color.LightGray;
                SoundFilePathTextBox.BackColor = System.Drawing.Color.LightGray;
            }
        }

        /// <summary>
        /// 設定ファイル読み込み処理
        /// </summary>
        /// <param name="settingFileFullPath">設定ファイルフルパス</param>
        private void SettingRead(string settingFileFullPath)
        {
            CustomMessageBox msgBox = new CustomMessageBox();

            try
            {
                XDocument document = XDocument.Load(settingFileFullPath, LoadOptions.PreserveWhitespace);
                if (Equals(null, document) || Equals(null, document.Root))
                {
                    msgBox.MessageBoxSetting(
                        "エラー",
                        "設定ファイルを読み込めませんでした。",
                        1,
                        Const.ButtonTextListOkOnly,
                        0,
                        2);
                    msgBox.ShowDialog(this);
                    return;
                }

                XElement targetNode;

                // 表示するメッセージ
                targetNode = document.Root.Element("DisplayMessage");
                if (!Equals(null, targetNode))
                {
                    DisplayMessageTextBox.Text = targetNode.Value.Replace("\n", Environment.NewLine);
                }
                else
                {
                    DisplayMessageTextBox.Text = string.Empty;
                }

                // 背景色透明化
                SetElementValueForCheckBox(
                    document.Root.Element("BackColorTransparentCheck"),
                    BackColorTransparentCheckBox,
                    false);

                // メッセージ不透明度
                SetElementValueForNumericUpDown(
                    document.Root.Element("Opacity"),
                    OpacityNumericUpDown,
                    100,
                    (int)OpacityNumericUpDown.Minimum,
                    (int)OpacityNumericUpDown.Maximum);

                // メッセージ表示位置
                AnyRadioButton.Checked = true;
                targetNode = document.Root.Element("Center");
                if (!Equals(null, targetNode))
                {
                    if (int.TryParse(targetNode.Value, out int value))
                    {
                        if (Equals(1, value))
                        {
                            CenterRadioButton.Checked = true;
                        }
                    }
                }

                // 位置ラジオボタンチェック変更後処理を呼び出す。
                LocationRadioButtonCheckedChanged();

                // 上からの位置
                SetElementValueForNumericUpDown(
                    document.Root.Element("Top"),
                    TopNumericUpDown,
                    0,
                    (int)TopNumericUpDown.Minimum,
                    (int)TopNumericUpDown.Maximum);

                // 左からの位置
                SetElementValueForNumericUpDown(
                    document.Root.Element("Left"),
                    LeftNumericUpDown,
                    0,
                    (int)LeftNumericUpDown.Minimum,
                    (int)LeftNumericUpDown.Maximum);

                // メッセージ表示音
                Sound1RadioButton.Checked = true;
                targetNode = document.Root.Element("SoundValue");
                if (!Equals(null, targetNode))
                {
                    if (int.TryParse(targetNode.Value, out int value))
                    {
                        if (Equals(0, value))
                        {
                            SoundNoneRadioButton.Checked = true;
                        }
                        else if (Equals(2, value))
                        {
                            Sound2RadioButton.Checked = true;
                        }
                        else if (Equals(3, value))
                        {
                            Sound3RadioButton.Checked = true;
                        }
                    }
                }

                // 再生する音楽ファイル
                targetNode = document.Root.Element("SoundFilePath");
                if (!Equals(null, targetNode))
                {
                    SoundFilePathTextBox.Text = targetNode.Value;
                }
                else
                {
                    SoundFilePathTextBox.Text = string.Empty;
                }

                // メッセージ表示間隔
                SetElementValueForNumericUpDown(
                    document.Root.Element("DisplayInterval"),
                    DisplayIntervalNumericUpDown,
                    5,
                    (int)DisplayIntervalNumericUpDown.Minimum,
                    (int)DisplayIntervalNumericUpDown.Maximum);

                // メッセージ表示時間
                SetElementValueForNumericUpDown(
                    document.Root.Element("Display"),
                    DisplayNumericUpDown,
                    5,
                    (int)DisplayNumericUpDown.Minimum,
                    (int)DisplayNumericUpDown.Maximum);

                // タスクトレイ
                SetElementValueForCheckBox(
                    document.Root.Element("TaskTray"),
                    TaskTrayCheckBox,
                    false);

                // サンプルラベル
                SetElementValueForLabel(
                    document.Root,
                    SampleLabel);

                msgBox.MessageBoxSetting(
                    "設定ファイル読み込み完了",
                    "設定ファイルを読み込みました。",
                    0,
                    Const.ButtonTextListOkOnly,
                    0);
                msgBox.ShowDialog(this);
            }
            catch (XmlException ex)
            {
                msgBox.MessageBoxSetting(
                    "エラー",
                    string.Concat("設定ファイルを読み込めませんでした。", Environment.NewLine, ex.Message),
                    1,
                    Const.ButtonTextListOkOnly,
                    0,
                    2);
                msgBox.ShowDialog(this);
            }
            catch (Exception ex)
            {
                msgBox.MessageBoxSetting(
                    "エラー",
                    ex.Message,
                    1,
                    Const.ButtonTextListOkOnly,
                    0,
                    2);
                msgBox.ShowDialog(this);
            }
        }

        /// <summary>
        /// 要素チェックボックス設定処理
        /// </summary>
        /// <param name="element">要素</param>
        /// <param name="checkBox">チェックボックス</param>
        /// <param name="defaultCheckFlg">デフォルトチェックフラグ</param>
        private void SetElementValueForCheckBox(
            XElement element,
            CheckBox checkBox,
            bool defaultCheckFlg)
        {
            checkBox.Checked = defaultCheckFlg;
            if (!Equals(null, element))
            {
                if (!string.IsNullOrWhiteSpace(element.Value))
                {
                    if (int.TryParse(element.Value, out int value))
                    {
                        if (Equals(1, value))
                        {
                            checkBox.Checked = true;
                        }
                        else
                        {
                            checkBox.Checked = false;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 要素値・ニューメリックアップダウン設定処理
        /// </summary>
        /// <param name="element">要素</param>
        /// <param name="numericUpDown">ニューメリックアップダウン</param>
        /// <param name="initValue">初期値</param>
        /// <param name="minValue">最小値</param>
        /// <param name="maxValue">最大値</param>
        private void SetElementValueForNumericUpDown(
            XElement element,
            NumericUpDown numericUpDown,
            int initValue,
            int minValue,
            int maxValue)
        {
            numericUpDown.Value = initValue;
            if (!Equals(null, element))
            {
                numericUpDown.Value = initValue;
                if (int.TryParse(element.Value, out int value))
                {
                    if (value >= minValue && value <= maxValue)
                    {
                        numericUpDown.Value = value;
                    }
                }
            }
        }

        /// <summary>
        /// 要素値・ラベル設定処理
        /// </summary>
        /// <param name="element">要素</param>
        /// <param name="label">ラベル</param>
        private void SetElementValueForLabel(
            XElement element,
            Label label)
        {
            XElement targetElement;
            int setColorValue = 0;

            // フォントを設定する。
            XElement fontElement = element.Element("Font");
            if (!Equals(null, fontElement))
            {
                // 文字色設定
                targetElement = fontElement.Element("ForeColor");
                if (!Equals(null, targetElement))
                {
                    if (CheckColorValue(targetElement.Value, true, ref setColorValue))
                    {
                        label.ForeColor = System.Drawing.Color.FromArgb(setColorValue);
                    }
                    else
                    {
                        label.ForeColor = InitSampleLabel.ForeColor;
                    }
                }
                else
                {
                    label.ForeColor = InitSampleLabel.ForeColor;
                }

                // 背景色設定
                targetElement = fontElement.Element("BackColor");
                if (!Equals(null, targetElement))
                {
                    if (CheckColorValue(targetElement.Value, false, ref setColorValue))
                    {
                        label.BackColor = System.Drawing.Color.FromArgb(setColorValue);
                    }
                    else
                    {
                        label.BackColor = InitSampleLabel.BackColor;
                    }
                }
                else
                {
                    label.BackColor = InitSampleLabel.BackColor;
                }

                // フォント名を取得・保持する。
                string fontName = InitSampleLabel.Font.Name;
                targetElement = fontElement.Element("Name");
                if (!Equals(null, targetElement))
                {
                    // フォントの有無を判定する。
                    if (FontList.Contains(targetElement.Value))
                    {
                        fontName = targetElement.Value;
                    }
                }

                // サイズを取得・保持する。
                float size = InitSampleLabel.Font.Size;
                targetElement = fontElement.Element("Size");
                if (!Equals(null, targetElement))
                {
                    if (float.TryParse(targetElement.Value, out float setSize))
                    {
                        if (setSize > 0)
                        {
                            size = setSize;
                        }
                    }
                }

                // 太字を設定する。
                bool bold = InitSampleLabel.Font.Bold;
                targetElement = fontElement.Element("Bold");
                if (!Equals(null, targetElement))
                {
                    bold = string.Equals("1", targetElement.Value);
                }

                // 斜体を設定する。
                bool italic = InitSampleLabel.Font.Italic;
                targetElement = fontElement.Element("Italic");
                if (!Equals(null, targetElement))
                {
                    italic = string.Equals("1", targetElement.Value);
                }

                // ラベルに設定する。
                if (bold && italic)
                {
                    label.Font = new Font(fontName, size, FontStyle.Bold | FontStyle.Italic);
                    SampleLabel.Font = new Font(fontName, size, FontStyle.Bold | FontStyle.Italic);
                }
                else if (bold && !italic)
                {
                    label.Font = new Font(fontName, size, FontStyle.Bold);
                    SampleLabel.Font = new Font(fontName, size, FontStyle.Bold);
                }
                else if (!bold && italic)
                {
                    label.Font = new Font(fontName, size, FontStyle.Italic);
                    SampleLabel.Font = new Font(fontName, size, FontStyle.Italic);
                }
                else
                {
                    label.Font = new Font(fontName, size);
                    SampleLabel.Font = new Font(fontName, size);
                }
            }
        }

        /// <summary>
        /// 色値チェック処理
        /// </summary>
        /// <param name="colorValue">色値</param>
        /// <param name="setColorFlg">設定色フラグ（true：文字色・false：背景色）</param>
        /// <param name="setColorValue">設定色値</param>
        /// <returns>結果（true：設定可能・false：設定不可）</returns>
        private bool CheckColorValue(
            string colorValue,
            bool setColorFlg,
            ref int setColorValue)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(colorValue) || !int.TryParse(colorValue, out int value))
                {
                    return false;
                }

                if (setColorFlg)
                {
                    CheckLabel.ForeColor = System.Drawing.Color.FromArgb(value);
                }
                else
                {
                    CheckLabel.BackColor = System.Drawing.Color.FromArgb(value);
                }

                setColorValue = value;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion
    }
}
