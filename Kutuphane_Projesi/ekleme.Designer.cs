namespace Kutuphane_Projesi
{
    partial class ekleme
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
            this.lbx_kitaplar = new System.Windows.Forms.ListBox();
            this.txt_kitapekle = new System.Windows.Forms.TextBox();
            this.btn_kitapekle = new System.Windows.Forms.Button();
            this.lbx_ogrenciler = new System.Windows.Forms.ListBox();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_no = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.btn_ogrenciekle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbx_kitaplar
            // 
            this.lbx_kitaplar.FormattingEnabled = true;
            this.lbx_kitaplar.Location = new System.Drawing.Point(12, 12);
            this.lbx_kitaplar.Name = "lbx_kitaplar";
            this.lbx_kitaplar.Size = new System.Drawing.Size(120, 95);
            this.lbx_kitaplar.TabIndex = 0;
            this.lbx_kitaplar.SelectedIndexChanged += new System.EventHandler(this.lbx_kitaplar_SelectedIndexChanged);
            // 
            // txt_kitapekle
            // 
            this.txt_kitapekle.Location = new System.Drawing.Point(138, 12);
            this.txt_kitapekle.Name = "txt_kitapekle";
            this.txt_kitapekle.Size = new System.Drawing.Size(160, 20);
            this.txt_kitapekle.TabIndex = 1;
            // 
            // btn_kitapekle
            // 
            this.btn_kitapekle.Location = new System.Drawing.Point(138, 38);
            this.btn_kitapekle.Name = "btn_kitapekle";
            this.btn_kitapekle.Size = new System.Drawing.Size(75, 23);
            this.btn_kitapekle.TabIndex = 2;
            this.btn_kitapekle.Text = "Kitap Ekle";
            this.btn_kitapekle.UseVisualStyleBackColor = true;
            // 
            // lbx_ogrenciler
            // 
            this.lbx_ogrenciler.FormattingEnabled = true;
            this.lbx_ogrenciler.Location = new System.Drawing.Point(12, 168);
            this.lbx_ogrenciler.Name = "lbx_ogrenciler";
            this.lbx_ogrenciler.Size = new System.Drawing.Size(120, 95);
            this.lbx_ogrenciler.TabIndex = 3;
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(192, 168);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(106, 20);
            this.txt_ad.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Soyad :";
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(192, 207);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(106, 20);
            this.txt_soyad.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "NO :";
            // 
            // txt_no
            // 
            this.txt_no.Location = new System.Drawing.Point(368, 207);
            this.txt_no.Name = "txt_no";
            this.txt_no.Size = new System.Drawing.Size(106, 20);
            this.txt_no.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(314, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Sınıf :";
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(368, 168);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(106, 20);
            this.txt_sifre.TabIndex = 10;
            // 
            // btn_ogrenciekle
            // 
            this.btn_ogrenciekle.Location = new System.Drawing.Point(277, 240);
            this.btn_ogrenciekle.Name = "btn_ogrenciekle";
            this.btn_ogrenciekle.Size = new System.Drawing.Size(91, 23);
            this.btn_ogrenciekle.TabIndex = 12;
            this.btn_ogrenciekle.Text = "Öğrenci Ekle";
            this.btn_ogrenciekle.UseVisualStyleBackColor = true;
            // 
            // ekleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_ogrenciekle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_no);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.lbx_ogrenciler);
            this.Controls.Add(this.btn_kitapekle);
            this.Controls.Add(this.txt_kitapekle);
            this.Controls.Add(this.lbx_kitaplar);
            this.Name = "ekleme";
            this.Text = "Ekleme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbx_kitaplar;
        private System.Windows.Forms.TextBox txt_kitapekle;
        private System.Windows.Forms.Button btn_kitapekle;
        private System.Windows.Forms.ListBox lbx_ogrenciler;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_no;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Button btn_ogrenciekle;
    }
}