using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto1
{
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void programa1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmcomb frm = new frmcomb();
            frm.Show();

        }

        private void programasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loopingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmloop loop = new frmloop();
            loop.Show();
        }
    }
}
