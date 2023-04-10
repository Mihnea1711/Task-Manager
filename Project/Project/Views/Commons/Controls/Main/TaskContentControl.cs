using System;
using System.Windows.Forms;

namespace Project.Controls
{
    public partial class TaskContentControl : UserControl
    {
        public TaskContentControl()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ((MainForm)this.TopLevelControl).LoadSubtaskContentPanel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form addSubtaskDialog = new Form();
            AddSubtaskDialogControl dialog = new AddSubtaskDialogControl();

            dialog.Dock = DockStyle.Fill;
            addSubtaskDialog.Height = dialog.Height + 50;
            addSubtaskDialog.Width = dialog.Width;
            addSubtaskDialog.Controls.Add(dialog);
            addSubtaskDialog.ShowDialog();

            if (addSubtaskDialog.DialogResult == DialogResult.OK)
            {
                string taskName = dialog.SubtaskName;
                string taskDescription = dialog.SubtaskDescription;
                string assignedEmployee = dialog.SubtaskEmployeeAssigned;
            }
        }
    }
}
