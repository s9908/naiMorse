using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace naiMorse
{
    public partial class frmStatus : Form
    {
        public frmStatus()
        {
            InitializeComponent();
        }

        private void bZamknij_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmStatus_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true; 
        }
    }
}
