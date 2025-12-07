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
    public partial class kullaniciEkrani : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1IHJLCN\\SQLEXPRESS;Initial Catalog=gorselProg;Integrated Security=True");

        public kullaniciEkrani()
        {
            InitializeComponent();
        }
        decimal toplamFiyat = 0;
        private void bttnSepeteYukle_Click(object sender, EventArgs e)
        {
            if (dgvUrunTablo.SelectedRows.Count > 0)// kullanıcı ürün seçti mi? seçtiyse bu if e giriyor.
            {
              
                int rowIndex = dgvUrunTablo.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvUrunTablo.Rows[rowIndex];

                int urun_id = Convert.ToInt32(selectedRow.Cells[0].Value); 
                string renk = selectedRow.Cells[1].Value.ToString();      
                string kategori = selectedRow.Cells[2].Value.ToString();  
                string marka = selectedRow.Cells[3].Value.ToString();    
                decimal fiyat = Convert.ToDecimal(selectedRow.Cells[4].Value); 
                int stok = Convert.ToInt32(selectedRow.Cells[5].Value);    

                // Daha önce bu üründen sepete eklenmişse miktarı arttırıyor.
                string[] richTextLines = richTextBox1.Lines;
                int mevcutSepetMiktar = 0;

                foreach (string line in richTextLines)
                {
                    if (line.Contains($"Ürün ID: {urun_id}"))
                    {
                        string miktarSatiri = richTextLines[Array.IndexOf(richTextLines, line) + 5];
                        mevcutSepetMiktar = int.Parse(miktarSatiri.Split(':')[1].Trim());
                        break;
                    }
                }

                if (mevcutSepetMiktar + 1 > stok)//stok kontrolünü yapıyor. yeterince yoksa bu mesaj çıkıyor.
                {
                    MessageBox.Show($"Bu üründen stokta yeterli miktar yok! Mevcut stok: {stok}, Sepette: {mevcutSepetMiktar}");
                    return;
                }

                // Toplam fiyatı güncelliyor.
                toplamFiyat += fiyat;

                // Eğer ürün zaten sepette varsa sadece miktarı güncelliyor.
                if (mevcutSepetMiktar > 0)
                {
                    for (int i = 0; i < richTextLines.Length; i++)
                    {
                        if (richTextLines[i].Contains($"Ürün ID: {urun_id}"))
                        {
                            int yeniMiktar = mevcutSepetMiktar + 1;
                            decimal toplamUrunFiyati = fiyat * yeniMiktar;
                            richTextLines[i + 5] = $"Miktar: {yeniMiktar}";
                            break;
                        }
                    }
                    richTextBox1.Lines = richTextLines;
                }
                else
                {
                    // sepete ürün yükleniyorsa bunu richtextbox a yazdırıyor.
                    richTextBox1.AppendText($"Ürün ID: {urun_id}\n");
                    richTextBox1.AppendText($"Renk: {renk}\n");
                    richTextBox1.AppendText($"Kategori: {kategori}\n");
                    richTextBox1.AppendText($"Marka: {marka}\n");
                    richTextBox1.AppendText($"Fiyat (Birim): {fiyat}\n");
                    richTextBox1.AppendText($"Miktar: 1\n");
                    richTextBox1.AppendText("----------------------------\n");
                }

                // Toplam fiyatı textbox a yazdırıyor.
               txtToplamTutar.Text = toplamFiyat.ToString();
            }
            else// kullanıcı ürün seçti mi? seçmediyse bu mesaj çıkıyor.
            {
                MessageBox.Show("Lütfen bir ürün seçin!");
            }
        }


        private void kullaniciEkrani_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'gorselProgDataSet1.urunlerTablosu' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.urunlerTablosuTableAdapter.Fill(this.gorselProgDataSet1.urunlerTablosu);

        }

        

        private void dgvUrunTablo_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int secilen = dgvUrunTablo.SelectedCells[0].RowIndex;
            pictureBox1.ImageLocation=dgvUrunTablo.Rows[secilen].Cells[6].Value.ToString();
            if (e.RowIndex >= 0) 
            {
                dgvUrunTablo.Rows[e.RowIndex].Selected = true; 
            }
        }

        private void bttnSepetiSil_Click(object sender, EventArgs e)//kullanıcı sepeti almak istemezse bu tuşa basıp richtextbox ı temizliyor.
        {
            richTextBox1.Clear();
            txtToplamTutar.Clear();
        }

        private void bttnSepetiSatinAl_Click(object sender, EventArgs e)
        {
           
                if (richTextBox1.Lines.Length == 0)//sepet yani richtextbox boş ise bu mesajı gösteriyor.
                {
                    MessageBox.Show("Sepet boş! Önce ürün ekleyin.");
                    return;
                }

                try
                {
                    baglanti.Open();

                    string[] richTextLines = richTextBox1.Lines;
                    int urun_id = 0;
                    int miktar = 0;

                    for (int i = 0; i < richTextLines.Length; i++)
                    {
                        if (richTextLines[i].StartsWith("Ürün ID:"))
                        {
                            
                            urun_id = int.Parse(richTextLines[i].Split(':')[1].Trim());
                        }
                        else if (richTextLines[i].StartsWith("Miktar:"))
                        {
                            
                            miktar = int.Parse(richTextLines[i].Split(':')[1].Trim());

                            // sql ile stok güncelliyor
                            string updateStokQuery = "UPDATE urunlerTablosu SET stok = stok - @miktar WHERE urun_id = @urun_id";
                            SqlCommand updateCommand = new SqlCommand(updateStokQuery, baglanti);
                            updateCommand.Parameters.AddWithValue("@miktar", miktar);
                            updateCommand.Parameters.AddWithValue("@urun_id", urun_id);

                            
                            updateCommand.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Satın alma işlemi başarıyla gerçekleşti!");

                    // satın alındıktan sonra sepeti temizliyor.
                    richTextBox1.Clear();
                    txtToplamTutar.Clear();

                   
                    this.urunlerTablosuTableAdapter.Fill(this.gorselProgDataSet1.urunlerTablosu);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
            


        }

        private void bttnGeriDön2_Click(object sender, EventArgs e)// Form1 e geri git tuşu
        {

            Form form1 = Application.OpenForms["Form1"];
            form1.Show(); 
            this.Close();
        }

      
    }
}
