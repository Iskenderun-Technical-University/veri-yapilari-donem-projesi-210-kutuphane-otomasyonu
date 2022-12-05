using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void personelGirisbtn_Click(object sender, EventArgs e)
        {
            string gelenAd = adGiristxt.Text;
            string gelenSifre = sifreGiristxt.Text;

            if(gelenAd.Equals("admin") && gelenSifre.Equals("2412"))
            {
                MessageBox.Show(text: "Başarılı bir şekilde giriş yaptınız.");
            }
            else
            {
                MessageBox.Show(text: "Kullanıcı adı veya şifre hatalı.");
            }
        }
    }
}
