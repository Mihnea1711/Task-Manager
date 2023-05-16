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
        private int _currentEmployeeIndex;

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
                return this.comboBoxAssign.SelectedValue as string;
            }
        }

        public DateTime TaskDeadline
        {
            get
            {
                return this.dateTimePickerDeadline.Value;
            }
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
            this.comboBoxAssign.SelectedIndex = 0;
        }

        private void buttonAssignToMe_Click(object sender, EventArgs e)
        {
            this.comboBoxAssign.SelectedIndex = this._currentEmployeeIndex;
        }
    }
}
