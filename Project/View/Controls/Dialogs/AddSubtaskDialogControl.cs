/**************************************************************************
 *                                                                        *
 *  Description: Task Management Tool                    		          *
 *  Website Mihnea: https://github.com/Mihnea1711               	      *
 *  Website Robert: https://github.com/cioocan               	          *
 *  Copyright:   (c) 2023, Mihnea Bejinaru, Robert Ciocan                 *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/

using System.Windows.Forms;

namespace View
{
    public partial class AddSubtaskDialogControl : UserControl
    {
        public string SubtaskName
        {
            get
            {
                return this.textBoxSubtaskName.Text;
            }
            set
            {
                this.textBoxSubtaskName.Text = value;
            }
        }

        public string SubtaskDescription
        {
            get
            {
                return this.textBoxSubtaskDesc.Text;
            }
            set
            {
                this.textBoxSubtaskDesc.Text = value;
            }
        }

        public void SetLabelTitle(string title)
        {
            this.labelAddSubtaskHeader.Text = title;
        }

        public void SetSubmitBtnText(string text)
        {
            this.buttonAddSubtask.Text = text;
        }

        public AddSubtaskDialogControl()
        {
            InitializeComponent();
        }
    }
}
