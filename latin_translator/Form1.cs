using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace latin_translator
{
    public partial class frmLatintranslator : Form
    {
        public frmLatintranslator()
        {
            InitializeComponent();
        }

        private void btnLatinSinister_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "Left";
            lblOutput.Left = 50;
        }

        private void btnLatinMedium_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "Center";
            lblOutput.Left = (this.ClientSize.Width - lblOutput.Width) / 2; 
        }

        private void btnLatinDexter_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "Right";
            lblOutput.Left = 200;

 

        }
    }
}
