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
    public partial class urunSil : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1IHJLCN\\SQLEXPRESS;Initial Catalog=gorselProg;Integrated Security=True");

        public urunSil()
        {
            InitializeComponent();
        }

       

        private void bttnUrunSil_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from urunlerTablosu where urun_id="+txtUrunSilme.Text, baglanti);
                //ürünün ID sine göre ürünü silen kod.
                komut.ExecuteNonQuery();
                MessageBox.Show("Ürün başarıyla silindi");

                this.urunlerTablosuTableAdapter.Fill(this.gorselProgDataSet3.urunlerTablosu);


            }
            catch (Exception ex)
            {
                MessageBox.Show("DELETE İŞLEMİ sql bağlantısı yok" +ex.ToString());
            }
            finally
            {
                if (baglanti != null)
                {
                    baglanti.Close();
                }
            }

        }

        private void urunSil_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'gorselProgDataSet3.urunlerTablosu' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.urunlerTablosuTableAdapter.Fill(this.gorselProgDataSet3.urunlerTablosu);

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtUrunSilme.Text = dgvUrunSil.CurrentRow.Cells[0].Value.ToString();// DataGridView den seçtiğimiz herhangi bir hücrenin idsini..
            //.. txtUrunSilme adlı textbox a gönderiri.     
        }
    }
}
