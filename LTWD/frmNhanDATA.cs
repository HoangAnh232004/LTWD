using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTWD
{
    public partial class frmNhanDATA : Form
    {
        public frmNhanDATA()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        public void funData(TextBox txtForm1)
        {
            label1.Text = txtForm1.Text;    
        }
    }
}
