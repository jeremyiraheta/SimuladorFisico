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
    /// <summary>
    /// Formulario de inicio para seleccionar los simuladores
    /// </summary>
    public partial class MainMenu : Form
    {
        /// <summary>
        /// Crea Formulario
        /// </summary>
        public MainMenu()
        {
            InitializeComponent();
        }

        public Parabolic Parabolic
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Centrifuga Centrifuga
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Pendulo Pendulo
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public PenduloDoble PenduloDoble
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Coloumb Coloumb
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        /// <summary>
        /// Muestra formulario Parabolic
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void c_BTParab_Click(object sender, EventArgs e)
        {
            Parabolic p = new Parabolic();
            p.Show(this);
            this.Hide();
        }
        /// <summary>
        /// Muestra formulario Centrifuga
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void c_BTCentrif_Click(object sender, EventArgs e)
        {
            Centrifuga p = new Centrifuga();
            p.Show(this);
            this.Hide();
        }
        /// <summary>
        /// Muestra formulario Pendulo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Pendulo p = new Pendulo();
            p.Show(this);
            this.Hide();
        }
        /// <summary>
        /// Muestra formulario PeduloDoble
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            PenduloDoble p = new PenduloDoble();
            p.Show(this);
            this.Hide();
        }
        /// <summary>
        /// Cierra Aplicacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Muestra formulario Coloumb
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            Coloumb p = new Coloumb();
            p.Show(this);
            this.Hide();
        }
    }
}
