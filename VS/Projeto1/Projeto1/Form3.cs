using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto1
{
    public partial class frmloop : Form
    {
        public frmloop()
        {
            InitializeComponent();
        }

        private void frmloop_Load(object sender, EventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtresult.Clear();
            txtnum.Clear();
            txtresult.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }

        private void btncalc1_Click(object sender, EventArgs e)
        {
            double tab, result, i;

            tab = Convert.ToDouble(txtnum.Text);
            i = 1;
            while (i < 11 ){
                result = tab * i;
                i++;
                txtresult.Text = String.Concat(txtresult.Text, " \r\n " , result.ToString());
            }


        }

        private void btncalc2_Click(object sender, EventArgs e)
        {
            double tab, result, i;

            tab = Convert.ToDouble(txtnum.Text);

            for (i = 1; i < 11; i++)
            {
                result = tab * i;
                txtresult.Text = String.Concat(txtresult.Text, " \r\n ", result.ToString());
            }

        }

        private void btncalc3_Click(object sender, EventArgs e)
        {
            double tab, result, i;

            tab = Convert.ToDouble(txtnum.Text);
            i = 1;
            do
            {
                result = tab * i;
                txtresult.Text = String.Concat(txtresult.Text, " \r\n ", result.ToString());
                i++;
            } while (i < 11);
        }
    }
}
