using System;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace KAN_BAĞIŞI.Classes
{
    public class KanBagisiBilgileri
    {
        public string AdSoyad { get; set; }
        public string IletisimBilgileri { get; set; }
        public string HastaneAdi { get; set; }
        public string Mesaj { get; set; }
        public string KanGrubu { get; set; }
        public string Cinsiyet { get; set; }

        public KanBagisiBilgileri(string adSoyad, string iletisimBilgileri, string hastaneAdi, string mesaj, string kanGrubu, string cinsiyet)
        {
            AdSoyad = adSoyad;
            IletisimBilgileri = iletisimBilgileri;
            HastaneAdi = hastaneAdi;
            Mesaj = mesaj;
            KanGrubu = kanGrubu;
            Cinsiyet = cinsiyet;
        }

        public void VeritabaninaKaydet()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-BLTT0DI;Initial Catalog=KanBağışı;Integrated Security=True;Trust Server Certificate=True"))
                {
                    connection.Open();
                    string query = "INSERT INTO KanBagisiTablosu (AdSoyad, IletisimBilgileri, HastaneAdi, Mesaj, KanGrubu, Cinsiyet) VALUES (@AdSoyad, @IletisimBilgileri, @HastaneAdi, @Mesaj, @KanGrubu, @Cinsiyet)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@AdSoyad", AdSoyad);
                    command.Parameters.AddWithValue("@IletisimBilgileri", IletisimBilgileri);
                    command.Parameters.AddWithValue("@HastaneAdi", HastaneAdi);
                    command.Parameters.AddWithValue("@Mesaj", Mesaj);
                    command.Parameters.AddWithValue("@KanGrubu", KanGrubu);
                    command.Parameters.AddWithValue("@Cinsiyet", Cinsiyet);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda burada işlem yapabilirsiniz
                Console.WriteLine("Hata: " + ex.Message);
            }
        }
    }
}
