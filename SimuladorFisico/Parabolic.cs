﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SimuladorFisico
{
    public partial class Parabolic : Form
    {
        const int SCALE = 10;
        MovPara cp;
        double secs;
        Timer nt;
        int escala = SCALE;
        // The original image.
        private Bitmap OriginalBitmap;

        // The rotated image.
        private Bitmap RotatedBitmap;

        // The center of the bitmap.
        private PointF ImageCenter;

        // The current angle of rotation during a drag.
        private float CurrentAngle = 0;

        // The total angle rotated so far in previous drags.
        private float TotalAngle = 0;
        public Parabolic()
        {
            InitializeComponent();
            
        }
        /// <summary>
        /// Gestiona la validacion de entradas de datos de velocidad
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void c_CBVel_TextChanged(object sender, EventArgs e)
        {
            double t=0;
            try
            {
                t = double.Parse(c_TBVel.Text);
            }
            catch
            {

                t = -1;
            }
            if(c_TBVel.Text != "")
            {
                if (t <= 0)
                {
                    c_TBVel.Text = "1";
                    c_Track.Value = 1;
                }
                else if (t > 100)
                {
                    c_TBVel.Text = "100";
                    c_Track.Value = 100;
                }
                else
                {
                    c_Track.Value = (int)t;
                }
            }
        }
        /// <summary>
        /// Inicia la animacion al presionar el label de inicio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void c_Lstart_Click(object sender, EventArgs e)
        {                        
            nt = new Timer();
            nt.Interval = 100;
            escala = SCALE;
            nt.Tick += Nt_Tick;
            if (!(c_TBAngle.Text == "" || c_TBVel.Text == ""))
            {
                cp = new MovPara(double.Parse(c_TBVel.Text), double.Parse(c_TBAngle.Text), (double)c_CBGrav.SelectedValue);
                nt.Start();
                c_LY.Text = String.Format("{0:0.00}", cp.Ymax);
                c_LX.Text = String.Format("{0:0.00}", cp.Xmax);
                c_LT.Text = String.Format("{0:0.00}", cp.Secmax);
            }
            
        }
        /// <summary>
        /// Evento que anima cada decima de segundo el movimiento del objeto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Nt_Tick(object sender, EventArgs e)
        {
            secs += 0.1;
            double x = Rescale(cp.getX(secs)), y = CCY(Rescale(cp.getY(secs)));            
            if (secs > cp.Secmax)
            {
                ((Timer)sender).Stop();
                c_LAx.Text = string.Format("{0:0.00}", cp.Xmax);
                c_LAy.Text = string.Format("{0:0.00}", 0);
            }                
            else
            {                
                c_LAx.Text = string.Format("{0:0.00}", cp.getX(secs));
                c_LAy.Text = string.Format("{0:0.00}", cp.getY(secs));
                c_PBBall.Location = new Point((int)x, (int)y-10);                                
            }
        }
        /// <summary>
        /// Escala la imagen con relacion a las dimensiones del formulario y la escala real en metros
        /// </summary>
        /// <param name="xy"></param>
        /// <returns></returns>
        private double Rescale(double xy)
        {
            if (escala <= 0)
                return xy;
            else
                return (xy*escala);
        }
        /// <summary>
        /// Modifica la escala si la animacion se sale del area visible del formulario
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        private bool fixScale(int x, int y)
        {
            int r = escala;
            if(r > -1)
            {
                if (y < 0)
                    escala--;
                if (x > Width)
                    escala--;
            }
            return (r != escala);

        }
        /// <summary>
        /// Ajusta el origen del plano cartesiano de la esquina superior izquierda a la parte inferior izquierda
        /// </summary>
        /// <param name="y"></param>
        /// <returns></returns>
        private double CCY(double y)
        {
            return this.Height-150 - y;
        }
        /// <summary>
        /// Gestiona la validacion de entradas de datos de angulo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void c_TBAngle_TextChanged(object sender, EventArgs e)
        {
            //double t = 0;
            //try
            //{
            //    t = double.Parse(c_TBAngle.Text);
            //}
            //catch
            //{

            //    t = -1;
            //}
            //if(c_TBAngle.Text != "")
            //{
            //    if (t <= 0)
            //        c_TBAngle.Text = "1";
            //    else if (t > 90)
            //        c_TBAngle.Text = "90";
            //}
        }
        /// <summary>
        /// Dibuja la trayectoria del objeto
        /// </summary>
        /// <param name="g"></param>
        private void DrawPath(Graphics g)
        {
            int n = (int)(cp.Secmax * 10);
            Point[] path = new Point[n];
            if (cp != null)
            {
                for (int i = 0; i < n; i++)
                {
                    int x = (int)Rescale(cp.getX((double)i/10)), y = (int)CCY(Rescale(cp.getY((double)i/10)));
                    while (fixScale(x, y))
                    {
                        x = (int)Rescale(cp.getX(((double)i / 10)));
                        y = (int)CCY(Rescale(cp.getY(((double)i / 10))));
                    }
                    path[i] = new Point(x, y);
                    g.FillEllipse(Brushes.Blue, x, y, 10,10);
                }
            }
            
        }
        /// <summary>
        /// Busca el X maximo segun dimensiones de formulario
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        private int getMaxX(Point[] p)
        {
            int m = 0;
            for (int i = 0; i < p.Length; i++)
            {
                if (p[i].X > m)
                    m = p[i].X;
            }
            return m;
        }
        /// <summary>
        /// Busca el Y maximo segun dimensiones de formulario
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        private int getMaxY(Point[] p)
        {
            int m = 0;
            for (int i = 0; i < p.Length; i++)
            {
                if (p[i].Y > m)
                    m = p[i].Y;
            }
            return m;
        }

        private void c_LStop_Click(object sender, EventArgs e)
        {
            secs = 0;
            escala = SCALE;
            c_PBBall.Location = new Point(0,(int)CCY(0));
            this.Invalidate();
            cp = null;
            if(nt != null)
                nt.Stop();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
            if (cp != null)
            {
                DrawPath(e.Graphics);
            }            
        }

        private void c_Track_Scroll(object sender, EventArgs e)
        {
            c_TBVel.Text = c_Track.Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Dictionary<string, double> environment = new Dictionary<string, double>();
            environment.Add("Tierra", 9.81);
            environment.Add("Luna", 1.62);
            environment.Add("Marte", 3.711);

            c_CBGrav.DataSource = new BindingSource(environment, null);
            c_CBGrav.DisplayMember = "key";
            c_CBGrav.ValueMember = "value";

            c_CBGrav.SelectedIndex = 0;

            // Start with no rotation.
            CurrentAngle = 0;
            TotalAngle = 0;

            // Load the bitmap.
            Bitmap bm = new Bitmap(c_PBArrow.Image);
            c_PBArrow.Image = OriginalBitmap;
            c_PBArrow.Visible = true;

            // See how big the rotated bitmap must be.
            int wid = (int)Math.Sqrt(bm.Width * bm.Width + bm.Height * bm.Height);

            // Make the original unrotated bitmap.
            OriginalBitmap = new Bitmap(wid, wid);

            // Save the center of the image for calculating rotation angles.
            ImageCenter = new PointF(0, wid);

            // Copy the image into the middle of the bitmap.
            using (Graphics gr = Graphics.FromImage(OriginalBitmap))
            {
                // Clear with the color in the image's upper left corner.
                gr.Clear(bm.GetPixel(0, 0));

                //// For debugging. (Easier to see the background.)
                //gr.Clear(Color.LightBlue);

                // Draw the image centered.
                gr.DrawImage(bm, (wid - bm.Width) / 2, (wid - bm.Height) / 2);
            }

            // Display the original image.
            c_PBArrow.Image = OriginalBitmap;

        }
        // Return a bitmap rotated around its center.
        private Bitmap RotateBitmap(Bitmap bm, float angle)
        {
            // Make a bitmap to hold the rotated result.
            Bitmap result = new Bitmap(bm.Width, bm.Height);

            // Create the real rotation transformation.
            Matrix rotate_at_center = new Matrix();
            rotate_at_center.RotateAt(angle,
                new PointF(bm.Width / 2f, bm.Height / 2f));

            // Draw the image onto the new bitmap rotated.
            using (Graphics gr = Graphics.FromImage(result))
            {
                // Use smooth image interpolation.
                gr.InterpolationMode = InterpolationMode.High;

                // Clear with the color in the image's upper left corner.
                gr.Clear(OriginalBitmap.GetPixel(0, 0));

                //// For debugging. (Makes it easier to see the background.)
                //gr.Clear(Color.LightBlue);

                // Set up the transformation to rotate.
                gr.Transform = rotate_at_center;

                // Draw the image centered on the bitmap.
                gr.DrawImage(bm, 0, 0);
            }

            // Return the result bitmap.
            return result;
        }
        // Let the user click and drag to rotate.
        private float StartAngle;
        private bool DragInProgress = false;
        private void c_PBArrow_MouseDown(object sender, MouseEventArgs e)
        {
            // Do nothing if there's no image loaded.
            if (OriginalBitmap == null) return;
            DragInProgress = true;

            // Get the initial angle from horizontal to the
            // vector between the center and the drag start point.
            float dx = e.X - ImageCenter.X;
            float dy = e.Y - ImageCenter.Y;
            StartAngle = (float)Math.Atan2(dy, dx);
        }

        private void c_PBArrow_MouseMove(object sender, MouseEventArgs e)
        {
            // Do nothing if there's no drag in progress.
            if (!DragInProgress) return;

            // Get the angle from horizontal to the
            // vector between the center and the current point.
            float dx = e.X - ImageCenter.X;
            float dy = e.Y - ImageCenter.Y;
            float new_angle = (float)Math.Atan2(dy, dx);

            // Calculate the change in angle.
            CurrentAngle = new_angle - StartAngle;

            // Convert to degrees.
            CurrentAngle *= 180 / (float)Math.PI;

            // Add to the previous total angle rotated.
            CurrentAngle += TotalAngle;

            if (CurrentAngle > 180)
                CurrentAngle = 0;
            c_TBAngle.Text = CurrentAngle.ToString();

            // Rotate the original image to make the result bitmap.
            RotatedBitmap = RotateBitmap(OriginalBitmap, CurrentAngle);

            // Display the result.
            c_PBArrow.Image = RotatedBitmap;
            c_PBArrow.Refresh();
        }

        private void c_PBArrow_MouseUp(object sender, MouseEventArgs e)
        {
            DragInProgress = false;

            // Save the new total angle of rotation.
            TotalAngle = CurrentAngle;
        }

        private void Parabolic_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }
    }   
}