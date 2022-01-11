namespace Kutuphane_Projesi
{
    partial class nobetciogrencisayfa
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
            this.btn_ekleme = new System.Windows.Forms.Button();
            this.btn_odunc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ekleme
            // 
            this.btn_ekleme.Location = new System.Drawing.Point(12, 12);
            this.btn_ekleme.Name = "btn_ekleme";
            this.btn_ekleme.Size = new System.Drawing.Size(130, 27);
            this.btn_ekleme.TabIndex = 0;
            this.btn_ekleme.Text = "Kitap - Öğrenci Ekleme";
            this.btn_ekleme.UseVisualStyleBackColor = true;
            this.btn_ekleme.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_odunc
            // 
            this.btn_odunc.Location = new System.Drawing.Point(12, 59);
            this.btn_odunc.Name = "btn_odunc";
            this.btn_odunc.Size = new System.Drawing.Size(130, 27);
            this.btn_odunc.TabIndex = 1;
            this.btn_odunc.Text = "Ödünç Verme";
            this.btn_odunc.UseVisualStyleBackColor = true;
            this.btn_odunc.Click += new System.EventHandler(this.btn_odunc_Click);
            // 
            // nobetciogrencisayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_odunc);
            this.Controls.Add(this.btn_ekleme);
            this.Name = "nobetciogrencisayfa";
            this.Text = "nobetciogrencisayfa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ekleme;
        private System.Windows.Forms.Button btn_odunc;
    }
}