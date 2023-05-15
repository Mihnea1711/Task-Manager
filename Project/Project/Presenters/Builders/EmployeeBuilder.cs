using Project.Presenters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Project.Presenters.Builders
{
    public class EmployeeBuilder : IEmployeeBuilder
    {
        private DataGridViewRow employeeRow;
        public DataGridViewRow GetResult()
        {
            return this.employeeRow;
        }

        public void Reset()
        {
            this.employeeRow = new DataGridViewRow();
        }

        public void SetEmail(string email)
        {
            DataGridViewCell emailCell = new DataGridViewTextBoxCell();
            emailCell.Value = email;

            //custom styling
            //..
            //

            this.employeeRow.Cells.Add(emailCell);
        }

        public void SetGoToButton()
        {
            DataGridViewButtonCell btnCell = new DataGridViewButtonCell();
            btnCell.Value = "See More";

            //custom styling
            //..
            //

            this.employeeRow.Cells.Add(btnCell);
        }

        public void SetName(string name)
        {
            DataGridViewCell nameCell = new DataGridViewTextBoxCell();
            nameCell.Value = name;

            //custom styling
            //..
            //

            this.employeeRow.Cells.Add(nameCell);
        }

        public void SetPhoneNr(string phoneNr)
        {
            DataGridViewCell phoneCell = new DataGridViewTextBoxCell();
            phoneCell.Value = phoneNr;

            //custom styling
            //..
            //

            this.employeeRow.Cells.Add(phoneCell);
        }
    }
}
