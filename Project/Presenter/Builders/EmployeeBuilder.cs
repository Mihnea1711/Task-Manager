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

namespace Presenters
{
    public class EmployeeBuilder : IEmployeeBuilder
    {
        /// <summary>
        /// The final "product" of the builder.
        /// </summary>
        private DataGridViewRow employeeRow;

        /// <summary>
        /// Method to retrieve the "product".
        /// </summary>
        /// <returns>Returns the actual data grid view row.</returns>
        public DataGridViewRow GetResult()
        {
            return this.employeeRow;
        }

        /// <summary>
        /// Method to reset the data grid view row and to create a new one.
        /// </summary>
        public void Reset()
        {
            this.employeeRow = new DataGridViewRow();
        }

        /// <summary>
        /// Method to set the employee username in the row.
        /// </summary>
        /// <param name="username"></param>
        public void SetUsername(string username)
        {
            DataGridViewCell usernameCell = new DataGridViewTextBoxCell();
            usernameCell.Value = username;

            //custom styling
            //..
            //

            this.employeeRow.Cells.Add(usernameCell);
        }

        /// <summary>
        /// Method to set the employee email in the row.
        /// </summary>
        /// <param name="email"></param>
        public void SetEmail(string email)
        {
            DataGridViewCell emailCell = new DataGridViewTextBoxCell();
            emailCell.Value = email;

            //custom styling
            //..
            //

            this.employeeRow.Cells.Add(emailCell);
        }

        /// <summary>
        /// Method to set the 'See more' button in the row.
        /// </summary>
        public void SetGoToButton()
        {
            DataGridViewButtonCell btnCell = new DataGridViewButtonCell();
            btnCell.Value = "See More";

            //custom styling
            //..
            //

            this.employeeRow.Cells.Add(btnCell);
        }

        /// <summary>
        /// Method to set the employee full name in the row.
        /// </summary>
        /// <param name="name"></param>
        public void SetName(string name)
        {
            DataGridViewCell nameCell = new DataGridViewTextBoxCell();
            nameCell.Value = name;

            //custom styling
            //..
            //

            this.employeeRow.Cells.Add(nameCell);
        }

        /// <summary>
        /// Method to set the employee phone number in the row.
        /// </summary>
        /// <param name="phoneNr"></param>
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
