namespace SimuladorFisico
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
            this.text_gravedad = new System.Windows.Forms.TextBox();
            this.label_gravedad = new System.Windows.Forms.Label();
            this.button_simular = new System.Windows.Forms.Button();
            this.text_brazo1 = new System.Windows.Forms.TextBox();
            this.text_angulo1 = new System.Windows.Forms.TextBox();
            this.label_angulo = new System.Windows.Forms.Label();
            this.label_ArmLen = new System.Windows.Forms.Label();
            this.otherBall = new System.Windows.Forms.PictureBox();
            this.redBall = new System.Windows.Forms.PictureBox();
            this.blueBall = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_brazo2 = new System.Windows.Forms.TextBox();
            this.text_angulo2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.text_masa1 = new System.Windows.Forms.TextBox();
            this.text_masa2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.otherBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueBall)).BeginInit();
            this.SuspendLayout();
            // 
            // text_gravedad
            // 
            this.text_gravedad.Location = new System.Drawing.Point(649, 116);
            this.text_gravedad.Name = "text_gravedad";
            this.text_gravedad.Size = new System.Drawing.Size(47, 20);
            this.text_gravedad.TabIndex = 22;
            this.text_gravedad.Text = "1";
            // 
            // label_gravedad
            // 
            this.label_gravedad.AutoSize = true;
            this.label_gravedad.Location = new System.Drawing.Point(627, 119);
            this.label_gravedad.Name = "label_gravedad";
            this.label_gravedad.Size = new System.Drawing.Size(16, 13);
            this.label_gravedad.TabIndex = 21;
            this.label_gravedad.Text = "g:";
            // 
            // button_simular
            // 
            this.button_simular.Location = new System.Drawing.Point(626, 197);
            this.button_simular.Name = "button_simular";
            this.button_simular.Size = new System.Drawing.Size(66, 37);
            this.button_simular.TabIndex = 20;
            this.button_simular.Text = "Modificar Simulacion";
            this.button_simular.UseVisualStyleBackColor = true;
            this.button_simular.Click += new System.EventHandler(this.button_simular_Click);
            // 
            // text_brazo1
            // 
            this.text_brazo1.Location = new System.Drawing.Point(649, 12);
            this.text_brazo1.Name = "text_brazo1";
            this.text_brazo1.Size = new System.Drawing.Size(47, 20);
            this.text_brazo1.TabIndex = 18;
            this.text_brazo1.Text = "100";
            // 
            // text_angulo1
            // 
            this.text_angulo1.Location = new System.Drawing.Point(649, 64);
            this.text_angulo1.Name = "text_angulo1";
            this.text_angulo1.Size = new System.Drawing.Size(47, 20);
            this.text_angulo1.TabIndex = 17;
            this.text_angulo1.Text = "45";
            // 
            // label_angulo
            // 
            this.label_angulo.AutoSize = true;
            this.label_angulo.Location = new System.Drawing.Point(591, 67);
            this.label_angulo.Name = "label_angulo";
            this.label_angulo.Size = new System.Drawing.Size(52, 13);
            this.label_angulo.TabIndex = 16;
            this.label_angulo.Text = "Angulo 1:";
            // 
            // label_ArmLen
            // 
            this.label_ArmLen.AutoSize = true;
            this.label_ArmLen.BackColor = System.Drawing.Color.Transparent;
            this.label_ArmLen.Location = new System.Drawing.Point(538, 15);
            this.label_ArmLen.Name = "label_ArmLen";
            this.label_ArmLen.Size = new System.Drawing.Size(105, 13);
            this.label_ArmLen.TabIndex = 15;
            this.label_ArmLen.Text = "Longitud de Brazo 1:";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(538, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Longitud de Brazo 2:";
            // 
            // text_brazo2
            // 
            this.text_brazo2.Location = new System.Drawing.Point(649, 38);
            this.text_brazo2.Name = "text_brazo2";
            this.text_brazo2.Size = new System.Drawing.Size(47, 20);
            this.text_brazo2.TabIndex = 28;
            this.text_brazo2.Text = "100";
            // 
            // text_angulo2
            // 
            this.text_angulo2.Location = new System.Drawing.Point(649, 90);
            this.text_angulo2.Name = "text_angulo2";
            this.text_angulo2.Size = new System.Drawing.Size(47, 20);
            this.text_angulo2.TabIndex = 30;
            this.text_angulo2.Text = "45";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(591, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Angulo 2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(598, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Masa 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(598, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Masa 2:";
            // 
            // text_masa1
            // 
            this.text_masa1.Location = new System.Drawing.Point(649, 142);
            this.text_masa1.Name = "text_masa1";
            this.text_masa1.Size = new System.Drawing.Size(47, 20);
            this.text_masa1.TabIndex = 33;
            this.text_masa1.Text = "10";
            // 
            // text_masa2
            // 
            this.text_masa2.Location = new System.Drawing.Point(649, 168);
            this.text_masa2.Name = "text_masa2";
            this.text_masa2.Size = new System.Drawing.Size(47, 20);
            this.text_masa2.TabIndex = 34;
            this.text_masa2.Text = "10";
            // 
            // PenduloDoble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.text_masa2);
            this.Controls.Add(this.text_masa1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_angulo2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_brazo2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.otherBall);
            this.Controls.Add(this.text_gravedad);
            this.Controls.Add(this.label_gravedad);
            this.Controls.Add(this.button_simular);
            this.Controls.Add(this.text_brazo1);
            this.Controls.Add(this.text_angulo1);
            this.Controls.Add(this.label_angulo);
            this.Controls.Add(this.label_ArmLen);
            this.Controls.Add(this.redBall);
            this.Controls.Add(this.blueBall);
            this.Name = "PenduloDoble";
            this.Text = "PenduloDoble";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PenduloDoble_FormClosed);
            this.Load += new System.EventHandler(this.PenduloDoble_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PenduloDoble_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.otherBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueBall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox text_gravedad;
        private System.Windows.Forms.Label label_gravedad;
        private System.Windows.Forms.Button button_simular;
        private System.Windows.Forms.TextBox text_brazo1;
        private System.Windows.Forms.TextBox text_angulo1;
        private System.Windows.Forms.Label label_angulo;
        private System.Windows.Forms.Label label_ArmLen;
        public System.Windows.Forms.PictureBox redBall;
        public System.Windows.Forms.PictureBox blueBall;
        private System.Windows.Forms.PictureBox otherBall;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_brazo2;
        private System.Windows.Forms.TextBox text_angulo2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_masa1;
        private System.Windows.Forms.TextBox text_masa2;
    }
}