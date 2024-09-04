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

namespace KütüphaneYönetimSistemi
{

    using System.Data.SqlClient;
    using System.Threading;

    public partial class FormKitaplar : Form
    {
        //baglanti yapınca solundaki using system.data.client
        //yap eger gozukmuyorsa kodun basına using System.Data.SqlClient; yaz

        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DbKutuphane;Integrated Security=True");

        public FormKitaplar()
        {
            InitializeComponent();
        }

        private void buttonKitapEkle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                SqlCommand sqlCommand = new SqlCommand("INSERT INTO TableKitaplar (KitapAdi, YazarAdi, YazarSoyadi, ISBN, Durum, KitapTurKodu) VALUES (@P1, @P2, @P3, @P4, @P5, @P6)", baglanti);

                sqlCommand.Parameters.AddWithValue("@P1", textBoxKitapAdi.Text);
                sqlCommand.Parameters.AddWithValue("@P2", textBoxYazarAdi.Text);
                sqlCommand.Parameters.AddWithValue("@P3", textBoxYazarSoyadi.Text);
                sqlCommand.Parameters.AddWithValue("@P4", textBoxISBN.Text);
                sqlCommand.Parameters.AddWithValue("@P5", "True");
                sqlCommand.Parameters.AddWithValue("@P6", textBoxTurKodu.Text);

                sqlCommand.ExecuteNonQuery(); //ınsert, delete, update veya create table,alter table vb ıcın kullan
            }
            catch (Exception ex)
            {
                MessageBox.Show("kitap eklenirken hata oluştu!" + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }

            verileriGoster(); //guncellenmıs verıyı gostersın. Dissplay


        }


        //fonkiyonlarla çöz her şeyi
        private void verileriGoster()
        {
            //sorun çıkarsa anlamak için try catch yap
            try
            {
                baglanti.Open();

                string q = "SELECT * FROM TableKitaplar";
                //datatable ve adapter ıle datagrid bolumu doldurulur
                SqlDataAdapter da = new SqlDataAdapter(q, baglanti);
                DataTable dt = new DataTable(); //aracı. cekılen bılgı burada toplanır
                da.Fill(dt);


                //tabloyu gosterır
                if (dt.Rows.Count > 0)
                {
                    dataGridViewKitaplar.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Kayıt bulunamadı");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("veri çekme hatasi" + ex.Message);
            }

            finally
            {
                baglanti.Close();
            }

        }

        //ilk load çağrılır. fonksiyon unıtesı bura konulur. form designerin herhangi biyerıne çift click
        private void FormKitaplar_Load(object sender, EventArgs e)
        {
            verileriGoster();
        }

        //datagridview içim eylem oluşturduk ççift click için boylece kıtap bılgı guncellenebılecek
        private void dataGridViewKitaplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            labelGecikmeBedeli.Text = "0";

            int secilenSatir = dataGridViewKitaplar.SelectedCells[0].RowIndex;

            labelID.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[0].Value.ToString();
            textBoxKitapAdi.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[1].Value.ToString();
            textBoxYazarAdi.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[2].Value.ToString();
            textBoxYazarSoyadi.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[3].Value.ToString();
            textBoxISBN.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[4].Value.ToString();
            textBoxTurKodu.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[8].Value.ToString();

            textBoxOduncAlan.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[6].Value.ToString();

            if (dataGridViewKitaplar.Rows[secilenSatir].Cells[7].Value != DBNull.Value)
            {
                dateTimePickerOduncAlmaTarihi.Value = (DateTime)dataGridViewKitaplar.Rows[secilenSatir].Cells[7].Value;

            }
        }

        private void buttonKitapBilgiGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                SqlCommand sqlCommand = new SqlCommand("UPDATE TableKitaplar SET KitapAdi = @P1, YazarAdi = @P2, YazarSoyadi = @P3, ISBN = @P4, KitapTurKodu = @P5 WHERE ID = @P6", baglanti);

                sqlCommand.Parameters.AddWithValue("@P1", textBoxKitapAdi.Text);
                sqlCommand.Parameters.AddWithValue("@P2", textBoxYazarAdi.Text);
                sqlCommand.Parameters.AddWithValue("@P3", textBoxYazarSoyadi.Text);
                sqlCommand.Parameters.AddWithValue("@P4", textBoxISBN.Text);
                sqlCommand.Parameters.AddWithValue("@P5", textBoxTurKodu.Text);
                sqlCommand.Parameters.AddWithValue("@P6", labelID.Text);

                // sqlCommand.ExecuteNonQuery(); //ınsert, delete, update veya create table,alter table vb ıcın kullan

                int affectedRows = sqlCommand.ExecuteNonQuery();
                if (affectedRows == 0)
                {
                    MessageBox.Show("Hiçbir kayıt güncellenmedi. Lütfen ID'yi kontrol edin.");
                }
                else
                {
                    MessageBox.Show($"{affectedRows} kayıt güncellendi.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("veri güncelleme hatasi" + ex.Message);
            }

            finally
            {
                baglanti.Close();
            }
            verileriGoster();

        }

        private void buttonOduncVer_Click(object sender, EventArgs e)
        {
            if (labelID.Text != "-")
            {
                try
                {
                    baglanti.Open();

                    SqlCommand sqlCommand = new SqlCommand("UPDATE TableKitaplar SET OduncAlan = @P1, OduncAlmaTarihi = @P2, Durum = @P3 WHERE ID = @P4", baglanti);

                    sqlCommand.Parameters.AddWithValue("@P1", textBoxOduncAlan.Text);
                    sqlCommand.Parameters.AddWithValue("@P3", "False");
                    sqlCommand.Parameters.AddWithValue("@P4", labelID.Text);
                    //datepicker için özel durum
                    sqlCommand.Parameters.Add("@P2", SqlDbType.Date).Value = dateTimePickerOduncAlmaTarihi.Value.Date;

                    int affectedRows = sqlCommand.ExecuteNonQuery();
                    if (affectedRows == 0)
                    {
                        MessageBox.Show("Hiçbir kayıt güncellenmedi. Lütfen ID'yi kontrol edin.");
                    }
                    else
                    {
                        MessageBox.Show($"{affectedRows} kayıt güncellendi.");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ödünç alırken bir hata oldu!" + ex.Message);
                }

                finally
                {
                    baglanti.Close();
                }
                verileriGoster();

            }

            else
            {
                MessageBox.Show("Listeden bir kitap seç!");
            }

        }

        private void buttonGecikmeBedeliHesapla_Click(object sender, EventArgs e)
        {
            if (labelID.Text != "-")
            {
                DateTime bugununTarihi = DateTime.Now;
                int gunFarki = (int)(bugununTarihi - dateTimePickerOduncAlmaTarihi.Value.Date).TotalDays;

                if (gunFarki > 10)
                {
                    int gecikmeBedeli = (gunFarki - 10) * 10;
                    labelGecikmeBedeli.Text = gecikmeBedeli.ToString();
                }
            }
        }

        private void buttonKitabiIadeEt_Click(object sender, EventArgs e)
        {
            if (labelID.Text != "-")
            {
                try
                {
                    baglanti.Open();

                    SqlCommand sqlCommand = new SqlCommand("UPDATE TableKitaplar SET OduncAlan = @P1, OduncAlmaTarihi = @P2, Durum = @P3 WHERE ID = @P4", baglanti);

                    sqlCommand.Parameters.AddWithValue("@P1", " ");
                    sqlCommand.Parameters.AddWithValue("@P3", "False");
                    sqlCommand.Parameters.AddWithValue("@P4", labelID.Text);
                    //datepicker için özel durum
                    sqlCommand.Parameters.Add("@P2", SqlDbType.Date).Value = DBNull.Value;

                    textBoxOduncAlan.Text = " ";

                    int affectedRows = sqlCommand.ExecuteNonQuery();
                    if (affectedRows == 0)
                    {
                        MessageBox.Show("Hiçbir kayıt güncellenmedi. Lütfen ID'yi kontrol edin.");
                    }
                    else
                    {
                        MessageBox.Show($"{affectedRows} kayıt güncellendi.");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("iade verirken bir hata oldu!" + ex.Message);
                }

                finally
                {
                    baglanti.Close();
                }
                verileriGoster();
            }
        }

        public void temizle()
        {
            labelID.Text = "-";
            textBoxKitapAdi.Text = " ";
            textBoxOduncAlan.Text = " ";
            textBoxTurKodu.Text = " ";
            textBoxYazarAdi.Text = " ";
            textBoxYazarSoyadi.Text = " ";
            textBoxISBN.Text = " ";


        }
        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            temizle();
            verileriGoster();

        }

        private void buttonSorgula_Click(object sender, EventArgs e)
        {
            arananiGoster();
        }

        private void arananiGoster()
        {
            //sorun çıkarsa anlamak için try catch yap
            try
            {
                baglanti.Open();

                string q = "SELECT * FROM TableKitaplar WHERE KitapAdi LIKE '" + textBoxKitapAdi + "%' AND YazarSoyadi LIKE '" + textBoxYazarSoyadi + "%' AND YazarAdi LIKE '" + textBoxYazarAdi + "%' " +
                    "AND ISBN LIKE '" + textBoxISBN + "%' AND KitapTurKodu LIKE '" + textBoxTurKodu + "%' AND OduncAlan LIKE '" + textBoxOduncAlan + "%' ";
                //datatable ve adapter ıle datagrid bolumu doldurulur
                SqlDataAdapter da = new SqlDataAdapter(q, baglanti);
                DataTable dt = new DataTable(); //aracı. cekılen bılgı burada toplanır
                da.Fill(dt);

                MessageBox.Show("kayıt sayısı: " + dt.Rows.Count.ToString());


                //tabloyu gosterır
                if (dt.Rows.Count > 0)
                {
                    dataGridViewKitaplar.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Kayıt bulunamadı");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("veri çekme hatasi" + ex.Message);
            }

            finally
            {
                baglanti.Close();
            }

        }

        private void buttonKitabiSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (labelID.Text == "-" || labelID.Text == "")
                {
                    MessageBox.Show("Lütfen kitap seçiniz!");
                }
                else
                {

                    baglanti.Open();

                    SqlCommand sqlCommand = new SqlCommand("DELETE FROM TableKitaplar WHERE ID = @P1", baglanti);
                    sqlCommand.Parameters.AddWithValue("@P1", labelID.Text);

                    int affectedRows = sqlCommand.ExecuteNonQuery();
                    if (affectedRows == 0)
                    {
                        MessageBox.Show("Kitap silinemedi.");
                    }
                    else
                    {
                        MessageBox.Show($"{affectedRows} kayıt silindi.");
                    }

                    temizle();

                    dataGridViewKitaplar.Refresh();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri güncelleme hatası: " + ex.Message);
            }
            finally
            {
                if (baglanti != null)
                {
                    baglanti.Close();
                }

            }
            verileriGoster();

        }

        private void FormKitaplar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
