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
    public partial class Form1 : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1IHJLCN\\SQLEXPRESS;Initial Catalog=gorselProg;Integrated Security=True");
      // sql server bağlantısı gerçekleşiyor.
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bttnKayitOlusturma_Click(object sender, EventArgs e)
        {
            kayitAlma kayitAlma = new kayitAlma();
            kayitAlma.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bttnYoneticiGiris_Click(object sender, EventArgs e)
        {
            
            try
            {
                baglanti.Open(); // sql bağlantısını açıyorum.
                string girilenİsim = txtYoneticiİsim.Text;// yöneticiismi alınıyor.
                string girilenSifre = txtYoneticiSİFRE.Text;// şifre alınıyor.

                string query = "SELECT COUNT(*) FROM yoneticiTablo WHERE sifre = @sifre and isim=@isim";
                SqlCommand komut1 = new SqlCommand(query, baglanti);
                // burada giriş yapan kişiden alınınan yönetici ismi ve şifresi sql deki verilerle karşılaştırılıyor.
                komut1.Parameters.AddWithValue("@sifre", girilenSifre);
                komut1.Parameters.AddWithValue("@isim", girilenİsim);
                int count = (int)komut1.ExecuteScalar();// kayıt bulunursa sıfırdan farklı bir değer alıyor.(pozitif)

                if (count > 0)// kayıt bulunursa buraya giriyor.
                {
                    YoneticiEkrani yoneticiEkrani = new YoneticiEkrani();
                    yoneticiEkrani.Show(); // yönetici ekranını aç
                    this.Hide();// form1 i gizle

                    MessageBox.Show("Giriş başarılı!");

                }
                else
                {
                    MessageBox.Show("Giriş hatalı, lütfen tekrar deneyin.");
                }
            }
            catch (Exception ex)// sql bağlantısında hata olduğunda bize hata mesajı versin diye try catch kullandım
            {
                MessageBox.Show("yönetici girişinde sql bağlantısı yok" +ex.ToString());
            }
            finally
            {
                if (baglanti != null)
                {
                    baglanti.Close();// veri açığı olmaması için işimiz bitince sql i kapatıyorum.
                }
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bttnKullaniciGiris_Click(object sender, EventArgs e)
        {
            
            try
            {
                baglanti.Open(); // sql bağlantısını açıyorum.
                string girilenEmail = txtKullaniciEmail.Text;// kullanıcı email giriyor.
                string girilenSifre = txtKullaniciSifre.Text;// şifre giriyor.
                string query = "SELECT COUNT(*) FROM kullaniciTablosu WHERE sifre = @sifre and email=@email";
                SqlCommand komut = new SqlCommand(query, baglanti);
                // kullanıcıtablosundaki değerlerle kontrol ediliyor.
                komut.Parameters.AddWithValue("@sifre", girilenSifre);
                komut.Parameters.AddWithValue("@email", girilenEmail);
                int count = (int)komut.ExecuteScalar();

                if (count > 0)// kayıt varsa
                {
                    kullaniciEkrani kullaniciEkrani = new kullaniciEkrani();
                    kullaniciEkrani.Show();// kullanıcı ekranını aç
                    this.Hide();//form1 i gizle 

                    MessageBox.Show("Giriş başarılı!");

                }
                else
                {
                    MessageBox.Show("Giriş hatalı, lütfen tekrar deneyin.");
                }
            }
            catch (Exception ex)// sql bağlantısında hata olduğunda bize hata mesajı versin diye try catch kullandım
            {
                MessageBox.Show("kullanıcı girişinde sql bağlantısı yok" +ex.ToString());
            }
            finally
            {
                if (baglanti != null)
                {
                    baglanti.Close();// veri açığı olmaması için işimiz bitince sql i kapatıyorum.
                }
            }
        }
    }
}
