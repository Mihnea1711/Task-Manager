using System.Windows.Forms;

namespace View
{
    public partial class AddCommentDialogControl : UserControl
    {
        public string CommentTitle
        {
            get
            {
                return this.textBoxCommentTitle.Text;
            }
        }
        public string CommentDescription
        {
            get
            {
                return this.textBoxCommentDesc.Text;
            }
        }
        public string CommentReportedTime
        {
            get
            {
                return this.textBoxReportedTime.Text;
            }
        }

        public AddCommentDialogControl()
        {
            InitializeComponent();
        }
    }
}
