namespace SimuladorFisico
{
    partial class Centrifuga
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Centrifuga));
            this.c_LStop = new System.Windows.Forms.Label();
            this.c_Lstart = new System.Windows.Forms.Label();
            this.c_TBMasa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.c_TBRadio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.c_RBPerio = new System.Windows.Forms.RadioButton();
            this.c_RBVel = new System.Windows.Forms.RadioButton();
            this.c_RBAcel = new System.Windows.Forms.RadioButton();
            this.c_TBParam = new System.Windows.Forms.TextBox();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // c_LStop
            // 
            this.c_LStop.AutoSize = true;
            this.c_LStop.BackColor = System.Drawing.Color.Transparent;
            this.c_LStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_LStop.Location = new System.Drawing.Point(142, 578);
            this.c_LStop.Name = "c_LStop";
            this.c_LStop.Size = new System.Drawing.Size(39, 46);
            this.c_LStop.TabIndex = 19;
            this.c_LStop.Text = "◙";
            this.c_LStop.Click += new System.EventHandler(this.c_LStop_Click);
            // 
            // c_Lstart
            // 
            this.c_Lstart.AutoSize = true;
            this.c_Lstart.BackColor = System.Drawing.Color.Transparent;
            this.c_Lstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_Lstart.Location = new System.Drawing.Point(98, 578);
            this.c_Lstart.Name = "c_Lstart";
            this.c_Lstart.Size = new System.Drawing.Size(38, 46);
            this.c_Lstart.TabIndex = 18;
            this.c_Lstart.Text = "►";
            this.c_Lstart.Click += new System.EventHandler(this.c_Lstart_Click);
            // 
            // c_TBMasa
            // 
            this.c_TBMasa.Location = new System.Drawing.Point(29, 499);
            this.c_TBMasa.Name = "c_TBMasa";
            this.c_TBMasa.Size = new System.Drawing.Size(100, 20);
            this.c_TBMasa.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(26, 479);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Masa";
            // 
            // c_TBRadio
            // 
            this.c_TBRadio.Location = new System.Drawing.Point(150, 499);
            this.c_TBRadio.Name = "c_TBRadio";
            this.c_TBRadio.Size = new System.Drawing.Size(100, 20);
            this.c_TBRadio.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(147, 479);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Radio";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // c_RBPerio
            // 
            this.c_RBPerio.AutoSize = true;
            this.c_RBPerio.BackColor = System.Drawing.Color.Transparent;
            this.c_RBPerio.Location = new System.Drawing.Point(29, 532);
            this.c_RBPerio.Name = "c_RBPerio";
            this.c_RBPerio.Size = new System.Drawing.Size(61, 17);
            this.c_RBPerio.TabIndex = 24;
            this.c_RBPerio.Text = "Periodo";
            this.c_RBPerio.UseVisualStyleBackColor = false;
            // 
            // c_RBVel
            // 
            this.c_RBVel.AutoSize = true;
            this.c_RBVel.BackColor = System.Drawing.Color.Transparent;
            this.c_RBVel.Checked = true;
            this.c_RBVel.Location = new System.Drawing.Point(96, 532);
            this.c_RBVel.Name = "c_RBVel";
            this.c_RBVel.Size = new System.Drawing.Size(72, 17);
            this.c_RBVel.TabIndex = 25;
            this.c_RBVel.TabStop = true;
            this.c_RBVel.Text = "Velocidad";
            this.c_RBVel.UseVisualStyleBackColor = false;
            // 
            // c_RBAcel
            // 
            this.c_RBAcel.AutoSize = true;
            this.c_RBAcel.BackColor = System.Drawing.Color.Transparent;
            this.c_RBAcel.Location = new System.Drawing.Point(180, 532);
            this.c_RBAcel.Name = "c_RBAcel";
            this.c_RBAcel.Size = new System.Drawing.Size(81, 17);
            this.c_RBAcel.TabIndex = 26;
            this.c_RBAcel.Text = "Aceleracion";
            this.c_RBAcel.UseVisualStyleBackColor = false;
            // 
            // c_TBParam
            // 
            this.c_TBParam.Location = new System.Drawing.Point(91, 555);
            this.c_TBParam.Name = "c_TBParam";
            this.c_TBParam.Size = new System.Drawing.Size(100, 20);
            this.c_TBParam.TabIndex = 27;
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // Centrifuga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1174, 644);
            this.Controls.Add(this.c_TBParam);
            this.Controls.Add(this.c_RBAcel);
            this.Controls.Add(this.c_RBVel);
            this.Controls.Add(this.c_RBPerio);
            this.Controls.Add(this.c_TBRadio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.c_TBMasa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.c_LStop);
            this.Controls.Add(this.c_Lstart);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Centrifuga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Centrifuga";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Centrifuga_FormClosed);
            this.Load += new System.EventHandler(this.Centrifuga_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Centrifuga_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label c_LStop;
        private System.Windows.Forms.Label c_Lstart;
        private System.Windows.Forms.TextBox c_TBMasa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox c_TBRadio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton c_RBPerio;
        private System.Windows.Forms.RadioButton c_RBVel;
        private System.Windows.Forms.RadioButton c_RBAcel;
        private System.Windows.Forms.TextBox c_TBParam;
        private System.Windows.Forms.ErrorProvider error;
    }
}