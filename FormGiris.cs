using System.Data.SqlClient;

namespace KütüphaneYönetimSistemi
{
    public partial class FormGiris : Form
    {

         FormKitaplar formKitaplar;

        public FormGiris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DbKutuphane;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            string sifre = " ";


            try
            {
                baglanti.Open();
                SqlCommand sqlKomut = new SqlCommand("SELECT Sifre FROM TableKutuphaneYonetici WHERE KullaniciAdi = @p1", baglanti);
                sqlKomut.Parameters.AddWithValue("@p1", textBoxKullaniciAdi.Text);
                SqlDataReader sqlDataReader = sqlKomut.ExecuteReader();


                while (sqlDataReader.Read())
                {
                    sifre = sqlDataReader[0].ToString();
                }

                //label3.Text = sifre;    

                if (sifre == textBoxSifre.Text)
                {
                  

                    formKitaplar = new FormKitaplar();
                    this.Hide(); //yeni pencere açılıncca eskisini kapatır anccak çalımayı durdurmaz
                    formKitaplar.Show();
                    
                }
                else
                {
                    MessageBox.Show("Kullanici Adi veya Sifre Hatalı!");
                    textBoxKullaniciAdi.Text = " ";
                    textBoxSifre.Text = " ";
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı Hatası!" + ex.Message);
            }

            finally
            {
                baglanti.Close();
            }
        }
    }
}
