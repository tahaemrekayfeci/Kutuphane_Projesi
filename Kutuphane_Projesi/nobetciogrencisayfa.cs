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
    public partial class nobetciogrencisayfa : Form
    {
        public nobetciogrencisayfa()
        {
            InitializeComponent();
        }
        ekleme ekleme = new ekleme();
        nobetciogrenci odunc = new nobetciogrenci();
        private void button1_Click(object sender, EventArgs e)
        {
            ekleme.Show();
            this.Hide();
        }

        private void btn_odunc_Click(object sender, EventArgs e)
        {
            odunc.Show();
            this.Hide();
        }
    }
}
