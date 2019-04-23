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
            this.c_BTParab = new System.Windows.Forms.Button();
            this.c_BTCentrif = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // c_BTParab
            // 
            this.c_BTParab.Location = new System.Drawing.Point(29, 46);
            this.c_BTParab.Name = "c_BTParab";
            this.c_BTParab.Size = new System.Drawing.Size(137, 23);
            this.c_BTParab.TabIndex = 0;
            this.c_BTParab.Text = "Movimiento Parabolico";
            this.c_BTParab.UseVisualStyleBackColor = true;
            this.c_BTParab.Click += new System.EventHandler(this.c_BTParab_Click);
            // 
            // c_BTCentrif
            // 
            this.c_BTCentrif.Location = new System.Drawing.Point(196, 46);
            this.c_BTCentrif.Name = "c_BTCentrif";
            this.c_BTCentrif.Size = new System.Drawing.Size(137, 23);
            this.c_BTCentrif.TabIndex = 1;
            this.c_BTCentrif.Text = "Fuerza Centrifuga";
            this.c_BTCentrif.UseVisualStyleBackColor = true;
            this.c_BTCentrif.Click += new System.EventHandler(this.c_BTCentrif_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Pendulo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 135);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button c_BTParab;
        private System.Windows.Forms.Button c_BTCentrif;
        private System.Windows.Forms.Button button1;
    }
}