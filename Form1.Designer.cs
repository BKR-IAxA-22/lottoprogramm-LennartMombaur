namespace Lottoprogramm
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.auslosen = new System.Windows.Forms.Button();
            this.zahl1 = new System.Windows.Forms.TextBox();
            this.zahl2 = new System.Windows.Forms.TextBox();
            this.zahl3 = new System.Windows.Forms.TextBox();
            this.zahl4 = new System.Windows.Forms.TextBox();
            this.zahl6 = new System.Windows.Forms.TextBox();
            this.zahl5 = new System.Windows.Forms.TextBox();
            this.eingabe5 = new System.Windows.Forms.TextBox();
            this.eingabe6 = new System.Windows.Forms.TextBox();
            this.eingabe4 = new System.Windows.Forms.TextBox();
            this.eingabe3 = new System.Windows.Forms.TextBox();
            this.eingabe2 = new System.Windows.Forms.TextBox();
            this.eingabe1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // auslosen
            // 
            this.auslosen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.auslosen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.auslosen.Location = new System.Drawing.Point(260, 80);
            this.auslosen.Name = "auslosen";
            this.auslosen.Size = new System.Drawing.Size(180, 60);
            this.auslosen.TabIndex = 6;
            this.auslosen.Text = "Lottozahlen auslosen";
            this.auslosen.UseVisualStyleBackColor = false;
            this.auslosen.Click += new System.EventHandler(this.auslosen_Click);
            // 
            // zahl1
            // 
            this.zahl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.zahl1.Cursor = System.Windows.Forms.Cursors.No;
            this.zahl1.Location = new System.Drawing.Point(60, 254);
            this.zahl1.Name = "zahl1";
            this.zahl1.ReadOnly = true;
            this.zahl1.Size = new System.Drawing.Size(60, 22);
            this.zahl1.TabIndex = 7;
            this.zahl1.TextChanged += new System.EventHandler(this.zahl1_TextChanged);
            // 
            // zahl2
            // 
            this.zahl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.zahl2.Cursor = System.Windows.Forms.Cursors.No;
            this.zahl2.Location = new System.Drawing.Point(160, 254);
            this.zahl2.Name = "zahl2";
            this.zahl2.ReadOnly = true;
            this.zahl2.Size = new System.Drawing.Size(60, 22);
            this.zahl2.TabIndex = 8;
            this.zahl2.TextChanged += new System.EventHandler(this.zahl2_TextChanged);
            // 
            // zahl3
            // 
            this.zahl3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.zahl3.Cursor = System.Windows.Forms.Cursors.No;
            this.zahl3.Location = new System.Drawing.Point(260, 254);
            this.zahl3.Name = "zahl3";
            this.zahl3.ReadOnly = true;
            this.zahl3.Size = new System.Drawing.Size(60, 22);
            this.zahl3.TabIndex = 9;
            this.zahl3.TextChanged += new System.EventHandler(this.zahl3_TextChanged);
            // 
            // zahl4
            // 
            this.zahl4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.zahl4.Cursor = System.Windows.Forms.Cursors.No;
            this.zahl4.Location = new System.Drawing.Point(360, 254);
            this.zahl4.Name = "zahl4";
            this.zahl4.ReadOnly = true;
            this.zahl4.Size = new System.Drawing.Size(60, 22);
            this.zahl4.TabIndex = 10;
            this.zahl4.TextChanged += new System.EventHandler(this.zahl4_TextChanged);
            // 
            // zahl6
            // 
            this.zahl6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.zahl6.Cursor = System.Windows.Forms.Cursors.No;
            this.zahl6.Location = new System.Drawing.Point(560, 254);
            this.zahl6.Name = "zahl6";
            this.zahl6.ReadOnly = true;
            this.zahl6.Size = new System.Drawing.Size(60, 22);
            this.zahl6.TabIndex = 11;
            this.zahl6.TextChanged += new System.EventHandler(this.zahl6_TextChanged);
            // 
            // zahl5
            // 
            this.zahl5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.zahl5.Cursor = System.Windows.Forms.Cursors.No;
            this.zahl5.Location = new System.Drawing.Point(460, 254);
            this.zahl5.Name = "zahl5";
            this.zahl5.ReadOnly = true;
            this.zahl5.Size = new System.Drawing.Size(60, 22);
            this.zahl5.TabIndex = 12;
            this.zahl5.TextChanged += new System.EventHandler(this.zahl5_TextChanged);
            // 
            // eingabe5
            // 
            this.eingabe5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.eingabe5.Location = new System.Drawing.Point(460, 391);
            this.eingabe5.Name = "eingabe5";
            this.eingabe5.Size = new System.Drawing.Size(60, 22);
            this.eingabe5.TabIndex = 18;
            this.eingabe5.TextChanged += new System.EventHandler(this.eingabe5_TextChanged);
            // 
            // eingabe6
            // 
            this.eingabe6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.eingabe6.Location = new System.Drawing.Point(560, 391);
            this.eingabe6.Name = "eingabe6";
            this.eingabe6.Size = new System.Drawing.Size(60, 22);
            this.eingabe6.TabIndex = 17;
            this.eingabe6.TextChanged += new System.EventHandler(this.eingabe6_TextChanged);
            // 
            // eingabe4
            // 
            this.eingabe4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.eingabe4.Location = new System.Drawing.Point(360, 391);
            this.eingabe4.Name = "eingabe4";
            this.eingabe4.Size = new System.Drawing.Size(60, 22);
            this.eingabe4.TabIndex = 16;
            this.eingabe4.TextChanged += new System.EventHandler(this.eingabe4_TextChanged);
            // 
            // eingabe3
            // 
            this.eingabe3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.eingabe3.Location = new System.Drawing.Point(260, 391);
            this.eingabe3.Name = "eingabe3";
            this.eingabe3.Size = new System.Drawing.Size(60, 22);
            this.eingabe3.TabIndex = 15;
            this.eingabe3.TextChanged += new System.EventHandler(this.eingabe3_TextChanged);
            // 
            // eingabe2
            // 
            this.eingabe2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.eingabe2.Location = new System.Drawing.Point(160, 391);
            this.eingabe2.Name = "eingabe2";
            this.eingabe2.Size = new System.Drawing.Size(60, 22);
            this.eingabe2.TabIndex = 14;
            this.eingabe2.TextChanged += new System.EventHandler(this.eingabe2_TextChanged);
            // 
            // eingabe1
            // 
            this.eingabe1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.eingabe1.Location = new System.Drawing.Point(60, 391);
            this.eingabe1.Name = "eingabe1";
            this.eingabe1.Size = new System.Drawing.Size(60, 22);
            this.eingabe1.TabIndex = 13;
            this.eingabe1.TextChanged += new System.EventHandler(this.eingabe1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(678, 453);
            this.Controls.Add(this.eingabe5);
            this.Controls.Add(this.eingabe6);
            this.Controls.Add(this.eingabe4);
            this.Controls.Add(this.eingabe3);
            this.Controls.Add(this.eingabe2);
            this.Controls.Add(this.eingabe1);
            this.Controls.Add(this.zahl5);
            this.Controls.Add(this.zahl6);
            this.Controls.Add(this.zahl4);
            this.Controls.Add(this.zahl3);
            this.Controls.Add(this.zahl2);
            this.Controls.Add(this.zahl1);
            this.Controls.Add(this.auslosen);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button auslosen;
        private System.Windows.Forms.TextBox zahl1;
        private System.Windows.Forms.TextBox zahl2;
        private System.Windows.Forms.TextBox zahl3;
        private System.Windows.Forms.TextBox zahl4;
        private System.Windows.Forms.TextBox zahl6;
        private System.Windows.Forms.TextBox zahl5;
        private System.Windows.Forms.TextBox eingabe5;
        private System.Windows.Forms.TextBox eingabe6;
        private System.Windows.Forms.TextBox eingabe4;
        private System.Windows.Forms.TextBox eingabe3;
        private System.Windows.Forms.TextBox eingabe2;
        private System.Windows.Forms.TextBox eingabe1;
    }
}

