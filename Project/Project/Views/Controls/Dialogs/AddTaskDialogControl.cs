using Project.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace Project.Controls
{
    public partial class AddTaskDialogControl : UserControl
    {
        private List<Employee> _availableEmployees;
        private Employee _currentEmployee;
        private string _assignedEmployeeUUID = null;
        private int _currentEmployeeIndex;

        public string TaskName
        {
            get
            {
                return this.textBoxTaskName.Text;
            }
            set
            {
                this.textBoxTaskName.Text = value;
            }
        }

        public string TaskDescription
        {
            get
            {
                return this.textBoxTaskDesc.Text;
            }
            set
            {
                this.textBoxTaskDesc.Text = value;
            }
        }

        public string TaskEmployeeAssigned
        {
            get
            {
                return this.comboBoxAssign.SelectedValue as string;
            }
            set
            {
                this._assignedEmployeeUUID = value;
            }
        }

        public DateTime TaskDeadline
        {
            get
            {
                return this.dateTimePickerDeadline.Value;
            }
            set
            {
                this.dateTimePickerDeadline.Value = value;
            }
        }

        public void SetLabelTitle(string title)
        {
            this.labelAddTaskHeader.Text = title;   
        }

        public void SetSubmitBtnText(string text)
        {
            this.buttonAddTask.Text = text;
        }

        public AddTaskDialogControl(List<Employee> employees, Employee currentEmployee)
        {
            InitializeComponent();
            this._availableEmployees = employees;
            this._currentEmployee = currentEmployee;

            for (int i = 0; i < this._availableEmployees.Count; i++)
            {
                if (this._availableEmployees[i].UUID == this._currentEmployee.UUID)
                {
                    this._currentEmployeeIndex = i;
                    break;
                }
            }
        }

        private void AddTaskDialogControl_Load(object sender, EventArgs e)
        {
            this.comboBoxAssign.DisplayMember = "Fullname";
            this.comboBoxAssign.ValueMember = "UUID";
            this.comboBoxAssign.DataSource = this._availableEmployees;

            for (int i = 0; i < this._availableEmployees.Count; i++)
            {
                if (this._availableEmployees[i].UUID == this._assignedEmployeeUUID)
                {
                    this.comboBoxAssign.SelectedIndex = i;
                    break;
                }
            }
        }

        private void buttonAssignToMe_Click(object sender, EventArgs e)
        {
            this.comboBoxAssign.SelectedIndex = this._currentEmployeeIndex;
        }
    }
}
