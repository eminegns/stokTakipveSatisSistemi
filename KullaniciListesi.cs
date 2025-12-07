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

namespace PROJE1
{
    public partial class KullaniciListesi : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1IHJLCN\\SQLEXPRESS;Initial Catalog=gorselProg;Integrated Security=True");

        public KullaniciListesi()
        {
            InitializeComponent();
        }

        private void bttnKullanıcıGtr_Click(object sender, EventArgs e)// mssqlden kullanıcı tablosunu getiren tablo
        {
            try
            {
                baglanti.Open();
                string tabloGetirme = "SELECT * FROM kullaniciTablosu"; 
                SqlDataAdapter dataAd = new SqlDataAdapter(tabloGetirme, baglanti);
                DataTable dataTable = new DataTable();
                dataAd.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri çekme işlemi sırasında hata oluştu: " + ex.Message);
            }
            finally
            {
                if (baglanti != null)
                {
                    baglanti.Close();
                }
            }

        }

        private void KullaniciListesi_Load(object sender, EventArgs e)
        {
           

        }

        private void bttnTabloTemizle_Click(object sender, EventArgs e)// datagridview içini temizlemek için tuş.
        {
            dataGridView1.DataSource = null;

        }

    }
}
