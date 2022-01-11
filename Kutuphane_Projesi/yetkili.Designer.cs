namespace Kutuphane_Projesi
{
    partial class yetkili
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
            this.lbl_nobetciogrenci = new System.Windows.Forms.Label();
            this.btn_eklemeisinla = new System.Windows.Forms.Button();
            this.btn_odunverisinlama = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_nobetciogrenci
            // 
            this.lbl_nobetciogrenci.AutoSize = true;
            this.lbl_nobetciogrenci.Location = new System.Drawing.Point(12, 9);
            this.lbl_nobetciogrenci.Name = "lbl_nobetciogrenci";
            this.lbl_nobetciogrenci.Size = new System.Drawing.Size(108, 13);
            this.lbl_nobetciogrenci.TabIndex = 0;
            this.lbl_nobetciogrenci.Text = "Nöbetçi Öğrenci Şifre";
            // 
            // btn_eklemeisinla
            // 
            this.btn_eklemeisinla.Location = new System.Drawing.Point(12, 34);
            this.btn_eklemeisinla.Name = "btn_eklemeisinla";
            this.btn_eklemeisinla.Size = new System.Drawing.Size(129, 23);
            this.btn_eklemeisinla.TabIndex = 1;
            this.btn_eklemeisinla.Text = "Kitap - Öğrenci Ekleme";
            this.btn_eklemeisinla.UseVisualStyleBackColor = true;
            // 
            // btn_odunverisinlama
            // 
            this.btn_odunverisinlama.Location = new System.Drawing.Point(12, 74);
            this.btn_odunverisinlama.Name = "btn_odunverisinlama";
            this.btn_odunverisinlama.Size = new System.Drawing.Size(129, 23);
            this.btn_odunverisinlama.TabIndex = 2;
            this.btn_odunverisinlama.Text = "Ödünç Verme";
            this.btn_odunverisinlama.UseVisualStyleBackColor = true;
            // 
            // yetkili
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_odunverisinlama);
            this.Controls.Add(this.btn_eklemeisinla);
            this.Controls.Add(this.lbl_nobetciogrenci);
            this.Name = "yetkili";
            this.Text = "yetkili";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nobetciogrenci;
        private System.Windows.Forms.Button btn_eklemeisinla;
        private System.Windows.Forms.Button btn_odunverisinlama;
    }
}