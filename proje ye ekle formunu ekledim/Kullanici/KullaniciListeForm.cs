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
    public partial class KullaniciListeForm : Form
    {
        public KullaniciListeForm()
        {
            InitializeComponent();
        }

         public void Listele()
        {
            KutuphaneOtomasyonEntities2 db = new KutuphaneOtomasyonEntities2();
            var kullanicilar = db.Kullanicilar.ToList();
            dataGridView1.DataSource = kullanicilar.ToList();
        }

        private void KullaniciListeForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
