using System;
using System.Windows.Forms;

namespace Project.Controls
{
    public partial class AddSubtaskDialogControl : UserControl
    {
        public string SubtaskName
        {
            get
            {
                return this.textBoxSubtaskName.Text;
            }
        }

        public string SubtaskDescription
        {
            get
            {
                return this.textBoxSubtaskDesc.Text;
            }
        }

        public string SubtaskEmployeeAssigned
        {
            get
            {
                return this.comboBoxAssign.Text;
            }
        }

        public AddSubtaskDialogControl()
        {
            InitializeComponent();
        }

        private void buttonAddSubtask_Click(object sender, EventArgs e)
        {

        }
    }
}
