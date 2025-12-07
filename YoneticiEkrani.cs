using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJE1
{
    public partial class YoneticiEkrani : Form
    {
        public YoneticiEkrani()
        {
            InitializeComponent();
        }

        private void bttnUrunEkle_Click(object sender, EventArgs e) { //yönetici ürün eklemek isterse bu tuşa basıp ürün ekleme formunu açar.
            urunEkle urunEkle = new urunEkle();
            urunEkle.ShowDialog();
        }

        private void bttnUrunSilme_Click(object sender, EventArgs e) //yönetici ürün silmek isterse bu tuşa basıp ürün silme formunu açar.
        {
            urunSil urunsil = new urunSil();
            urunsil.ShowDialog();
        }

        private void bttnUrunDuzenleme_Click(object sender, EventArgs e) //yönetici ürün düzenlemek isterse bu tuşa basıp ürün düzenleme formunu açar.
        {
            urunDuzenle urunDuzenle = new urunDuzenle();
            urunDuzenle.ShowDialog();
        }

        private void bttnKullaniciListesi_Click(object sender, EventArgs e) //yönetici kullanıcı listesini görmek isterse bu tuşa basıp kullanıcı listesi formunu açar.
        {
            KullaniciListesi kullaniciListesi = new KullaniciListesi();
            kullaniciListesi.ShowDialog(); ; 
        }

        private void bttnKullaniciAyarlari_Click(object sender, EventArgs e) //yönetici kullanıcı listesinde düzenleme yapmak isterse bu tuşa basıp kullanıcı ayarları formunu açar.
        {
            kullaniciAyarlari kullaniciAyarlari = new kullaniciAyarlari();
            kullaniciAyarlari.ShowDialog();
        }

        private void YoneticiEkrani_Load(object sender, EventArgs e)
        {

        }

        private void bttnGeriDön_Click(object sender, EventArgs e)//yöneticiden form1 e geri dönmesi için buton
        {
            Form form1 = Application.OpenForms["Form1"];
            form1.Show(); // Form1 i tekrar gösterir.
            this.Close();
        }
    }
}
