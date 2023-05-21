using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Views.Controls.Dialogs
{
    public partial class AskForDeadlineDialogControl : UserControl
    {
        public AskForDeadlineDialogControl()
        {
            InitializeComponent();
        }

        public DateTime Deadline {
            get
            {
                return this.dateTimePickerDeadline.Value;
            }    
        }
    }
}
