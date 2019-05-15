namespace SimuladorFisico
{
    partial class MainMenu
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
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.c_BTCentrif = new System.Windows.Forms.Button();
            this.c_BTParab = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::SimuladorFisico.Properties.Resources.colon;
            this.button3.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(151, 148);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 194);
            this.button3.TabIndex = 5;
            this.button3.Text = "Ley de Coloumb";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SimuladorFisico.Properties.Resources.salir1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(325, 280);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 62);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::SimuladorFisico.Properties.Resources.doble;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(261, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(243, 128);
            this.button2.TabIndex = 3;
            this.button2.Text = "Pendulo Doble";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::SimuladorFisico.Properties.Resources.simple;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(12, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 196);
            this.button1.TabIndex = 2;
            this.button1.Text = "Pendulo Simple";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // c_BTCentrif
            // 
            this.c_BTCentrif.BackgroundImage = global::SimuladorFisico.Properties.Resources.centrifuga;
            this.c_BTCentrif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.c_BTCentrif.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_BTCentrif.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.c_BTCentrif.Location = new System.Drawing.Point(325, 146);
            this.c_BTCentrif.Name = "c_BTCentrif";
            this.c_BTCentrif.Size = new System.Drawing.Size(179, 128);
            this.c_BTCentrif.TabIndex = 1;
            this.c_BTCentrif.Text = "Fuerza Centrifuga";
            this.c_BTCentrif.UseVisualStyleBackColor = true;
            this.c_BTCentrif.Click += new System.EventHandler(this.c_BTCentrif_Click);
            // 
            // c_BTParab
            // 
            this.c_BTParab.BackgroundImage = global::SimuladorFisico.Properties.Resources.parabolico;
            this.c_BTParab.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_BTParab.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.c_BTParab.Location = new System.Drawing.Point(12, 14);
            this.c_BTParab.Name = "c_BTParab";
            this.c_BTParab.Size = new System.Drawing.Size(243, 128);
            this.c_BTParab.TabIndex = 0;
            this.c_BTParab.Text = "Movimiento Parabolico";
            this.c_BTParab.UseVisualStyleBackColor = true;
            this.c_BTParab.Click += new System.EventHandler(this.c_BTParab_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 360);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.c_BTCentrif);
            this.Controls.Add(this.c_BTParab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulador Fisico";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button c_BTParab;
        private System.Windows.Forms.Button c_BTCentrif;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
    }
}