using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

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
