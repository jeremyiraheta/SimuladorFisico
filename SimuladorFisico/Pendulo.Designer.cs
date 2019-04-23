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
            this.redBall = new System.Windows.Forms.PictureBox();
            this.blueBall = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.redBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueBall)).BeginInit();
            this.SuspendLayout();
            // 
            // redBall
            // 
            this.redBall.Image = global::SimuladorFisico.Properties.Resources.red_box;
            this.redBall.Location = new System.Drawing.Point(246, 289);
            this.redBall.Name = "redBall";
            this.redBall.Size = new System.Drawing.Size(32, 32);
            this.redBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.redBall.TabIndex = 1;
            this.redBall.TabStop = false;
            this.redBall.MouseDown += new System.Windows.Forms.MouseEventHandler(this.redBall_MouseDown);
            this.redBall.MouseUp += new System.Windows.Forms.MouseEventHandler(this.redBall_MouseUp);
            // 
            // blueBall
            // 
            this.blueBall.Image = global::SimuladorFisico.Properties.Resources.blue_ball;
            this.blueBall.Location = new System.Drawing.Point(378, 192);
            this.blueBall.Name = "blueBall";
            this.blueBall.Size = new System.Drawing.Size(32, 32);
            this.blueBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.blueBall.TabIndex = 0;
            this.blueBall.TabStop = false;
            // 
            // Pendulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(806, 474);
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
    }
}