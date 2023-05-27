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
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Net.Mail;
using Persistence;

namespace View
{
    public partial class SignUpControl : UserControl
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public SignUpControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Callback for the click event on the "SignUp" button. Gets the input from the textboxes and runs a series of tests before storing the employee in the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text.Trim();
            string password = textBoxPassword.Text.Trim();
            string rePassword = textBoxRePassword.Text.Trim();
            string firstName = textBoxFirstName.Text.Trim();
            string lastName = textBoxLastName.Text.Trim();     
            string email = textBoxEmail.Text.Trim();
            string phoneNr = textBoxPhoneNumber.Text.Trim();

            try
            {
                // #0 check empty fields
                if(username == "" || password == "" || rePassword == "" || firstName == "" || lastName == "" || email == "" || phoneNr == "") 
                {
                    throw new FieldsEmptyException("fields must not me empty");
                }

                // #1 check
                // check f_name, l_name, phone_nr to have correct format
                bool isFNameValid = Regex.IsMatch(firstName, @"^[a-zA-Z]+$");
                if (!isFNameValid)
                {
                    throw new FirstNameException("first name not in a valid format");
                }


                bool isLNameValid = Regex.IsMatch(lastName, @"^[a-zA-Z]+$");
                if (!isLNameValid)
                {
                    throw new LastNameException("last name not in a valid format");
                }
                

                bool isPhoneNrValid = Regex.IsMatch(phoneNr, @"^[0-9]+$");
                if (!isPhoneNrValid)
                {
                    throw new PhoneNumberException("phone number not in a valid format");
                }

                // #2 check
                // check email string with MailAddress class
                // if it does not throw an error, we're good to go
                var emailCheckAux = new MailAddress(email);

                // #3 check
                // check if password == re_password
                bool isPassValid = password == rePassword;
                if(!isPassValid)
                {
                    throw new PasswordMatchException("passwords don't match");
                }

                // #4 check
                // check if username is unique in db
                (bool isUsernameValid, Exception employeeValidEx) = ((LoginPage)this.TopLevelControl).EmployeeSRV.ValidateUsername(username);
                if (employeeValidEx != null)
                {
                    throw employeeValidEx;
                }
                if(!isUsernameValid) {
                    throw new UsernameTakenException("username already exists");
                }

                // if everything is right
                // store user in db
                // create a user model and save it to the form
                (Employee employee, Exception registerEx) = ((LoginPage)this.TopLevelControl).EmployeeSRV.RegisterUser(username, password, firstName, lastName, email, phoneNr);
                if(registerEx != null) 
                {
                    throw registerEx;
                }

                ((LoginPage)this.TopLevelControl).Hide();

                MainForm mainForm = new MainForm(employee);
                mainForm.ShowDialog();

                ((LoginPage)this.TopLevelControl).Close();
            } catch (Exception exception) when (
                                            exception is FormatException ||
                                            exception is ArgumentException ||
                                            exception is ArgumentNullException)
            {
                MessageBox.Show("email not in the right format");
            }
            
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }            
        }

        /// <summary>
        /// Callback for the click event on the "back" button. Back to login page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            ((LoginPage)this.TopLevelControl).ChangeToLogIn();
        }
    }

    class EmailNotValidException: Exception
    {
        public EmailNotValidException(string message)
            : base(message)
        {
        }
    }

    class FirstNameException : Exception
    {
        public FirstNameException(string message)
            : base(message)
        {
        }
    }

    class LastNameException : Exception
    {
        public LastNameException(string message)
            : base(message)
        {
        }
    }

    class PhoneNumberException : Exception
    {
        public PhoneNumberException(string message)
            : base(message)
        {
        }
    }

    class PasswordMatchException : Exception
    {
        public PasswordMatchException(string message)
            : base(message)
        {
        }
    }

    class UsernameTakenException : Exception
    {
        public UsernameTakenException(string message)
            : base(message)
        {
        }
    }

    class FieldsEmptyException : Exception
    {
        public FieldsEmptyException(string message)
            : base(message)
        {
        }
    }
}
