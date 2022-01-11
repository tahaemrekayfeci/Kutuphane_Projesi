namespace Kutuphane_Projesi
{
    partial class nobetciogrenci
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
            this.btn_kitapara = new System.Windows.Forms.Button();
            this.lbx_kitap = new System.Windows.Forms.ListBox();
            this.lbx_ogrenci = new System.Windows.Forms.ListBox();
            this.btn_ogrenciara = new System.Windows.Forms.Button();
            this.btn_oduncver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_kitapara
            // 
            this.btn_kitapara.Location = new System.Drawing.Point(138, 12);
            this.btn_kitapara.Name = "btn_kitapara";
            this.btn_kitapara.Size = new System.Drawing.Size(75, 23);
            this.btn_kitapara.TabIndex = 0;
            this.btn_kitapara.Text = "Kitap Ara";
            this.btn_kitapara.UseVisualStyleBackColor = true;
            this.btn_kitapara.Click += new System.EventHandler(this.btn_kitapara_Click);
            // 
            // lbx_kitap
            // 
            this.lbx_kitap.FormattingEnabled = true;
            this.lbx_kitap.Location = new System.Drawing.Point(12, 12);
            this.lbx_kitap.Name = "lbx_kitap";
            this.lbx_kitap.Size = new System.Drawing.Size(120, 121);
            this.lbx_kitap.TabIndex = 1;
            // 
            // lbx_ogrenci
            // 
            this.lbx_ogrenci.FormattingEnabled = true;
            this.lbx_ogrenci.Location = new System.Drawing.Point(219, 12);
            this.lbx_ogrenci.Name = "lbx_ogrenci";
            this.lbx_ogrenci.Size = new System.Drawing.Size(120, 121);
            this.lbx_ogrenci.TabIndex = 2;
            // 
            // btn_ogrenciara
            // 
            this.btn_ogrenciara.Location = new System.Drawing.Point(138, 52);
            this.btn_ogrenciara.Name = "btn_ogrenciara";
            this.btn_ogrenciara.Size = new System.Drawing.Size(75, 23);
            this.btn_ogrenciara.TabIndex = 3;
            this.btn_ogrenciara.Text = "Öğrenci Ara";
            this.btn_ogrenciara.UseVisualStyleBackColor = true;
            // 
            // btn_oduncver
            // 
            this.btn_oduncver.Location = new System.Drawing.Point(138, 95);
            this.btn_oduncver.Name = "btn_oduncver";
            this.btn_oduncver.Size = new System.Drawing.Size(75, 23);
            this.btn_oduncver.TabIndex = 4;
            this.btn_oduncver.Text = "Ödünç Ver";
            this.btn_oduncver.UseVisualStyleBackColor = true;
            // 
            // nobetciogrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_oduncver);
            this.Controls.Add(this.btn_ogrenciara);
            this.Controls.Add(this.lbx_ogrenci);
            this.Controls.Add(this.lbx_kitap);
            this.Controls.Add(this.btn_kitapara);
            this.Name = "nobetciogrenci";
            this.Text = "nobetciogrenci";
            this.Load += new System.EventHandler(this.nobetciogrenci_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_kitapara;
        private System.Windows.Forms.ListBox lbx_kitap;
        private System.Windows.Forms.ListBox lbx_ogrenci;
        private System.Windows.Forms.Button btn_ogrenciara;
        private System.Windows.Forms.Button btn_oduncver;
    }
}