namespace Proje_Hastane
{
    partial class DoktorPaneli
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ad = new System.Windows.Forms.TextBox();
            this.soyad = new System.Windows.Forms.TextBox();
            this.brans = new System.Windows.Forms.ComboBox();
            this.tc = new System.Windows.Forms.MaskedTextBox();
            this.sifre = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Brans :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "TC :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sifre :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(220, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 36);
            this.button2.TabIndex = 6;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(133, 323);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 36);
            this.button3.TabIndex = 7;
            this.button3.Text = "Guncelle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ad
            // 
            this.ad.Location = new System.Drawing.Point(133, 51);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(168, 32);
            this.ad.TabIndex = 8;
            // 
            // soyad
            // 
            this.soyad.Location = new System.Drawing.Point(133, 97);
            this.soyad.Name = "soyad";
            this.soyad.Size = new System.Drawing.Size(168, 32);
            this.soyad.TabIndex = 9;
            // 
            // brans
            // 
            this.brans.FormattingEnabled = true;
            this.brans.Location = new System.Drawing.Point(133, 148);
            this.brans.Name = "brans";
            this.brans.Size = new System.Drawing.Size(168, 33);
            this.brans.TabIndex = 10;
            // 
            // tc
            // 
            this.tc.Location = new System.Drawing.Point(133, 195);
            this.tc.Mask = "00000000000";
            this.tc.Name = "tc";
            this.tc.Size = new System.Drawing.Size(168, 32);
            this.tc.TabIndex = 11;
            this.tc.ValidatingType = typeof(int);
            // 
            // sifre
            // 
            this.sifre.Location = new System.Drawing.Point(133, 233);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(168, 32);
            this.sifre.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(327, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(449, 305);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // DoktorPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 398);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.tc);
            this.Controls.Add(this.brans);
            this.Controls.Add(this.soyad);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DoktorPaneli";
            this.Text = "DoktorPaneli";
            this.Load += new System.EventHandler(this.DoktorPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox ad;
        private System.Windows.Forms.TextBox soyad;
        private System.Windows.Forms.ComboBox brans;
        private System.Windows.Forms.MaskedTextBox tc;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}