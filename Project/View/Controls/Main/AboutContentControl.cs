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
    public partial class AboutContentControl : UserControl
    {
        public AboutContentControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Shows Help for Project
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDocs_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("help.chm");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
