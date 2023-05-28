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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Persistence;

namespace View
{
    public partial class SubtaskContentControl : UserControl
    {
        private Subtask _currentSubtask;

        private Dictionary<string, int> statusDict = new Dictionary<string, int>
        {
            { "toDo", 0 },
            { "inProgress", 1 },
            { "done", 2 }
        };

        public SubtaskContentControl(Subtask subtask)
        {
            InitializeComponent();

            this.dataGridViewComments.Columns.Add("commentTitle", "Title");
            this.dataGridViewComments.Columns.Add("commentDescription", "Description");
            this.dataGridViewComments.Columns.Add("timeReported", "Time reported");

            this._currentSubtask = subtask;
        }

        private void SubtaskContentControl_Load(object sender, EventArgs e)
        {
            this.labelSubtaskName.Text = this._currentSubtask.Title;
            this.textBoxSubtaskDescription.Text = this._currentSubtask.Description;
            this.comboBoxStatus.SelectedIndex = statusDict[_currentSubtask.Status];

            if (_currentSubtask.EmployeeId != "")
            {
                (Employee assignedEmployee, Exception exc) = ((MainForm)this.TopLevelControl).Presenter.EmployeeSRV.GetEmployeeByUUID(this._currentSubtask.EmployeeId);
                if (exc != null)
                {
                    MessageBox.Show(exc.Message);
                    return;
                }

                if (assignedEmployee != null)
                {
                    this.labelAssignedTo.Text = $"Assigned To {assignedEmployee.FirstName} {assignedEmployee.LastName}";
                }
            }

            (IList<Comment> availableComments, Exception ex) = ((MainForm)this.TopLevelControl).Presenter.CommentSRV.GetCommentBySubask(_currentSubtask.Id);
            if (ex != null)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            availableComments.ToList().ForEach(comment =>
            {
                DataGridViewRow commentRow = ((MainForm)this.TopLevelControl).Presenter.makeCommentRow(comment);
                this.dataGridViewComments.Rows.Add(commentRow);
            });
        }

        private void buttonAddComment_Click(object sender, EventArgs e)
        {
            Form addCommentkDialog = new Form();
            AddCommentDialogControl dialog = new AddCommentDialogControl();

            dialog.Dock = DockStyle.Fill;
            addCommentkDialog.Height = dialog.Height + 50;
            addCommentkDialog.Width = dialog.Width;
            addCommentkDialog.Controls.Add(dialog);
            addCommentkDialog.ShowDialog();

            if (addCommentkDialog.DialogResult == DialogResult.OK)
            {
                string commentTitle = dialog.CommentTitle;
                string commentDescription = dialog.CommentDescription;
                int commentReportedTime = Convert.ToInt32(dialog.CommentReportedTime);

                ((MainForm)this.TopLevelControl).Presenter.CommentSRV.AddComment(commentTitle, commentDescription, commentReportedTime, _currentSubtask.Id);
                ((MainForm)this.TopLevelControl).LoadSubtaskContentPanel(_currentSubtask);
            }
        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedKey = null;
            foreach (var pair in statusDict)
            {
                if (pair.Value == comboBoxStatus.SelectedIndex)
                {
                    selectedKey = pair.Key;
                    break;
                }
            }
            ((MainForm)this.TopLevelControl).Presenter.SubtaskSRV.ChangeStatus(_currentSubtask.Id, selectedKey);

            (IList<Subtask> taskSubtasks, Exception ex) = ((MainForm)this.TopLevelControl).Presenter.SubtaskSRV.GetSubtasksByTask(_currentSubtask.TaskId);
            if (ex != null)
            {
                MessageBox.Show(ex.Message);
            }

            ((MainForm)this.TopLevelControl).Presenter.TaskSRV.CheckSubtasksStatus(taskSubtasks.ToList());
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Form addTaskDialog = new Form();
            AddSubtaskDialogControl dialog = new AddSubtaskDialogControl();

            dialog.SubtaskName = this._currentSubtask.Title;
            dialog.SubtaskDescription = this._currentSubtask.Description;
            dialog.SetLabelTitle("Update Subtask Details");
            dialog.SetSubmitBtnText("Save");
            dialog.Dock = DockStyle.Fill;

            addTaskDialog.Height = dialog.Height + 50;
            addTaskDialog.Width = dialog.Width;
            addTaskDialog.Controls.Add(dialog);
            addTaskDialog.ShowDialog();

            if (addTaskDialog.DialogResult == DialogResult.OK)
            {
                string subtaskName = dialog.SubtaskName;
                string subtaskDescription = dialog.SubtaskDescription;

                Exception ex = ((MainForm)this.TopLevelControl).Presenter.SubtaskSRV.UpdateSubtaskDetails(_currentSubtask.Id, subtaskName, subtaskDescription);
                if (ex != null)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                //((MainForm)this.TopLevelControl).LoadSubtaskContentPanel(_currentSubtask);
                (Task parentTask, Exception exc) = ((MainForm)this.TopLevelControl).Presenter.TaskSRV.GetTaskByID(_currentSubtask.TaskId);
                if (ex != null)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                ((MainForm)this.TopLevelControl).LoadTaskContentPanel(parentTask);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Exception ex = ((MainForm)this.TopLevelControl).Presenter.SubtaskSRV.DeleteSubtask(this._currentSubtask.Id);
            if (ex != null)
            {
                MessageBox.Show(ex.Message);
            }

            (IList<Subtask> taskSubtasks, Exception exc) = ((MainForm)this.TopLevelControl).Presenter.SubtaskSRV.GetSubtasksByTask(_currentSubtask.TaskId);
            if (ex != null)
            {
                MessageBox.Show(ex.Message);
            }
            ((MainForm)this.TopLevelControl).Presenter.TaskSRV.CheckSubtasksStatus(taskSubtasks.ToList());

            (Task task, Exception exception) = ((MainForm)this.TopLevelControl).Presenter.TaskSRV.GetTaskByID(_currentSubtask.TaskId);
            if (ex != null)
            {
                MessageBox.Show(ex.Message);
            }

            ((MainForm)this.TopLevelControl).LoadTaskPanel(task);
        }
    }
}
