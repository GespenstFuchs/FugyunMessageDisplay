using System.Windows.Forms;

namespace FugyunMessageDisplay
{
    /// <summary>
    /// メッセージフォーム
    /// </summary>
    public partial class MessageForm : Form
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MessageForm()
        {
            InitializeComponent();
            TransparencyKey = BackColor;
        }
    }
}
