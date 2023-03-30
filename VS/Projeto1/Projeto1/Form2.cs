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
    public partial class frmcomb : Form
    {
        public frmcomb()
        {
            InitializeComponent();
        }

        private void frmcomb_Load(object sender, EventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtcomb.Clear();
            txtlitro.Clear();
            txtpreco.Clear();

            txtcomb.Focus();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double cod, qntd, preco1;

            qntd = Convert.ToDouble(txtlitro.Text);
            cod = Convert.ToChar(txtcomb.Text);

            if (cod == 'A')
            {
                if(qntd <= 20)
                {
                    preco1 = qntd * (4.30 - (4.30 * 3 / 100));
                    txtpreco.Text = preco1.ToString();
                }
                else
                {
                    preco1 = qntd * (4.30 - (4.30 * 5 / 100));
                    txtpreco.Text = preco1.ToString();
                }
            }
            else if (cod == 'G')
            {
                if (qntd <= 20)
                {
                    preco1 = qntd * (5.50 - (5.50 * 4 / 100));
                    txtpreco.Text = preco1.ToString();
                }
                else
                {
                    preco1 = qntd * (5.50 - (5.50 * 6 / 100));
                    txtpreco.Text = preco1.ToString();
                }
            }
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
           this.Hide();
           frmmenu menu = new frmmenu();
            menu.Show();
        }
    }
}
