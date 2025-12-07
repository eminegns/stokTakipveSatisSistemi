using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PROJE1
{
    public partial class urunEkle : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1IHJLCN\\SQLEXPRESS;Initial Catalog=gorselProg;Integrated Security=True");

        public urunEkle()
        {
            InitializeComponent();
        }
        public string resimYolu = "";
        private void bttnFotoSecme_Click(object sender, EventArgs e)//ürünün fotoğrafını yüklemek için bastığı tuş
        {
            OpenFileDialog ofd = new OpenFileDialog();//bilgisayardan bir dosya seçmek için ekranını açar
            ofd.Title="resim seçme ekranı";
            ofd.Filter="PNG |*.png | JPG | *.jpg| JPEG | *.jpeg |All Files |*.* ";// filtrelerle sadece belirli dosya türlerini açtırır.
            ofd.FilterIndex=2;
            if (ofd.ShowDialog() == DialogResult.OK)// dosya seçme yeri açıldığında kullanan kişi dosyayı seçtiyse bu if e girer.
            {
                pictureUrunEkleme.Image=new Bitmap(ofd.FileName);
                resimYolu=ofd.FileName.ToString();
            }
        }

        private void bttnUrunYukleme_Click(object sender, EventArgs e)
        {
                if (string.IsNullOrWhiteSpace(txtUrunrengi.Text) || //Ürün yüklerken textboxlardan birisi bile...
                string.IsNullOrWhiteSpace(txtUrunKat.Text) ||      // boş bırakılırsa veritabanına eklemesin...
                string.IsNullOrWhiteSpace(txtUrunMarka.Text) ||   // ve uyarı mesajı versin diye kontrol döngüsü koydum.
                string.IsNullOrWhiteSpace(txtUrunFiyat.Text) ||
                string.IsNullOrWhiteSpace(txtUrunStok.Text) ||
                string.IsNullOrWhiteSpace(resimYolu))
            {
                MessageBox.Show("Lütfen tüm alanları eksiksiz doldurunuz!");
                return;
            }

            try
            {
                baglanti.Open();
                string sqlcumlesi = "insert into urunlerTablosu values ('"+txtUrunrengi.Text+"','" +
                                                                            txtUrunKat.Text+"','" +
                                                                            txtUrunMarka.Text+"','" +
                                                                            txtUrunFiyat.Text+"','" +
                                                                            txtUrunStok.Text+"','" +
                                                                             resimYolu+"')";
                SqlCommand komut = new SqlCommand(sqlcumlesi, baglanti);
                komut.ExecuteNonQuery();
                txtUrunrengi.Clear();// ürünler yüklendikten sonra tüm textbox lar boş olsun diye clear kullandım.
                txtUrunFiyat.Clear();
                txtUrunStok.Clear();
                txtUrunKat.Clear();
                txtUrunMarka.Clear();
                pictureUrunEkleme.Image = null;


                MessageBox.Show("Ürün girişleri alınmıştır.");
            }

            catch (Exception  ex)
            {
                MessageBox.Show("ÜRÜN INSERT İŞLEMİ sql bağlantısı yok" +ex.ToString());
            }
            finally
            {
                if (baglanti != null)
                {
                    baglanti.Close();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          

        }
    }
}
