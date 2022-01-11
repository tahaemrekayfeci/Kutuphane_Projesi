using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane_Projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        kullanicibilgileri kullanicibilgi = new kullanicibilgileri();
        yetkili yetkilisayfa = new yetkili();
        nobetciogrencisayfa ogrenci = new nobetciogrencisayfa();
        private void btn_giris_Click(object sender, EventArgs e)
        {
            kullanicibilgi.sifre = txt_sifre.Text;
            kullanicibilgi.ad = txt_kullaniciadi.Text;
            if (kullanicibilgi.ad == "Nöbetçi Öğrenci")
            {
                if (kullanicibilgi.sifre == "0")
                {
                    ogrenci.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı Giriş (Lütfen Yetkilinizden Şifrenizi Alıınız) !");
                    txt_sifre.Text = "";
                    txt_kullaniciadi.Text = "";
                }
            }
            else if (kullanicibilgi.ad == "Yetkili")
            {
                if (kullanicibilgi.sifre == "0123")
                {
                    yetkilisayfa.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı Giriş!");
                    txt_sifre.Text = "";
                    txt_kullaniciadi.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Hatalı Giriş!");
                txt_sifre.Text = "";
                txt_kullaniciadi.Text = "";
            }

        }
    }
}
