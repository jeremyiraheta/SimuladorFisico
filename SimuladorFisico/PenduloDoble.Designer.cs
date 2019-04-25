﻿namespace SimuladorFisico
{
    partial class PenduloDoble
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numericUpDown_friccion = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label_VelocidadAngular = new System.Windows.Forms.Label();
            this.text_gravedad = new System.Windows.Forms.TextBox();
            this.label_gravedad = new System.Windows.Forms.Label();
            this.button_simular = new System.Windows.Forms.Button();
            this.label_AceleracionAngular = new System.Windows.Forms.Label();
            this.text_lenBrazo = new System.Windows.Forms.TextBox();
            this.text_angulo = new System.Windows.Forms.TextBox();
            this.label_angulo = new System.Windows.Forms.Label();
            this.label_ArmLen = new System.Windows.Forms.Label();
            this.otherBall = new System.Windows.Forms.PictureBox();
            this.redBall = new System.Windows.Forms.PictureBox();
            this.blueBall = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_friccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otherBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueBall)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown_friccion
            // 
            this.numericUpDown_friccion.Location = new System.Drawing.Point(649, 84);
            this.numericUpDown_friccion.Name = "numericUpDown_friccion";
            this.numericUpDown_friccion.Size = new System.Drawing.Size(47, 20);
            this.numericUpDown_friccion.TabIndex = 25;
            this.numericUpDown_friccion.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(596, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Friccion:";
            // 
            // label_VelocidadAngular
            // 
            this.label_VelocidadAngular.AutoSize = true;
            this.label_VelocidadAngular.Location = new System.Drawing.Point(21, 406);
            this.label_VelocidadAngular.Name = "label_VelocidadAngular";
            this.label_VelocidadAngular.Size = new System.Drawing.Size(105, 13);
            this.label_VelocidadAngular.TabIndex = 23;
            this.label_VelocidadAngular.Text = "Velocidad Angular = ";
            // 
            // text_gravedad
            // 
            this.text_gravedad.Location = new System.Drawing.Point(649, 58);
            this.text_gravedad.Name = "text_gravedad";
            this.text_gravedad.Size = new System.Drawing.Size(47, 20);
            this.text_gravedad.TabIndex = 22;
            this.text_gravedad.Text = "9.8";
            // 
            // label_gravedad
            // 
            this.label_gravedad.AutoSize = true;
            this.label_gravedad.Location = new System.Drawing.Point(586, 61);
            this.label_gravedad.Name = "label_gravedad";
            this.label_gravedad.Size = new System.Drawing.Size(57, 13);
            this.label_gravedad.TabIndex = 21;
            this.label_gravedad.Text = "Gravedad:";
            // 
            // button_simular
            // 
            this.button_simular.Location = new System.Drawing.Point(576, 110);
            this.button_simular.Name = "button_simular";
            this.button_simular.Size = new System.Drawing.Size(120, 23);
            this.button_simular.TabIndex = 20;
            this.button_simular.Text = "Modificar Simulacion";
            this.button_simular.UseVisualStyleBackColor = true;
            this.button_simular.Click += new System.EventHandler(this.button_simular_Click);
            // 
            // label_AceleracionAngular
            // 
            this.label_AceleracionAngular.AutoSize = true;
            this.label_AceleracionAngular.Location = new System.Drawing.Point(12, 419);
            this.label_AceleracionAngular.Name = "label_AceleracionAngular";
            this.label_AceleracionAngular.Size = new System.Drawing.Size(114, 13);
            this.label_AceleracionAngular.TabIndex = 19;
            this.label_AceleracionAngular.Text = "Aceleracion Angular = ";
            // 
            // text_lenBrazo
            // 
            this.text_lenBrazo.Location = new System.Drawing.Point(649, 6);
            this.text_lenBrazo.Name = "text_lenBrazo";
            this.text_lenBrazo.Size = new System.Drawing.Size(47, 20);
            this.text_lenBrazo.TabIndex = 18;
            this.text_lenBrazo.Text = "100";
            // 
            // text_angulo
            // 
            this.text_angulo.Location = new System.Drawing.Point(649, 32);
            this.text_angulo.Name = "text_angulo";
            this.text_angulo.Size = new System.Drawing.Size(47, 20);
            this.text_angulo.TabIndex = 17;
            this.text_angulo.Text = "45";
            // 
            // label_angulo
            // 
            this.label_angulo.AutoSize = true;
            this.label_angulo.Location = new System.Drawing.Point(600, 35);
            this.label_angulo.Name = "label_angulo";
            this.label_angulo.Size = new System.Drawing.Size(43, 13);
            this.label_angulo.TabIndex = 16;
            this.label_angulo.Text = "Angulo:";
            // 
            // label_ArmLen
            // 
            this.label_ArmLen.AutoSize = true;
            this.label_ArmLen.BackColor = System.Drawing.Color.Transparent;
            this.label_ArmLen.Location = new System.Drawing.Point(547, 9);
            this.label_ArmLen.Name = "label_ArmLen";
            this.label_ArmLen.Size = new System.Drawing.Size(96, 13);
            this.label_ArmLen.TabIndex = 15;
            this.label_ArmLen.Text = "Longitud de Brazo:";
            // 
            // otherBall
            // 
            this.otherBall.BackColor = System.Drawing.Color.Transparent;
            this.otherBall.Image = global::SimuladorFisico.Properties.Resources.red_box;
            this.otherBall.Location = new System.Drawing.Point(12, 88);
            this.otherBall.Name = "otherBall";
            this.otherBall.Size = new System.Drawing.Size(32, 32);
            this.otherBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.otherBall.TabIndex = 26;
            this.otherBall.TabStop = false;
            // 
            // redBall
            // 
            this.redBall.BackColor = System.Drawing.Color.Transparent;
            this.redBall.Image = global::SimuladorFisico.Properties.Resources.red_box;
            this.redBall.Location = new System.Drawing.Point(12, 50);
            this.redBall.Name = "redBall";
            this.redBall.Size = new System.Drawing.Size(32, 32);
            this.redBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.redBall.TabIndex = 14;
            this.redBall.TabStop = false;
            // 
            // blueBall
            // 
            this.blueBall.BackColor = System.Drawing.Color.Transparent;
            this.blueBall.Image = global::SimuladorFisico.Properties.Resources.blue_ball;
            this.blueBall.Location = new System.Drawing.Point(12, 12);
            this.blueBall.Name = "blueBall";
            this.blueBall.Size = new System.Drawing.Size(32, 32);
            this.blueBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.blueBall.TabIndex = 13;
            this.blueBall.TabStop = false;
            // 
            // PenduloDoble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.otherBall);
            this.Controls.Add(this.numericUpDown_friccion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_VelocidadAngular);
            this.Controls.Add(this.text_gravedad);
            this.Controls.Add(this.label_gravedad);
            this.Controls.Add(this.button_simular);
            this.Controls.Add(this.label_AceleracionAngular);
            this.Controls.Add(this.text_lenBrazo);
            this.Controls.Add(this.text_angulo);
            this.Controls.Add(this.label_angulo);
            this.Controls.Add(this.label_ArmLen);
            this.Controls.Add(this.redBall);
            this.Controls.Add(this.blueBall);
            this.Name = "PenduloDoble";
            this.Text = "PenduloDoble";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PenduloDoble_FormClosed);
            this.Load += new System.EventHandler(this.PenduloDoble_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PenduloDoble_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_friccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otherBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueBall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown_friccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_VelocidadAngular;
        private System.Windows.Forms.TextBox text_gravedad;
        private System.Windows.Forms.Label label_gravedad;
        private System.Windows.Forms.Button button_simular;
        private System.Windows.Forms.Label label_AceleracionAngular;
        private System.Windows.Forms.TextBox text_lenBrazo;
        private System.Windows.Forms.TextBox text_angulo;
        private System.Windows.Forms.Label label_angulo;
        private System.Windows.Forms.Label label_ArmLen;
        public System.Windows.Forms.PictureBox redBall;
        public System.Windows.Forms.PictureBox blueBall;
        private System.Windows.Forms.PictureBox otherBall;
    }
}