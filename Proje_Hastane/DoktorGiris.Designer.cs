namespace Proje_Hastane
{
    partial class DoktorGiris
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
            this.giris = new System.Windows.Forms.Button();
            this.sifre = new System.Windows.Forms.TextBox();
            this.tc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // giris
            // 
            this.giris.Location = new System.Drawing.Point(221, 229);
            this.giris.Name = "giris";
            this.giris.Size = new System.Drawing.Size(170, 50);
            this.giris.TabIndex = 13;
            this.giris.Text = "Giris Yap";
            this.giris.UseVisualStyleBackColor = true;
            // 
            // sifre
            // 
            this.sifre.Location = new System.Drawing.Point(221, 167);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(170, 36);
            this.sifre.TabIndex = 12;
            // 
            // tc
            // 
            this.tc.Location = new System.Drawing.Point(221, 107);
            this.tc.Mask = "00000000000";
            this.tc.Name = "tc";
            this.tc.Size = new System.Drawing.Size(170, 36);
            this.tc.TabIndex = 11;
            this.tc.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sifre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "TC Kimlik NO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(29, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 44);
            this.label1.TabIndex = 7;
            this.label1.Text = "Doktor Giriş Paneli";
            // 
            // DoktorGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(539, 320);
            this.Controls.Add(this.giris);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.tc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DoktorGiris";
            this.Text = "DoktorGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button giris;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.MaskedTextBox tc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}