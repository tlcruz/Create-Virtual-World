using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CreateWorld.Dialogs
{
    public partial class InsertPosition : Form
    {
        public InsertPosition()
        {
            InitializeComponent();
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
