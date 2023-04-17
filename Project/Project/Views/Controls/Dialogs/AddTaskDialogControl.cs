using System;
using System.Windows.Forms;

namespace Project.Controls
{
    public partial class AddTaskDialogControl : UserControl
    {
        public string TaskName
        {
            get
            {
                return this.textBoxTaskName.Text;
            }
        }

        public string TaskDescription
        {
            get
            {
                return this.textBoxTaskDesc.Text;
            }
        }

        public string TaskEmployeeAssigned
        {
            get
            {
                return this.comboBoxAssign.Text;
            }
        }

        public int TaskDeadlineInDays
        {
            get
            {
                return (this.dateTimePickerDeadline.Value - DateTime.Now).Days;
            }
        }

        public AddTaskDialogControl()
        {
            InitializeComponent();
        }

        private void buttonAddTask_Click(object sender, EventArgs e)
        {

        }
    }
}
