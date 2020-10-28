using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Raspberry
{
    public partial class WarningForm : Form
    {
        public WarningForm()
        {
            InitializeComponent();
        }
        private void OkayButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
