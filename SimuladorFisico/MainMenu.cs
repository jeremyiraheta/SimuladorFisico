using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorFisico
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void c_BTParab_Click(object sender, EventArgs e)
        {
            Parabolic p = new Parabolic();
            p.Show(this);
            this.Hide();
                

        }

        private void c_BTCentrif_Click(object sender, EventArgs e)
        {
            Centrifuga p = new Centrifuga();
            p.Show(this);
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pendulo p = new Pendulo();
            p.Show(this);
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PenduloDoble p = new PenduloDoble();
            p.Show(this);
            this.Hide();
        }
    }
}
