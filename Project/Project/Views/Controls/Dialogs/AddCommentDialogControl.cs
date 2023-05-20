using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Controls
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
