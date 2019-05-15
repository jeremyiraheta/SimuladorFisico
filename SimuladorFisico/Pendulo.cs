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
    public partial class Pendulo : Form
    {

        private Timer draw;
        private Pen pen;
        double angulo;
        int arm_length;
        double VelocidadAngular;
        double AceleracionAngular;
        double GRAVEDAD;
        double friccion;

        public Pendulo()
        {
            InitializeComponent();
        }

        private void Pendulo_Load(object sender, EventArgs e)
        {
            blueBall.Location = new Point(ClientRectangle.Width / 2, ClientRectangle.Height / 4);
            redBall.Location = new Point((ClientRectangle.Width / 4)*3, ClientRectangle.Height / 2);
            pen = new Pen(Color.Black);
            arm_length = 200;
            AceleracionAngular = 0.0;
            VelocidadAngular = 0.0;            
            InitDraw();            
        }

        // Inicializar el timer para ejecutar codigo 60 veces por segundo
        public void InitDraw()
        {
            draw = new Timer();
            draw.Tick += new EventHandler(drawTick);
            draw.Interval = 10; // in miliseconds
            draw.Start();
        }
        // El codigo que se ejecuta varias veces
        private void drawTick(object sender, EventArgs e)
        {
            // Limpiar la pantalla
            this.Invalidate();

            int x = Convert.ToInt32(blueBall.Location.X + arm_length * Math.Sin(angulo));
            int y = Convert.ToInt32(blueBall.Location.Y + arm_length * Math.Cos(angulo));
            redBall.Location = new Point(x, y);

            AceleracionAngular = (-1 * GRAVEDAD / arm_length) * Math.Sin(angulo);
            VelocidadAngular += AceleracionAngular;
            VelocidadAngular *= friccion;
            angulo += VelocidadAngular;

            label_VelocidadAngular.Text = "Velocidad Angular = " + VelocidadAngular + "u/s";
            label_AceleracionAngular.Text = "Aceleracion Angular = " + AceleracionAngular + "u/s";
        }

        // Detiene la simulacion y llama el formulario padre
        private void Pendulo_FormClosed(object sender, FormClosedEventArgs e)
        {
            draw.Stop();
            this.Owner.Show();
        }

        private void Pendulo_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            
            // Dibujar linea entre bolas
            Point a = new Point(blueBall.Location.X + 16, blueBall.Location.Y + 16);
            Point b = new Point(redBall.Location.X + 16, redBall.Location.Y + 16);
            g.DrawLine(pen, a, b);
        }

       

        private void button_simular_Click(object sender, EventArgs e)
        {
            AceleracionAngular = 0.0;
            VelocidadAngular = 0.0;
            if (text_lenBrazo.Text != String.Empty)
            {
                arm_length = Convert.ToInt32(text_lenBrazo.Text);
            }

            if (text_angulo.Text != String.Empty)
            {
                angulo = Convert.ToInt32(text_angulo.Text);
                angulo = angulo * Math.PI / 180;
            }

            if(text_gravedad.Text != String.Empty)
            {
                GRAVEDAD = Convert.ToDouble(text_gravedad.Text);
            }

            friccion = 100 - Convert.ToInt32(numericUpDown_friccion.Value);
            friccion = friccion / 100;

            button_Pausa.Enabled = true;
            draw.Start();
            button_Pausa.Text = "Pausar";
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("<Informacion de ayuda aqui>", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_Pausa_Click(object sender, EventArgs e)
        {
            if(button_Pausa.Text == "Pausar")
            {
                draw.Stop();
                button_Pausa.Text = "Continuar";
            }
            else
            {
                draw.Start();
                button_Pausa.Text = "Pausar";
            }
            

        }
    }
}
