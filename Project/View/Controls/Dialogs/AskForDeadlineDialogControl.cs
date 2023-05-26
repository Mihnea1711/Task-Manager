using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
