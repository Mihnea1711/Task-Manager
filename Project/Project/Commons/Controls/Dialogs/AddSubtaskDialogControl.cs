using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Controls
{
    public partial class AddSubtaskDialogControl : UserControl
    {
        public string SubtaskName
        {
            get
            {
                return this.textBoxSubtaskName.Text;
            }
        }

        public string SubtaskDescription
        {
            get
            {
                return this.textBoxSubtaskDesc.Text;
            }
        }

        public string SubtaskEmployeeAssigned
        {
            get
            {
                return this.comboBoxAssign.Text;
            }
        }

        public int SubtaskDeadlineInDays
        {
            get
            {
                return (this.dateTimePickerDeadline.Value - DateTime.Now).Days;
            }
        }

        public AddSubtaskDialogControl()
        {
            InitializeComponent();
        }
    }
}
