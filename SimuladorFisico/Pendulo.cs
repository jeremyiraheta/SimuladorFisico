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
        
        private Timer timer1;
        private Timer timer2;
        private Timer gravityTimer;
        private Pen pen;
        private int gravedadValue;

        public Pendulo()
        {
            InitializeComponent();
        }

        private void Pendulo_Load(object sender, EventArgs e)
        {
            pen = new Pen(Color.Black);
            InitTimer();
            InitTimer2();
            InitGravityTimer();
            gravityTimer.Start();
            gravedadValue = 1;
        }

        // Inicializar el timer para ejecutar codigo 60 veces por segundo
        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 16; // in miliseconds
            timer1.Start();
        }
        // El codigo que se ejecuta varias veces
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        public void InitTimer2()
        {
            timer2 = new Timer();
            timer2.Tick += new EventHandler(timer2_Tick);
            timer2.Interval = 16; // in miliseconds
        }
        
        private void timer2_Tick(object sender, EventArgs e)
        {
            Point mouse = PointToClient(MousePosition);
            mouse = new Point(mouse.X - 16, mouse.Y - 16);
            redBall.Location = mouse;
        }

        public void InitGravityTimer()
        {
            gravityTimer = new Timer();
            gravityTimer.Tick += new EventHandler(gravityTimer_Tick);
            gravityTimer.Interval = 16;
        }

        private void gravityTimer_Tick(object sender, EventArgs e)
        {
            // objetos afectados por la gravedad van aqui
            redBall.Location = new Point(redBall.Location.X, redBall.Location.Y + gravedadValue);
        }


        // Detiene la simulacion y llama el formulario padre
        private void Pendulo_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            gravityTimer.Stop();
            this.Owner.Show();
        }

        private void Pendulo_Paint(object sender, PaintEventArgs e)
        {
            // Draw line between balls
            Graphics g = e.Graphics;
            Point a = new Point(blueBall.Location.X + 16, blueBall.Location.Y + 16);
            Point b = new Point(redBall.Location.X + 16, redBall.Location.Y + 16);
            g.DrawLine(pen, a, b);
        }

        private void redBall_MouseDown(object sender, MouseEventArgs e)
        {
            timer2.Start();
            gravityTimer.Stop();
        }

        private void redBall_MouseUp(object sender, MouseEventArgs e)
        {
            timer2.Stop();
            gravityTimer.Start();
        }
    }
}
