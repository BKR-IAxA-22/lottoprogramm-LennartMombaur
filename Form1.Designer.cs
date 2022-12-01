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
            this.auslosen = new System.Windows.Forms.Button();
            this.zahl1 = new System.Windows.Forms.TextBox();
            this.zahl2 = new System.Windows.Forms.TextBox();
            this.zahl3 = new System.Windows.Forms.TextBox();
            this.zahl4 = new System.Windows.Forms.TextBox();
            this.zahl6 = new System.Windows.Forms.TextBox();
            this.zahl5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // auslosen
            // 
            this.auslosen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
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
            this.zahl1.Location = new System.Drawing.Point(60, 290);
            this.zahl1.Name = "zahl1";
            this.zahl1.ReadOnly = true;
            this.zahl1.Size = new System.Drawing.Size(60, 22);
            this.zahl1.TabIndex = 7;
            this.zahl1.TextChanged += new System.EventHandler(this.zahl1_TextChanged);
            // 
            // zahl2
            // 
            this.zahl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.zahl2.Location = new System.Drawing.Point(160, 290);
            this.zahl2.Name = "zahl2";
            this.zahl2.ReadOnly = true;
            this.zahl2.Size = new System.Drawing.Size(60, 22);
            this.zahl2.TabIndex = 8;
            this.zahl2.TextChanged += new System.EventHandler(this.zahl2_TextChanged);
            // 
            // zahl3
            // 
            this.zahl3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.zahl3.Location = new System.Drawing.Point(260, 290);
            this.zahl3.Name = "zahl3";
            this.zahl3.ReadOnly = true;
            this.zahl3.Size = new System.Drawing.Size(60, 22);
            this.zahl3.TabIndex = 9;
            this.zahl3.TextChanged += new System.EventHandler(this.zahl3_TextChanged);
            // 
            // zahl4
            // 
            this.zahl4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.zahl4.Location = new System.Drawing.Point(360, 290);
            this.zahl4.Name = "zahl4";
            this.zahl4.ReadOnly = true;
            this.zahl4.Size = new System.Drawing.Size(60, 22);
            this.zahl4.TabIndex = 10;
            this.zahl4.TextChanged += new System.EventHandler(this.zahl4_TextChanged);
            // 
            // zahl6
            // 
            this.zahl6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.zahl6.Location = new System.Drawing.Point(560, 290);
            this.zahl6.Name = "zahl6";
            this.zahl6.ReadOnly = true;
            this.zahl6.Size = new System.Drawing.Size(60, 22);
            this.zahl6.TabIndex = 11;
            this.zahl6.TextChanged += new System.EventHandler(this.zahl6_TextChanged);
            // 
            // zahl5
            // 
            this.zahl5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.zahl5.Location = new System.Drawing.Point(460, 290);
            this.zahl5.Name = "zahl5";
            this.zahl5.ReadOnly = true;
            this.zahl5.Size = new System.Drawing.Size(60, 22);
            this.zahl5.TabIndex = 12;
            this.zahl5.TextChanged += new System.EventHandler(this.zahl5_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(692, 453);
            this.Controls.Add(this.zahl5);
            this.Controls.Add(this.zahl6);
            this.Controls.Add(this.zahl4);
            this.Controls.Add(this.zahl3);
            this.Controls.Add(this.zahl2);
            this.Controls.Add(this.zahl1);
            this.Controls.Add(this.auslosen);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
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
    }
}

