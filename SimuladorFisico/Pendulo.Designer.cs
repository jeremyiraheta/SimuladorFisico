namespace SimuladorFisico
{
    partial class Pendulo
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
            this.label_ArmLen = new System.Windows.Forms.Label();
            this.redBall = new System.Windows.Forms.PictureBox();
            this.blueBall = new System.Windows.Forms.PictureBox();
            this.label_angulo = new System.Windows.Forms.Label();
            this.text_angulo = new System.Windows.Forms.TextBox();
            this.text_lenBrazo = new System.Windows.Forms.TextBox();
            this.label_AceleracionAngular = new System.Windows.Forms.Label();
            this.button_simular = new System.Windows.Forms.Button();
            this.label_gravedad = new System.Windows.Forms.Label();
            this.text_gravedad = new System.Windows.Forms.TextBox();
            this.label_VelocidadAngular = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.text_eficiencia = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.redBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueBall)).BeginInit();
            this.SuspendLayout();
            // 
            // label_ArmLen
            // 
            this.label_ArmLen.AutoSize = true;
            this.label_ArmLen.BackColor = System.Drawing.Color.Transparent;
            this.label_ArmLen.Location = new System.Drawing.Point(547, 9);
            this.label_ArmLen.Name = "label_ArmLen";
            this.label_ArmLen.Size = new System.Drawing.Size(96, 13);
            this.label_ArmLen.TabIndex = 2;
            this.label_ArmLen.Text = "Longitud de Brazo:";
            // 
            // redBall
            // 
            this.redBall.BackColor = System.Drawing.Color.Transparent;
            this.redBall.Image = global::SimuladorFisico.Properties.Resources.red_box;
            this.redBall.Location = new System.Drawing.Point(12, 50);
            this.redBall.Name = "redBall";
            this.redBall.Size = new System.Drawing.Size(32, 32);
            this.redBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.redBall.TabIndex = 1;
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
            this.blueBall.TabIndex = 0;
            this.blueBall.TabStop = false;
            // 
            // label_angulo
            // 
            this.label_angulo.AutoSize = true;
            this.label_angulo.Location = new System.Drawing.Point(600, 35);
            this.label_angulo.Name = "label_angulo";
            this.label_angulo.Size = new System.Drawing.Size(43, 13);
            this.label_angulo.TabIndex = 3;
            this.label_angulo.Text = "Angulo:";
            // 
            // text_angulo
            // 
            this.text_angulo.Location = new System.Drawing.Point(649, 32);
            this.text_angulo.Name = "text_angulo";
            this.text_angulo.Size = new System.Drawing.Size(47, 20);
            this.text_angulo.TabIndex = 4;
            this.text_angulo.Text = "45";
            // 
            // text_lenBrazo
            // 
            this.text_lenBrazo.Location = new System.Drawing.Point(649, 6);
            this.text_lenBrazo.Name = "text_lenBrazo";
            this.text_lenBrazo.Size = new System.Drawing.Size(47, 20);
            this.text_lenBrazo.TabIndex = 5;
            this.text_lenBrazo.Text = "200";
            // 
            // label_AceleracionAngular
            // 
            this.label_AceleracionAngular.AutoSize = true;
            this.label_AceleracionAngular.Location = new System.Drawing.Point(12, 419);
            this.label_AceleracionAngular.Name = "label_AceleracionAngular";
            this.label_AceleracionAngular.Size = new System.Drawing.Size(114, 13);
            this.label_AceleracionAngular.TabIndex = 6;
            this.label_AceleracionAngular.Text = "Aceleracion Angular = ";
            // 
            // button_simular
            // 
            this.button_simular.Location = new System.Drawing.Point(576, 110);
            this.button_simular.Name = "button_simular";
            this.button_simular.Size = new System.Drawing.Size(120, 23);
            this.button_simular.TabIndex = 7;
            this.button_simular.Text = "Modificar Simulacion";
            this.button_simular.UseVisualStyleBackColor = true;
            this.button_simular.Click += new System.EventHandler(this.button_simular_Click);
            // 
            // label_gravedad
            // 
            this.label_gravedad.AutoSize = true;
            this.label_gravedad.Location = new System.Drawing.Point(586, 61);
            this.label_gravedad.Name = "label_gravedad";
            this.label_gravedad.Size = new System.Drawing.Size(57, 13);
            this.label_gravedad.TabIndex = 8;
            this.label_gravedad.Text = "Gravedad:";
            // 
            // text_gravedad
            // 
            this.text_gravedad.Location = new System.Drawing.Point(649, 58);
            this.text_gravedad.Name = "text_gravedad";
            this.text_gravedad.Size = new System.Drawing.Size(47, 20);
            this.text_gravedad.TabIndex = 9;
            this.text_gravedad.Text = "0.8";
            // 
            // label_VelocidadAngular
            // 
            this.label_VelocidadAngular.AutoSize = true;
            this.label_VelocidadAngular.Location = new System.Drawing.Point(21, 406);
            this.label_VelocidadAngular.Name = "label_VelocidadAngular";
            this.label_VelocidadAngular.Size = new System.Drawing.Size(105, 13);
            this.label_VelocidadAngular.TabIndex = 10;
            this.label_VelocidadAngular.Text = "Velocidad Angular = ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(587, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Eficiencia:";
            // 
            // text_eficiencia
            // 
            this.text_eficiencia.Location = new System.Drawing.Point(649, 84);
            this.text_eficiencia.Name = "text_eficiencia";
            this.text_eficiencia.Size = new System.Drawing.Size(47, 20);
            this.text_eficiencia.TabIndex = 12;
            this.text_eficiencia.Text = "99";
            // 
            // Pendulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.text_eficiencia);
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
            this.Name = "Pendulo";
            this.Text = "Pendulo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Pendulo_FormClosed);
            this.Load += new System.EventHandler(this.Pendulo_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Pendulo_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.redBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueBall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox blueBall;
        public System.Windows.Forms.PictureBox redBall;
        private System.Windows.Forms.Label label_ArmLen;
        private System.Windows.Forms.Label label_angulo;
        private System.Windows.Forms.TextBox text_angulo;
        private System.Windows.Forms.TextBox text_lenBrazo;
        private System.Windows.Forms.Label label_AceleracionAngular;
        private System.Windows.Forms.Button button_simular;
        private System.Windows.Forms.Label label_gravedad;
        private System.Windows.Forms.TextBox text_gravedad;
        private System.Windows.Forms.Label label_VelocidadAngular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_eficiencia;
    }
}