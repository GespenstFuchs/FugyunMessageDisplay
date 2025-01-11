namespace FugyunMessageDisplay
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.BackColorTransparentCheckBox = new System.Windows.Forms.CheckBox();
            this.SettingInitButton = new System.Windows.Forms.Button();
            this.SamplePanel = new System.Windows.Forms.Panel();
            this.SampleLabel = new System.Windows.Forms.Label();
            this.OpacityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.SoundFileSelectButton = new System.Windows.Forms.Button();
            this.SoundFilePathTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.InitSampleLabel = new System.Windows.Forms.Label();
            this.CheckLabel = new System.Windows.Forms.Label();
            this.SettingReadButton = new System.Windows.Forms.Button();
            this.SettingSaveButton = new System.Windows.Forms.Button();
            this.BeepSoundPanel = new System.Windows.Forms.Panel();
            this.Sound3RadioButton = new System.Windows.Forms.RadioButton();
            this.Sound2RadioButton = new System.Windows.Forms.RadioButton();
            this.Sound1RadioButton = new System.Windows.Forms.RadioButton();
            this.SoundNoneRadioButton = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.TaskTrayCheckBox = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.CloseConfirmMessageButton = new System.Windows.Forms.Button();
            this.DisplayConfirmMessageButton = new System.Windows.Forms.Button();
            this.LeftLocationLabel = new System.Windows.Forms.Label();
            this.TopLocationLabel = new System.Windows.Forms.Label();
            this.LoopStopButton = new System.Windows.Forms.Button();
            this.LoopStartButton = new System.Windows.Forms.Button();
            this.LeftNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.TopNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.CenterRadioButton = new System.Windows.Forms.RadioButton();
            this.AnyRadioButton = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DisplayNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DisplayIntervalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BackColorButton = new System.Windows.Forms.Button();
            this.FontColorButton = new System.Windows.Forms.Button();
            this.FontSettingButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DisplayMessageTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MessageTimer = new System.Windows.Forms.Timer(this.components);
            this.MainNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.NotifyIconContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.LoopStopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveSettingFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SettingFileOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.FontDialog = new System.Windows.Forms.FontDialog();
            this.SoundOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.MainPanel.SuspendLayout();
            this.SamplePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OpacityNumericUpDown)).BeginInit();
            this.BeepSoundPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeftNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayIntervalNumericUpDown)).BeginInit();
            this.NotifyIconContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.MainPanel.Controls.Add(this.label11);
            this.MainPanel.Controls.Add(this.BackColorTransparentCheckBox);
            this.MainPanel.Controls.Add(this.SettingInitButton);
            this.MainPanel.Controls.Add(this.SamplePanel);
            this.MainPanel.Controls.Add(this.OpacityNumericUpDown);
            this.MainPanel.Controls.Add(this.label15);
            this.MainPanel.Controls.Add(this.SoundFileSelectButton);
            this.MainPanel.Controls.Add(this.SoundFilePathTextBox);
            this.MainPanel.Controls.Add(this.label14);
            this.MainPanel.Controls.Add(this.InitSampleLabel);
            this.MainPanel.Controls.Add(this.CheckLabel);
            this.MainPanel.Controls.Add(this.SettingReadButton);
            this.MainPanel.Controls.Add(this.SettingSaveButton);
            this.MainPanel.Controls.Add(this.BeepSoundPanel);
            this.MainPanel.Controls.Add(this.label13);
            this.MainPanel.Controls.Add(this.TaskTrayCheckBox);
            this.MainPanel.Controls.Add(this.label12);
            this.MainPanel.Controls.Add(this.CloseConfirmMessageButton);
            this.MainPanel.Controls.Add(this.DisplayConfirmMessageButton);
            this.MainPanel.Controls.Add(this.LeftLocationLabel);
            this.MainPanel.Controls.Add(this.TopLocationLabel);
            this.MainPanel.Controls.Add(this.LoopStopButton);
            this.MainPanel.Controls.Add(this.LoopStartButton);
            this.MainPanel.Controls.Add(this.LeftNumericUpDown);
            this.MainPanel.Controls.Add(this.label10);
            this.MainPanel.Controls.Add(this.TopNumericUpDown);
            this.MainPanel.Controls.Add(this.label9);
            this.MainPanel.Controls.Add(this.CenterRadioButton);
            this.MainPanel.Controls.Add(this.AnyRadioButton);
            this.MainPanel.Controls.Add(this.label8);
            this.MainPanel.Controls.Add(this.label7);
            this.MainPanel.Controls.Add(this.DisplayNumericUpDown);
            this.MainPanel.Controls.Add(this.label6);
            this.MainPanel.Controls.Add(this.label5);
            this.MainPanel.Controls.Add(this.DisplayIntervalNumericUpDown);
            this.MainPanel.Controls.Add(this.label4);
            this.MainPanel.Controls.Add(this.label3);
            this.MainPanel.Controls.Add(this.BackColorButton);
            this.MainPanel.Controls.Add(this.FontColorButton);
            this.MainPanel.Controls.Add(this.FontSettingButton);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Controls.Add(this.DisplayMessageTextBox);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1184, 732);
            this.MainPanel.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.Location = new System.Drawing.Point(715, 210);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 21);
            this.label11.TabIndex = 8;
            this.label11.Text = "◆メッセージサンプル";
            // 
            // BackColorTransparentCheckBox
            // 
            this.BackColorTransparentCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BackColorTransparentCheckBox.AutoSize = true;
            this.BackColorTransparentCheckBox.Location = new System.Drawing.Point(575, 231);
            this.BackColorTransparentCheckBox.Name = "BackColorTransparentCheckBox";
            this.BackColorTransparentCheckBox.Size = new System.Drawing.Size(125, 25);
            this.BackColorTransparentCheckBox.TabIndex = 7;
            this.BackColorTransparentCheckBox.Text = "背景色透明化";
            this.BackColorTransparentCheckBox.UseVisualStyleBackColor = true;
            // 
            // SettingInitButton
            // 
            this.SettingInitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SettingInitButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.SettingInitButton.Location = new System.Drawing.Point(891, 662);
            this.SettingInitButton.Name = "SettingInitButton";
            this.SettingInitButton.Size = new System.Drawing.Size(150, 50);
            this.SettingInitButton.TabIndex = 42;
            this.SettingInitButton.Text = "設定初期化";
            this.SettingInitButton.UseVisualStyleBackColor = true;
            this.SettingInitButton.Click += new System.EventHandler(this.SettingInitButton_Click);
            // 
            // SamplePanel
            // 
            this.SamplePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SamplePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SamplePanel.Controls.Add(this.SampleLabel);
            this.SamplePanel.Location = new System.Drawing.Point(726, 220);
            this.SamplePanel.Name = "SamplePanel";
            this.SamplePanel.Size = new System.Drawing.Size(433, 97);
            this.SamplePanel.TabIndex = 9;
            // 
            // SampleLabel
            // 
            this.SampleLabel.AutoSize = true;
            this.SampleLabel.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SampleLabel.Location = new System.Drawing.Point(23, 32);
            this.SampleLabel.Name = "SampleLabel";
            this.SampleLabel.Size = new System.Drawing.Size(251, 37);
            this.SampleLabel.TabIndex = 0;
            this.SampleLabel.Text = "ふぎゅんメッセージ表示";
            // 
            // OpacityNumericUpDown
            // 
            this.OpacityNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OpacityNumericUpDown.BackColor = System.Drawing.Color.Azure;
            this.OpacityNumericUpDown.Location = new System.Drawing.Point(187, 296);
            this.OpacityNumericUpDown.Name = "OpacityNumericUpDown";
            this.OpacityNumericUpDown.Size = new System.Drawing.Size(80, 29);
            this.OpacityNumericUpDown.TabIndex = 11;
            this.OpacityNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.OpacityNumericUpDown.Leave += new System.EventHandler(this.OpacityNumericUpDown_Leave);
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 298);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(132, 21);
            this.label15.TabIndex = 10;
            this.label15.Text = "メッセージ不透明度";
            // 
            // SoundFileSelectButton
            // 
            this.SoundFileSelectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SoundFileSelectButton.Enabled = false;
            this.SoundFileSelectButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.SoundFileSelectButton.Location = new System.Drawing.Point(1057, 442);
            this.SoundFileSelectButton.Name = "SoundFileSelectButton";
            this.SoundFileSelectButton.Size = new System.Drawing.Size(106, 29);
            this.SoundFileSelectButton.TabIndex = 25;
            this.SoundFileSelectButton.Text = "ファイル選択";
            this.SoundFileSelectButton.UseVisualStyleBackColor = true;
            this.SoundFileSelectButton.Click += new System.EventHandler(this.SoundFileSelectButton_Click);
            // 
            // SoundFilePathTextBox
            // 
            this.SoundFilePathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SoundFilePathTextBox.BackColor = System.Drawing.Color.LightGray;
            this.SoundFilePathTextBox.Enabled = false;
            this.SoundFilePathTextBox.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.SoundFilePathTextBox.Location = new System.Drawing.Point(527, 442);
            this.SoundFilePathTextBox.MaxLength = 0;
            this.SoundFilePathTextBox.Name = "SoundFilePathTextBox";
            this.SoundFilePathTextBox.Size = new System.Drawing.Size(524, 29);
            this.SoundFilePathTextBox.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.label14.Location = new System.Drawing.Point(383, 445);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(144, 21);
            this.label14.TabIndex = 23;
            this.label14.Text = "再生する音楽ファイル";
            // 
            // InitSampleLabel
            // 
            this.InitSampleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.InitSampleLabel.AutoSize = true;
            this.InitSampleLabel.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.InitSampleLabel.Location = new System.Drawing.Point(587, 599);
            this.InitSampleLabel.Name = "InitSampleLabel";
            this.InitSampleLabel.Size = new System.Drawing.Size(251, 37);
            this.InitSampleLabel.TabIndex = 37;
            this.InitSampleLabel.Text = "ふぎゅんメッセージ表示";
            this.InitSampleLabel.Visible = false;
            // 
            // CheckLabel
            // 
            this.CheckLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CheckLabel.AutoSize = true;
            this.CheckLabel.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.CheckLabel.Location = new System.Drawing.Point(469, 612);
            this.CheckLabel.Name = "CheckLabel";
            this.CheckLabel.Size = new System.Drawing.Size(92, 21);
            this.CheckLabel.TabIndex = 36;
            this.CheckLabel.Text = "チェックラベル";
            this.CheckLabel.Visible = false;
            // 
            // SettingReadButton
            // 
            this.SettingReadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SettingReadButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.SettingReadButton.Location = new System.Drawing.Point(715, 662);
            this.SettingReadButton.Name = "SettingReadButton";
            this.SettingReadButton.Size = new System.Drawing.Size(150, 50);
            this.SettingReadButton.TabIndex = 41;
            this.SettingReadButton.Text = "設定読み込み";
            this.SettingReadButton.UseVisualStyleBackColor = true;
            this.SettingReadButton.Click += new System.EventHandler(this.SettingReadButton_Click);
            // 
            // SettingSaveButton
            // 
            this.SettingSaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SettingSaveButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.SettingSaveButton.Location = new System.Drawing.Point(539, 662);
            this.SettingSaveButton.Name = "SettingSaveButton";
            this.SettingSaveButton.Size = new System.Drawing.Size(150, 50);
            this.SettingSaveButton.TabIndex = 40;
            this.SettingSaveButton.Text = "設定保存";
            this.SettingSaveButton.UseVisualStyleBackColor = true;
            this.SettingSaveButton.Click += new System.EventHandler(this.SettingSaveButton_Click);
            // 
            // BeepSoundPanel
            // 
            this.BeepSoundPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BeepSoundPanel.Controls.Add(this.Sound3RadioButton);
            this.BeepSoundPanel.Controls.Add(this.Sound2RadioButton);
            this.BeepSoundPanel.Controls.Add(this.Sound1RadioButton);
            this.BeepSoundPanel.Controls.Add(this.SoundNoneRadioButton);
            this.BeepSoundPanel.Location = new System.Drawing.Point(187, 436);
            this.BeepSoundPanel.Margin = new System.Windows.Forms.Padding(0);
            this.BeepSoundPanel.Name = "BeepSoundPanel";
            this.BeepSoundPanel.Size = new System.Drawing.Size(193, 41);
            this.BeepSoundPanel.TabIndex = 22;
            // 
            // Sound3RadioButton
            // 
            this.Sound3RadioButton.AutoSize = true;
            this.Sound3RadioButton.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Sound3RadioButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.Sound3RadioButton.Location = new System.Drawing.Point(140, 0);
            this.Sound3RadioButton.Name = "Sound3RadioButton";
            this.Sound3RadioButton.Size = new System.Drawing.Size(46, 38);
            this.Sound3RadioButton.TabIndex = 3;
            this.Sound3RadioButton.TabStop = true;
            this.Sound3RadioButton.Text = "任意";
            this.Sound3RadioButton.UseVisualStyleBackColor = true;
            this.Sound3RadioButton.CheckedChanged += new System.EventHandler(this.Sound3RadioButton_CheckedChanged);
            // 
            // Sound2RadioButton
            // 
            this.Sound2RadioButton.AutoSize = true;
            this.Sound2RadioButton.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Sound2RadioButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.Sound2RadioButton.Location = new System.Drawing.Point(96, 0);
            this.Sound2RadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.Sound2RadioButton.Name = "Sound2RadioButton";
            this.Sound2RadioButton.Size = new System.Drawing.Size(46, 38);
            this.Sound2RadioButton.TabIndex = 2;
            this.Sound2RadioButton.Text = "音２";
            this.Sound2RadioButton.UseVisualStyleBackColor = true;
            this.Sound2RadioButton.CheckedChanged += new System.EventHandler(this.Sound2RadioButton_CheckedChanged);
            // 
            // Sound1RadioButton
            // 
            this.Sound1RadioButton.AutoSize = true;
            this.Sound1RadioButton.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Sound1RadioButton.Checked = true;
            this.Sound1RadioButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.Sound1RadioButton.Location = new System.Drawing.Point(47, 0);
            this.Sound1RadioButton.Name = "Sound1RadioButton";
            this.Sound1RadioButton.Size = new System.Drawing.Size(46, 38);
            this.Sound1RadioButton.TabIndex = 1;
            this.Sound1RadioButton.TabStop = true;
            this.Sound1RadioButton.Text = "音１";
            this.Sound1RadioButton.UseVisualStyleBackColor = true;
            this.Sound1RadioButton.CheckedChanged += new System.EventHandler(this.Sound1RadioButton_CheckedChanged);
            // 
            // SoundNoneRadioButton
            // 
            this.SoundNoneRadioButton.AutoSize = true;
            this.SoundNoneRadioButton.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SoundNoneRadioButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.SoundNoneRadioButton.Location = new System.Drawing.Point(0, 0);
            this.SoundNoneRadioButton.Name = "SoundNoneRadioButton";
            this.SoundNoneRadioButton.Size = new System.Drawing.Size(41, 38);
            this.SoundNoneRadioButton.TabIndex = 0;
            this.SoundNoneRadioButton.Text = "無し";
            this.SoundNoneRadioButton.UseVisualStyleBackColor = true;
            this.SoundNoneRadioButton.CheckedChanged += new System.EventHandler(this.SoundNoneRadioButton_CheckedChanged);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.label13.Location = new System.Drawing.Point(20, 436);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 21);
            this.label13.TabIndex = 21;
            this.label13.Text = "メッセージ表示音";
            // 
            // TaskTrayCheckBox
            // 
            this.TaskTrayCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TaskTrayCheckBox.AutoSize = true;
            this.TaskTrayCheckBox.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.TaskTrayCheckBox.Location = new System.Drawing.Point(187, 611);
            this.TaskTrayCheckBox.Name = "TaskTrayCheckBox";
            this.TaskTrayCheckBox.Size = new System.Drawing.Size(236, 25);
            this.TaskTrayCheckBox.TabIndex = 35;
            this.TaskTrayCheckBox.Text = "定期表示中、タスクトレイに常駐";
            this.TaskTrayCheckBox.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.label12.Location = new System.Drawing.Point(20, 612);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 21);
            this.label12.TabIndex = 34;
            this.label12.Text = "タスクトレイ";
            // 
            // CloseConfirmMessageButton
            // 
            this.CloseConfirmMessageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CloseConfirmMessageButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.CloseConfirmMessageButton.Location = new System.Drawing.Point(413, 480);
            this.CloseConfirmMessageButton.Name = "CloseConfirmMessageButton";
            this.CloseConfirmMessageButton.Size = new System.Drawing.Size(200, 50);
            this.CloseConfirmMessageButton.TabIndex = 27;
            this.CloseConfirmMessageButton.Text = "確認用メッセージを閉じる";
            this.CloseConfirmMessageButton.UseVisualStyleBackColor = true;
            this.CloseConfirmMessageButton.Click += new System.EventHandler(this.CloseConfirmMessageButton_Click);
            // 
            // DisplayConfirmMessageButton
            // 
            this.DisplayConfirmMessageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DisplayConfirmMessageButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.DisplayConfirmMessageButton.Location = new System.Drawing.Point(187, 480);
            this.DisplayConfirmMessageButton.Name = "DisplayConfirmMessageButton";
            this.DisplayConfirmMessageButton.Size = new System.Drawing.Size(200, 50);
            this.DisplayConfirmMessageButton.TabIndex = 26;
            this.DisplayConfirmMessageButton.Text = "確認用メッセージを表示";
            this.DisplayConfirmMessageButton.UseVisualStyleBackColor = true;
            this.DisplayConfirmMessageButton.Click += new System.EventHandler(this.DisplayConfirmMessageButton_Click);
            // 
            // LeftLocationLabel
            // 
            this.LeftLocationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LeftLocationLabel.AutoSize = true;
            this.LeftLocationLabel.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.LeftLocationLabel.Location = new System.Drawing.Point(510, 386);
            this.LeftLocationLabel.Name = "LeftLocationLabel";
            this.LeftLocationLabel.Size = new System.Drawing.Size(132, 21);
            this.LeftLocationLabel.TabIndex = 20;
            this.LeftLocationLabel.Text = "LeftLocationLabel";
            // 
            // TopLocationLabel
            // 
            this.TopLocationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TopLocationLabel.AutoSize = true;
            this.TopLocationLabel.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.TopLocationLabel.Location = new System.Drawing.Point(510, 351);
            this.TopLocationLabel.Name = "TopLocationLabel";
            this.TopLocationLabel.Size = new System.Drawing.Size(130, 21);
            this.TopLocationLabel.TabIndex = 17;
            this.TopLocationLabel.Text = "TopLocationLabel";
            // 
            // LoopStopButton
            // 
            this.LoopStopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LoopStopButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.LoopStopButton.Location = new System.Drawing.Point(363, 662);
            this.LoopStopButton.Name = "LoopStopButton";
            this.LoopStopButton.Size = new System.Drawing.Size(150, 50);
            this.LoopStopButton.TabIndex = 39;
            this.LoopStopButton.Text = "定期表示停止";
            this.LoopStopButton.UseVisualStyleBackColor = true;
            this.LoopStopButton.Click += new System.EventHandler(this.LoopStopButton_Click);
            // 
            // LoopStartButton
            // 
            this.LoopStartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LoopStartButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.LoopStartButton.Location = new System.Drawing.Point(187, 662);
            this.LoopStartButton.Name = "LoopStartButton";
            this.LoopStartButton.Size = new System.Drawing.Size(150, 50);
            this.LoopStartButton.TabIndex = 38;
            this.LoopStartButton.Text = "定期表示開始";
            this.LoopStartButton.UseVisualStyleBackColor = true;
            this.LoopStartButton.Click += new System.EventHandler(this.LoopStartButton_Click);
            // 
            // LeftNumericUpDown
            // 
            this.LeftNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LeftNumericUpDown.BackColor = System.Drawing.Color.Azure;
            this.LeftNumericUpDown.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.LeftNumericUpDown.Location = new System.Drawing.Point(424, 384);
            this.LeftNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.LeftNumericUpDown.Name = "LeftNumericUpDown";
            this.LeftNumericUpDown.Size = new System.Drawing.Size(80, 29);
            this.LeftNumericUpDown.TabIndex = 19;
            this.LeftNumericUpDown.Leave += new System.EventHandler(this.LeftNumericUpDown_Leave);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.label10.Location = new System.Drawing.Point(323, 384);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 21);
            this.label10.TabIndex = 18;
            this.label10.Text = "左からの位置";
            // 
            // TopNumericUpDown
            // 
            this.TopNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TopNumericUpDown.BackColor = System.Drawing.Color.Azure;
            this.TopNumericUpDown.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.TopNumericUpDown.Location = new System.Drawing.Point(424, 349);
            this.TopNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.TopNumericUpDown.Name = "TopNumericUpDown";
            this.TopNumericUpDown.Size = new System.Drawing.Size(80, 29);
            this.TopNumericUpDown.TabIndex = 16;
            this.TopNumericUpDown.Leave += new System.EventHandler(this.TopNumericUpDown_Leave);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.label9.Location = new System.Drawing.Point(323, 351);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 21);
            this.label9.TabIndex = 15;
            this.label9.Text = "上からの位置";
            // 
            // CenterRadioButton
            // 
            this.CenterRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CenterRadioButton.AutoSize = true;
            this.CenterRadioButton.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CenterRadioButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.CenterRadioButton.Location = new System.Drawing.Point(187, 351);
            this.CenterRadioButton.Name = "CenterRadioButton";
            this.CenterRadioButton.Size = new System.Drawing.Size(78, 38);
            this.CenterRadioButton.TabIndex = 13;
            this.CenterRadioButton.Text = "画面中央";
            this.CenterRadioButton.UseVisualStyleBackColor = true;
            this.CenterRadioButton.CheckedChanged += new System.EventHandler(this.CenterRadioButton_CheckedChanged);
            // 
            // AnyRadioButton
            // 
            this.AnyRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AnyRadioButton.AutoSize = true;
            this.AnyRadioButton.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AnyRadioButton.Checked = true;
            this.AnyRadioButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.AnyRadioButton.Location = new System.Drawing.Point(271, 351);
            this.AnyRadioButton.Name = "AnyRadioButton";
            this.AnyRadioButton.Size = new System.Drawing.Size(46, 38);
            this.AnyRadioButton.TabIndex = 14;
            this.AnyRadioButton.TabStop = true;
            this.AnyRadioButton.Text = "任意";
            this.AnyRadioButton.UseVisualStyleBackColor = true;
            this.AnyRadioButton.CheckedChanged += new System.EventHandler(this.AnyRadioButton_CheckedChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.label8.Location = new System.Drawing.Point(20, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 21);
            this.label8.TabIndex = 12;
            this.label8.Text = "メッセージ表示位置";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.label7.Location = new System.Drawing.Point(809, 558);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(250, 21);
            this.label7.TabIndex = 33;
            this.label7.Text = "秒（指定可能範囲：１～９００）";
            // 
            // DisplayNumericUpDown
            // 
            this.DisplayNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DisplayNumericUpDown.BackColor = System.Drawing.Color.Azure;
            this.DisplayNumericUpDown.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.DisplayNumericUpDown.Location = new System.Drawing.Point(723, 554);
            this.DisplayNumericUpDown.Maximum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.DisplayNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DisplayNumericUpDown.Name = "DisplayNumericUpDown";
            this.DisplayNumericUpDown.Size = new System.Drawing.Size(80, 29);
            this.DisplayNumericUpDown.TabIndex = 32;
            this.DisplayNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.DisplayNumericUpDown.Leave += new System.EventHandler(this.DisplayNumericUpDown_Leave);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.label6.Location = new System.Drawing.Point(585, 556);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 21);
            this.label6.TabIndex = 31;
            this.label6.Text = "メッセージ表示時間";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.label5.Location = new System.Drawing.Point(273, 558);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(266, 21);
            this.label5.TabIndex = 30;
            this.label5.Text = "秒（指定可能範囲：１～７２００）";
            // 
            // DisplayIntervalNumericUpDown
            // 
            this.DisplayIntervalNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DisplayIntervalNumericUpDown.BackColor = System.Drawing.Color.Azure;
            this.DisplayIntervalNumericUpDown.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.DisplayIntervalNumericUpDown.Location = new System.Drawing.Point(187, 556);
            this.DisplayIntervalNumericUpDown.Maximum = new decimal(new int[] {
            7200,
            0,
            0,
            0});
            this.DisplayIntervalNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DisplayIntervalNumericUpDown.Name = "DisplayIntervalNumericUpDown";
            this.DisplayIntervalNumericUpDown.Size = new System.Drawing.Size(80, 29);
            this.DisplayIntervalNumericUpDown.TabIndex = 29;
            this.DisplayIntervalNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.DisplayIntervalNumericUpDown.Leave += new System.EventHandler(this.DisplayIntervalNumericUpDown_Leave);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.label4.Location = new System.Drawing.Point(20, 558);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 21);
            this.label4.TabIndex = 28;
            this.label4.Text = "メッセージ表示間隔";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.label3.Location = new System.Drawing.Point(20, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "フォント設定";
            // 
            // BackColorButton
            // 
            this.BackColorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BackColorButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.BackColorButton.Location = new System.Drawing.Point(459, 220);
            this.BackColorButton.Name = "BackColorButton";
            this.BackColorButton.Size = new System.Drawing.Size(110, 50);
            this.BackColorButton.TabIndex = 6;
            this.BackColorButton.Text = "背景色設定";
            this.BackColorButton.UseVisualStyleBackColor = true;
            this.BackColorButton.Click += new System.EventHandler(this.BackColorButton_Click);
            // 
            // FontColorButton
            // 
            this.FontColorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FontColorButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.FontColorButton.Location = new System.Drawing.Point(323, 220);
            this.FontColorButton.Name = "FontColorButton";
            this.FontColorButton.Size = new System.Drawing.Size(110, 50);
            this.FontColorButton.TabIndex = 5;
            this.FontColorButton.Text = "文字色設定";
            this.FontColorButton.UseVisualStyleBackColor = true;
            this.FontColorButton.Click += new System.EventHandler(this.FontColorButton_Click);
            // 
            // FontSettingButton
            // 
            this.FontSettingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FontSettingButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.FontSettingButton.Location = new System.Drawing.Point(187, 220);
            this.FontSettingButton.Name = "FontSettingButton";
            this.FontSettingButton.Size = new System.Drawing.Size(110, 50);
            this.FontSettingButton.TabIndex = 4;
            this.FontSettingButton.Text = "フォント設定";
            this.FontSettingButton.UseVisualStyleBackColor = true;
            this.FontSettingButton.Click += new System.EventHandler(this.FontSettingButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.label2.Location = new System.Drawing.Point(183, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "（空行２行で、分割して表示します。）";
            // 
            // DisplayMessageTextBox
            // 
            this.DisplayMessageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DisplayMessageTextBox.BackColor = System.Drawing.Color.Azure;
            this.DisplayMessageTextBox.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DisplayMessageTextBox.HideSelection = false;
            this.DisplayMessageTextBox.Location = new System.Drawing.Point(187, 44);
            this.DisplayMessageTextBox.MaxLength = 0;
            this.DisplayMessageTextBox.Multiline = true;
            this.DisplayMessageTextBox.Name = "DisplayMessageTextBox";
            this.DisplayMessageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.DisplayMessageTextBox.Size = new System.Drawing.Size(976, 150);
            this.DisplayMessageTextBox.TabIndex = 2;
            this.DisplayMessageTextBox.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "表示するメッセージ";
            // 
            // MessageTimer
            // 
            this.MessageTimer.Interval = 1000;
            this.MessageTimer.Tick += new System.EventHandler(this.MessageTimer_Tick);
            // 
            // MainNotifyIcon
            // 
            this.MainNotifyIcon.ContextMenuStrip = this.NotifyIconContextMenuStrip;
            this.MainNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("MainNotifyIcon.Icon")));
            this.MainNotifyIcon.Text = "notifyIcon1";
            // 
            // NotifyIconContextMenuStrip
            // 
            this.NotifyIconContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoopStopToolStripMenuItem,
            this.CloseToolStripMenuItem});
            this.NotifyIconContextMenuStrip.Name = "NotifyIconContextMenuStrip";
            this.NotifyIconContextMenuStrip.Size = new System.Drawing.Size(147, 48);
            // 
            // LoopStopToolStripMenuItem
            // 
            this.LoopStopToolStripMenuItem.Name = "LoopStopToolStripMenuItem";
            this.LoopStopToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.LoopStopToolStripMenuItem.Text = "定期表示停止";
            this.LoopStopToolStripMenuItem.Click += new System.EventHandler(this.LoopStopToolStripMenuItem_Click);
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.CloseToolStripMenuItem.Text = "終了";
            this.CloseToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // SaveSettingFileDialog
            // 
            this.SaveSettingFileDialog.DefaultExt = "xml";
            this.SaveSettingFileDialog.FileName = "ふぎゅんメッセージ設定.xml";
            this.SaveSettingFileDialog.Filter = "ＸＭＬファイル (*.xml)|*.xml";
            this.SaveSettingFileDialog.InitialDirectory = "Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)";
            this.SaveSettingFileDialog.RestoreDirectory = true;
            this.SaveSettingFileDialog.Title = "設定ファイルを保存";
            // 
            // SettingFileOpenFileDialog
            // 
            this.SettingFileOpenFileDialog.DefaultExt = "xml";
            this.SettingFileOpenFileDialog.FileName = "ふぎゅんメッセージ設定.xml";
            this.SettingFileOpenFileDialog.Filter = "ＸＭＬファイル (*.xml)|*.xml";
            this.SettingFileOpenFileDialog.InitialDirectory = "Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)";
            this.SettingFileOpenFileDialog.RestoreDirectory = true;
            this.SettingFileOpenFileDialog.Title = "設定ファイルを開く";
            // 
            // FontDialog
            // 
            this.FontDialog.FontMustExist = true;
            this.FontDialog.ShowEffects = false;
            // 
            // SoundOpenFileDialog
            // 
            this.SoundOpenFileDialog.Filter = "音楽ファイル(*.wav;*.mp3;*.ogg)|*.wav;*.mp3;*.ogg";
            this.SoundOpenFileDialog.InitialDirectory = "Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)";
            this.SoundOpenFileDialog.RestoreDirectory = true;
            this.SoundOpenFileDialog.Title = "再生する音楽ファイルを開く";
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1184, 732);
            this.Controls.Add(this.MainPanel);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ふぎゅんメッセージ表示";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.SamplePanel.ResumeLayout(false);
            this.SamplePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OpacityNumericUpDown)).EndInit();
            this.BeepSoundPanel.ResumeLayout(false);
            this.BeepSoundPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeftNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayIntervalNumericUpDown)).EndInit();
            this.NotifyIconContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DisplayMessageTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BackColorButton;
        private System.Windows.Forms.Button FontColorButton;
        private System.Windows.Forms.Button FontSettingButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown DisplayIntervalNumericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown DisplayNumericUpDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton CenterRadioButton;
        private System.Windows.Forms.RadioButton AnyRadioButton;
        private System.Windows.Forms.NumericUpDown TopNumericUpDown;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown LeftNumericUpDown;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label SampleLabel;
        private System.Windows.Forms.Button LoopStopButton;
        private System.Windows.Forms.Button LoopStartButton;
        private System.Windows.Forms.Label LeftLocationLabel;
        private System.Windows.Forms.Label TopLocationLabel;
        private System.Windows.Forms.Button DisplayConfirmMessageButton;
        private System.Windows.Forms.Button CloseConfirmMessageButton;
        private System.Windows.Forms.Timer MessageTimer;
        private System.Windows.Forms.NotifyIcon MainNotifyIcon;
        private System.Windows.Forms.ContextMenuStrip NotifyIconContextMenuStrip;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox TaskTrayCheckBox;
        private System.Windows.Forms.ToolStripMenuItem LoopStopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseToolStripMenuItem;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel BeepSoundPanel;
        private System.Windows.Forms.RadioButton Sound2RadioButton;
        private System.Windows.Forms.RadioButton Sound1RadioButton;
        private System.Windows.Forms.RadioButton SoundNoneRadioButton;
        private System.Windows.Forms.Button SettingReadButton;
        private System.Windows.Forms.Button SettingSaveButton;
        private System.Windows.Forms.SaveFileDialog SaveSettingFileDialog;
        private System.Windows.Forms.OpenFileDialog SettingFileOpenFileDialog;
        private System.Windows.Forms.Label CheckLabel;
        private System.Windows.Forms.Label InitSampleLabel;
        private System.Windows.Forms.FontDialog FontDialog;
        private System.Windows.Forms.RadioButton Sound3RadioButton;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox SoundFilePathTextBox;
        private System.Windows.Forms.Button SoundFileSelectButton;
        private System.Windows.Forms.OpenFileDialog SoundOpenFileDialog;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown OpacityNumericUpDown;
        private System.Windows.Forms.Panel SamplePanel;
        private System.Windows.Forms.Button SettingInitButton;
        private System.Windows.Forms.CheckBox BackColorTransparentCheckBox;
    }
}

