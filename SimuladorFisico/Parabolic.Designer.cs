namespace SimuladorFisico
{
    partial class Parabolic
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parabolic));
            this.c_PBBall = new System.Windows.Forms.PictureBox();
            this.c_PBArrow = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.c_TBVel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.c_TBAngle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.c_CBGrav = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.c_LY = new System.Windows.Forms.Label();
            this.c_LX = new System.Windows.Forms.Label();
            this.c_Lstart = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.c_LAy = new System.Windows.Forms.Label();
            this.c_LAx = new System.Windows.Forms.Label();
            this.c_LStop = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.c_LT = new System.Windows.Forms.Label();
            this.c_Track = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.c_PBBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_PBArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_Track)).BeginInit();
            this.SuspendLayout();
            // 
            // c_PBBall
            // 
            this.c_PBBall.BackColor = System.Drawing.Color.Transparent;
            this.c_PBBall.Image = global::SimuladorFisico.Properties.Resources.ball;
            this.c_PBBall.Location = new System.Drawing.Point(0, 532);
            this.c_PBBall.Name = "c_PBBall";
            this.c_PBBall.Size = new System.Drawing.Size(46, 38);
            this.c_PBBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.c_PBBall.TabIndex = 0;
            this.c_PBBall.TabStop = false;
            // 
            // c_PBArrow
            // 
            this.c_PBArrow.BackColor = System.Drawing.Color.Transparent;
            this.c_PBArrow.Image = global::SimuladorFisico.Properties.Resources.arrow;
            this.c_PBArrow.Location = new System.Drawing.Point(0, 493);
            this.c_PBArrow.Name = "c_PBArrow";
            this.c_PBArrow.Size = new System.Drawing.Size(102, 77);
            this.c_PBArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.c_PBArrow.TabIndex = 1;
            this.c_PBArrow.TabStop = false;
            this.c_PBArrow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.c_PBArrow_MouseDown);
            this.c_PBArrow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.c_PBArrow_MouseMove);
            this.c_PBArrow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.c_PBArrow_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(384, 588);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Velocidad Inicial(M/S)";
            // 
            // c_TBVel
            // 
            this.c_TBVel.Location = new System.Drawing.Point(387, 607);
            this.c_TBVel.Name = "c_TBVel";
            this.c_TBVel.Size = new System.Drawing.Size(106, 20);
            this.c_TBVel.TabIndex = 3;
            this.c_TBVel.TextChanged += new System.EventHandler(this.c_CBVel_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(501, 588);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Angulo(º)";
            // 
            // c_TBAngle
            // 
            this.c_TBAngle.Location = new System.Drawing.Point(504, 608);
            this.c_TBAngle.Name = "c_TBAngle";
            this.c_TBAngle.Size = new System.Drawing.Size(100, 20);
            this.c_TBAngle.TabIndex = 5;
            this.c_TBAngle.Text = "45";
            this.c_TBAngle.TextChanged += new System.EventHandler(this.c_TBAngle_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(612, 588);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Gravedad";
            // 
            // c_CBGrav
            // 
            this.c_CBGrav.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.c_CBGrav.FormattingEnabled = true;
            this.c_CBGrav.Location = new System.Drawing.Point(615, 608);
            this.c_CBGrav.Name = "c_CBGrav";
            this.c_CBGrav.Size = new System.Drawing.Size(121, 21);
            this.c_CBGrav.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(865, 588);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Y Maximo(M): ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(865, 607);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "X Maximo(M): ";
            // 
            // c_LY
            // 
            this.c_LY.AutoSize = true;
            this.c_LY.BackColor = System.Drawing.Color.Transparent;
            this.c_LY.ForeColor = System.Drawing.Color.Lime;
            this.c_LY.Location = new System.Drawing.Point(930, 588);
            this.c_LY.Name = "c_LY";
            this.c_LY.Size = new System.Drawing.Size(13, 13);
            this.c_LY.TabIndex = 10;
            this.c_LY.Text = "0";
            // 
            // c_LX
            // 
            this.c_LX.AutoSize = true;
            this.c_LX.BackColor = System.Drawing.Color.Transparent;
            this.c_LX.ForeColor = System.Drawing.Color.Red;
            this.c_LX.Location = new System.Drawing.Point(930, 608);
            this.c_LX.Name = "c_LX";
            this.c_LX.Size = new System.Drawing.Size(13, 13);
            this.c_LX.TabIndex = 11;
            this.c_LX.Text = "0";
            // 
            // c_Lstart
            // 
            this.c_Lstart.AutoSize = true;
            this.c_Lstart.BackColor = System.Drawing.Color.Transparent;
            this.c_Lstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_Lstart.Location = new System.Drawing.Point(755, 588);
            this.c_Lstart.Name = "c_Lstart";
            this.c_Lstart.Size = new System.Drawing.Size(38, 46);
            this.c_Lstart.TabIndex = 12;
            this.c_Lstart.Text = "►";
            this.c_Lstart.Click += new System.EventHandler(this.c_Lstart_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(973, 607);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "X(M): ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(973, 588);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Y(M): ";
            // 
            // c_LAy
            // 
            this.c_LAy.AutoSize = true;
            this.c_LAy.BackColor = System.Drawing.Color.Transparent;
            this.c_LAy.ForeColor = System.Drawing.Color.Lime;
            this.c_LAy.Location = new System.Drawing.Point(999, 588);
            this.c_LAy.Name = "c_LAy";
            this.c_LAy.Size = new System.Drawing.Size(13, 13);
            this.c_LAy.TabIndex = 15;
            this.c_LAy.Text = "0";
            // 
            // c_LAx
            // 
            this.c_LAx.AutoSize = true;
            this.c_LAx.BackColor = System.Drawing.Color.Transparent;
            this.c_LAx.ForeColor = System.Drawing.Color.Red;
            this.c_LAx.Location = new System.Drawing.Point(999, 609);
            this.c_LAx.Name = "c_LAx";
            this.c_LAx.Size = new System.Drawing.Size(13, 13);
            this.c_LAx.TabIndex = 16;
            this.c_LAx.Text = "0";
            // 
            // c_LStop
            // 
            this.c_LStop.AutoSize = true;
            this.c_LStop.BackColor = System.Drawing.Color.Transparent;
            this.c_LStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_LStop.Location = new System.Drawing.Point(799, 588);
            this.c_LStop.Name = "c_LStop";
            this.c_LStop.Size = new System.Drawing.Size(39, 46);
            this.c_LStop.TabIndex = 17;
            this.c_LStop.Text = "◙";
            this.c_LStop.Click += new System.EventHandler(this.c_LStop_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(1044, 588);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Tiempo(s): ";
            // 
            // c_LT
            // 
            this.c_LT.AutoSize = true;
            this.c_LT.BackColor = System.Drawing.Color.Transparent;
            this.c_LT.ForeColor = System.Drawing.Color.Blue;
            this.c_LT.Location = new System.Drawing.Point(1102, 588);
            this.c_LT.Name = "c_LT";
            this.c_LT.Size = new System.Drawing.Size(13, 13);
            this.c_LT.TabIndex = 19;
            this.c_LT.Text = "0";
            // 
            // c_Track
            // 
            this.c_Track.BackColor = System.Drawing.Color.Green;
            this.c_Track.Location = new System.Drawing.Point(134, 592);
            this.c_Track.Maximum = 100;
            this.c_Track.Minimum = 1;
            this.c_Track.Name = "c_Track";
            this.c_Track.Size = new System.Drawing.Size(247, 45);
            this.c_Track.SmallChange = 10;
            this.c_Track.TabIndex = 20;
            this.c_Track.Value = 1;
            this.c_Track.Scroll += new System.EventHandler(this.c_Track_Scroll);
            // 
            // Parabolic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SimuladorFisico.Properties.Resources.back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1174, 644);
            this.Controls.Add(this.c_Track);
            this.Controls.Add(this.c_LT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.c_LStop);
            this.Controls.Add(this.c_LAx);
            this.Controls.Add(this.c_LAy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.c_Lstart);
            this.Controls.Add(this.c_LX);
            this.Controls.Add(this.c_LY);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.c_CBGrav);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.c_TBAngle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.c_TBVel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.c_PBBall);
            this.Controls.Add(this.c_PBArrow);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Parabolic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulador Movimiento Parabolico";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Parabolic_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.c_PBBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_PBArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_Track)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox c_PBBall;
        private System.Windows.Forms.PictureBox c_PBArrow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox c_TBVel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox c_TBAngle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox c_CBGrav;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label c_LY;
        private System.Windows.Forms.Label c_LX;
        private System.Windows.Forms.Label c_Lstart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label c_LAy;
        private System.Windows.Forms.Label c_LAx;
        private System.Windows.Forms.Label c_LStop;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label c_LT;
        private System.Windows.Forms.TrackBar c_Track;
    }

}

