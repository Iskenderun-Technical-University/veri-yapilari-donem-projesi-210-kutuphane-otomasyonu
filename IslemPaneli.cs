using KutuphaneOtomasyonu1.Kayıtlar;
using KutuphaneOtomasyonu1.Kaynak;
using KutuphaneOtomasyonu1.Kullanici;
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
    public partial class IslemPaneli : Form
    {
        public IslemPaneli()
        {
            InitializeComponent();
        }
        KutuphaneOtomasyonEntities db = new KutuphaneOtomasyonEntities();
         private void IslemPaneli_Load(object sender, EventArgs e)
        {
            ekleKullanicibtn.Visible= false;
            guncelleKullanicibtn.Visible = false;
            silKullanicibtn.Visible=false;

            ekleKaynakbtn.Visible = false;
            guncelleKaynakbtn.Visible = false;
            silKaynakbtn.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ekleKullanicibtn.Visible == false)
            {
                ekleKullanicibtn.Visible = true;
                guncelleKullanicibtn.Visible = true;
                silKullanicibtn.Visible = true;
            }
            else
            {
                ekleKullanicibtn.Visible = false;
                guncelleKullanicibtn.Visible = false;
                silKullanicibtn.Visible = false;

            }
            KullaniciListeForm klisteForm = new KullaniciListeForm();
            klisteForm.MdiParent= this;
            klisteForm.Show();

        }

        private void ekleKullanicibtn_Click(object sender, EventArgs e)
        {
            KullaniciEkleForm ekleForm = new KullaniciEkleForm();
            ekleForm.MdiParent= this;
            ekleForm.Show();
        }

        private void silKullanicibtn_Click(object sender, EventArgs e)
        {
            KullaniciSilForm kSil = new KullaniciSilForm();
            kSil.MdiParent= this;
            kSil.Show();
        }

        private void guncelleKullanicibtn_Click(object sender, EventArgs e)
        {
            KullaniciGuncelleForm kGuncel = new KullaniciGuncelleForm();
            kGuncel.MdiParent= this;
            kGuncel.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ekleKaynakbtn.Visible == false)
            {
                ekleKaynakbtn.Visible = true;
                guncelleKaynakbtn.Visible = true;
                silKaynakbtn.Visible = true;
            }
            else
            {
                ekleKaynakbtn.Visible = false;
                guncelleKaynakbtn.Visible = false;
                silKaynakbtn.Visible = false;

            }
             KaynakListeForm kListe=new KaynakListeForm();
            kListe.MdiParent= this;
             kListe.Show();
        }

        private void ekleKaynakbtn_Click(object sender, EventArgs e)
        {
            KaynakEkleForm kEkle = new KaynakEkleForm();
            kEkle.MdiParent= this;
            kEkle.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void kullaniciBilgiPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void silKaynakbtn_Click(object sender, EventArgs e)
        {
            KaynakSilForm ksil = new KaynakSilForm();
            ksil.MdiParent = this;
            ksil.Show();
        }

        private void OduncVer_Click(object sender, EventArgs e)
        {
            OduncForm odunc = new OduncForm();
            odunc.MdiParent = this;
            odunc.Show();
        }
    }
}
