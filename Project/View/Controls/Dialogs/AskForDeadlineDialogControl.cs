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
using System.Windows.Forms;

namespace View
{
    public partial class AskForDeadlineDialogControl : UserControl
    {
        #region getters
        public DateTime Deadline
        {
            get
            {
                return this.dateTimePickerDeadline.Value;
            }
        }
        #endregion

        /// <summary>
        /// Constructor.
        /// </summary>
        public AskForDeadlineDialogControl()
        {
            InitializeComponent();
        }        
    }
}
