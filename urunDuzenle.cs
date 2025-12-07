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
    public partial class urunDuzenle : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1IHJLCN\\SQLEXPRESS;Initial Catalog=gorselProg;Integrated Security=True");
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        public urunDuzenle()
        {
            InitializeComponent();
        }
        void urunGetir()//mssql de bulunan urunler tablosunu datagridview e aktarır.
        {
            baglanti.Open();
            dataAdapter=new SqlDataAdapter("select * from urunlerTablosu", baglanti);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dgvUrunDuzenleme.DataSource = dataTable;
            baglanti.Close();




        }

        private void bttnUrunDuzen_Click(object sender, EventArgs e)
        {

            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update urunlerTablosu set "+
                    "renk= '"+txtUrunDuzenRengi.Text+"', kategori='"+txtUrunDuzenKat.Text+
                    "', marka= '"+txtUrunDuzenMarka.Text+"', fiyat='"+txtUrunDuzenFiyat.Text+
                    "', stok='"+txtUrunDuzenStok.Text+"', resim='"+resimYolu+"' where urun_id= "+
                    txtUrunIdDuzen.Text, baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close() ;
                urunGetir();
                MessageBox.Show("Ürün başarıyla güncellendi");

               
                txtUrunDuzenRengi.Clear();
                txtUrunDuzenKat.Clear();
                txtUrunDuzenMarka.Clear();
                txtUrunDuzenFiyat.Clear();
                txtUrunDuzenStok.Clear();
                //ürünler güncellendikten sonra textboxlar temizlensin.



            }
            catch (Exception ex)
            {
                MessageBox.Show("UPDATE İŞLEMİ sql bağlantısı yok" +ex.ToString());
            }
            finally
            {
                if (baglanti != null)
                {
                    baglanti.Close();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public string resimYolu = "";
        private void bttnFotoDuzenSecme_Click(object sender, EventArgs e)//ürünün fotoğrafı da düzenlenebilsin diye ayrı bir alan açtım...
            //burada yine ürün eklemedeki gibi bilgisayardaki dosyaları açsın dite openfiledialog eklendi.
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title="resim seçme ekranı";
            ofd.Filter="PNG |*.png | JPG-JPEG | *.jpg;*.jpeg |All Files |*.* ";
            ofd.FilterIndex=2;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureUrunDuzen.Image=new Bitmap(ofd.FileName);
                resimYolu=ofd.FileName.ToString();
            }
        }

        private void urunDuzenle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'gorselProgDataSet5.urunlerTablosu' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
           // this.urunlerTablosuTableAdapter.Fill(this.gorselProgDataSet5.urunlerTablosu);
            urunGetir();

        }

        private void dgvUrunDuzenleme_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtUrunIdDuzen.Text = dgvUrunDuzenleme.CurrentRow.Cells[0].Value.ToString();
            txtUrunDuzenRengi.Text = dgvUrunDuzenleme.CurrentRow.Cells[1].Value.ToString();
            txtUrunDuzenKat.Text = dgvUrunDuzenleme.CurrentRow.Cells[2].Value.ToString();
            txtUrunDuzenMarka.Text = dgvUrunDuzenleme.CurrentRow.Cells[3].Value.ToString();
            txtUrunDuzenFiyat.Text = dgvUrunDuzenleme.CurrentRow.Cells[4].Value.ToString();
            txtUrunDuzenStok.Text = dgvUrunDuzenleme.CurrentRow.Cells[5].Value.ToString();
            pictureUrunDuzen.ImageLocation = dgvUrunDuzenleme.CurrentRow.Cells[6].Value.ToString();

            //datagridview da seçilen ürünnün özelliklerini textbox a atayan kodlar.

        }
    }
}   
