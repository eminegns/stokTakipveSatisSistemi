using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJE1
{
    public partial class kullaniciAyarlari : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1IHJLCN\\SQLEXPRESS;Initial Catalog=gorselProg;Integrated Security=True");
        SqlDataAdapter adtr;
        SqlCommandBuilder CommandBuilder;
        DataTable dt = new DataTable();
        public kullaniciAyarlari()
        {
            InitializeComponent();
            listele();
        }

        private void bttnKullaniciSilme_Click(object sender, EventArgs e)//Kullanıcı ID'sine göre silme işlemi gerçekleşiyor.
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from kullaniciTablosu where kullanici_id="+txtKullaniciSilme.Text, baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Kullanıcı başarıyla silindi");
                listele();


            }
            catch (Exception ex)
            {
                MessageBox.Show(" KULLANICI DELETE İŞLEMİ sql bağlantısı yok" +ex.ToString());
            }
            finally
            {
                if (baglanti != null)
                {
                    baglanti.Close();
                }
            }
        }
        void listele()//Burada SQL deki kullanıcı tablosundan veri çekip dataGridView' a yüklüyorum.
        {
            dt.Clear();
            adtr= new SqlDataAdapter("select * from KullaniciTablosu", baglanti);
            adtr.Fill(dt);
            dgvKullanici.DataSource = dt;
        }

        private void bttnKaydet_Click(object sender, EventArgs e)//DataGridView üzerinde verilere yapılan herhangi bir işlemi(ekle,güncelle,sil) kaydediyor.
        {
            try
            {
                CommandBuilder = new SqlCommandBuilder(adtr);
                adtr.Update(dt);
                MessageBox.Show("Değişiklikler kaydedildi.");
                listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void kullaniciAyarlari_Load(object sender, EventArgs e)
        {

        }

        private void dgvKullanici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvKullanici_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridview'daki herhangi bir hücreye 
            //tıkladığımızda o hücrenin sahip olduğu kullanıcı ID sayısını textbox'a getiriyor.
            txtKullaniciSilme.Text = dgvKullanici.CurrentRow.Cells[0].Value.ToString();

        }
    }
}
