namespace Proje_Hastane
{
    partial class girisler
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnHastaGirisi = new System.Windows.Forms.Button();
            this.btnDoktorGirisi = new System.Windows.Forms.Button();
            this.btnSekreterGirisi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHastaGirisi
            // 
            this.btnHastaGirisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.btnHastaGirisi.Location = new System.Drawing.Point(23, 95);
            this.btnHastaGirisi.Name = "btnHastaGirisi";
            this.btnHastaGirisi.Size = new System.Drawing.Size(200, 120);
            this.btnHastaGirisi.TabIndex = 0;
            this.btnHastaGirisi.Text = "Hasta";
            this.btnHastaGirisi.UseVisualStyleBackColor = true;
            this.btnHastaGirisi.Click += new System.EventHandler(this.btnHastaGirisi_Click);
            // 
            // btnDoktorGirisi
            // 
            this.btnDoktorGirisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.btnDoktorGirisi.Location = new System.Drawing.Point(298, 95);
            this.btnDoktorGirisi.Name = "btnDoktorGirisi";
            this.btnDoktorGirisi.Size = new System.Drawing.Size(200, 120);
            this.btnDoktorGirisi.TabIndex = 1;
            this.btnDoktorGirisi.Text = "Doktor";
            this.btnDoktorGirisi.UseVisualStyleBackColor = true;
            this.btnDoktorGirisi.Click += new System.EventHandler(this.btnDoktorGirisi_Click);
            // 
            // btnSekreterGirisi
            // 
            this.btnSekreterGirisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.btnSekreterGirisi.Location = new System.Drawing.Point(575, 95);
            this.btnSekreterGirisi.Name = "btnSekreterGirisi";
            this.btnSekreterGirisi.Size = new System.Drawing.Size(200, 120);
            this.btnSekreterGirisi.TabIndex = 2;
            this.btnSekreterGirisi.Text = "Sekreter";
            this.btnSekreterGirisi.UseVisualStyleBackColor = true;
            this.btnSekreterGirisi.Click += new System.EventHandler(this.btnSekreterGirisi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(134, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hastane Yönetim Paneli Giriş";
            // 
            // girisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 242);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSekreterGirisi);
            this.Controls.Add(this.btnDoktorGirisi);
            this.Controls.Add(this.btnHastaGirisi);
            this.Name = "girisler";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHastaGirisi;
        private System.Windows.Forms.Button btnDoktorGirisi;
        private System.Windows.Forms.Button btnSekreterGirisi;
        private System.Windows.Forms.Label label1;
    }
}

