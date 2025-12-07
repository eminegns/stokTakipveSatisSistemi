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
    public partial class kayitAlma : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1IHJLCN\\SQLEXPRESS;Initial Catalog=gorselProg;Integrated Security=True");

        public kayitAlma()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void bttnKayitAlma_Click(object sender, EventArgs e)
        {
            try
            {
                //kullanıcıdan gerekli bilgiler alınır ve bunlar sql tablosuna gönderilir.
                baglanti.Open();//sql bağlantısını açar.
                string sqlcumlesi = "insert into kullaniciTablosu values ('"+txtKayitİsim.Text+"','" +
                                                                    txtKayitSoyisim.Text+"','" +
                                                                    txtKayitSehir.Text+"','" +
                                                                    txtKayitEmail.Text+"','" +
                                                                    txtKayitSifre.Text+"')";
                SqlCommand komut = new SqlCommand(sqlcumlesi, baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Kullanıcı kayıtı başarıyla alınmıştır");


            }
            catch (Exception ex)//bağlantıda bir hata oluşursa belli olsun diye uyarı mesajı veriyor.
            {
                MessageBox.Show("KULLANICI INSERT İŞLEMİ sql bağlantısı yok" +ex.ToString());
            }
            finally
            {
                if (baglanti != null)
                {
                    baglanti.Close();// sql bağlantısını kapatır.
                }
            }
        }
    }
}
