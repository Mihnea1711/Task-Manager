using Project.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace Project.Controls
{
    public partial class AddTaskDialogControl : UserControl
    {
        #region fields
        /// <summary>
        /// list of all employees to display in the combobox when assigning the task.
        /// </summary>
        private List<Employee> _availableEmployees;

        /// <summary>
        /// current logged in employee.
        /// </summary>
        private Employee _currentEmployee;

        /// <summary>
        /// current task assigned employee.
        /// </summary>
        private string _assignedEmployeeUUID = null;

        /// <summary>
        /// current logged in employee index in the list of all employees.
        /// </summary>
        private int _currentEmployeeIndex;
        #endregion

        #region getters|setters
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
        #endregion

        /// <summary>
        /// Constructor. Initializes the fields.
        /// </summary>
        /// <param name="employees"></param>
        /// <param name="currentEmployee"></param>
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

        /// <summary>
        /// When the control loads, it prepares all the objects it contains.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Callback method for the "assign To Me" button. Sets the current logged in user index as the combo box index.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAssignToMe_Click(object sender, EventArgs e)
        {
            this.comboBoxAssign.SelectedIndex = this._currentEmployeeIndex;
        }
    }
}
