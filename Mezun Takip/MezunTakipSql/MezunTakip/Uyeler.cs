using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MezunTakip
{
    class Uyeler
    {
        SqlConnection con;

        public Uyeler(String conString)
        {

            con = new SqlConnection(conString);
        }
        public int insertData(string uye_tc, string uye_ad, string uye_soyad, DateTime uye_dogumTarihi, int uye_dogumYeri_id, int uye_cinsiyet, int uye_askerlikDurumu, string uye_foto)
        {

            int sonuc = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("insert into UYELER(uye_tc, uye_ad,uye_soyad,uye_dogumTarihi,uye_dogumYeri_id,uye_cinsiyet,uye_askerlikDurumu,uye_foto) values(@uye_tc, @uye_ad, @uye_soyad,@uye_dogumTarihi,@uye_dogumYeri_id,@uye_cinsiyet,@uye_askerlikDurumu,@uye_foto);SELECT SCOPE_IDENTITY()", con);
 
                cmd.Parameters.AddWithValue("@uye_tc", uye_tc);
                cmd.Parameters.AddWithValue("@uye_ad", uye_ad);
                cmd.Parameters.AddWithValue("@uye_soyad", uye_soyad);
                cmd.Parameters.AddWithValue("@uye_dogumTarihi", uye_dogumTarihi);
                cmd.Parameters.AddWithValue("@uye_dogumYeri_id", uye_dogumYeri_id);
                cmd.Parameters.AddWithValue("@uye_cinsiyet", uye_cinsiyet);
                cmd.Parameters.AddWithValue("@uye_askerlikDurumu", uye_askerlikDurumu);
                cmd.Parameters.AddWithValue("@uye_foto", uye_foto);

                con.Open();
                sonuc = cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {

                sonuc = 0;
                con.Close();

            }

            return sonuc;

        }
        public int updateData(int uye_id, string uye_tc, string uye_ad, string uye_soyad, DateTime uye_dogumTarihi, int uye_dogumYeri_id, int uye_cinsiyet, int uye_askerlikDurumu, string uye_foto)
        {
            int durum = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("update UYELER set uye_tc=@uye_tc,uye_ad=@uye_ad,uye_soyad=@uye_soyad,uye_dogumTarihi=@uye_dogumTarihi,uye_dogumYeri_id=@uye_dogumYeri_id,uye_cinsiyet=@uye_cinsiyet,uye_askerlikDurumu=@uye_askerlikDurumu,uye_foto=@uye_foto WHERE uye_id=@uye_id", con);
                cmd.Parameters.AddWithValue("@uye_id", uye_id);
                cmd.Parameters.AddWithValue("@uye_tc", uye_tc);
                cmd.Parameters.AddWithValue("@uye_ad", uye_ad);
                cmd.Parameters.AddWithValue("@uye_soyad", uye_soyad);
                cmd.Parameters.AddWithValue("@uye_dogumTarihi", uye_dogumTarihi);
                cmd.Parameters.AddWithValue("@uye_dogumYeri_id", uye_dogumYeri_id);
                cmd.Parameters.AddWithValue("@uye_cinsiyet", uye_cinsiyet);
                cmd.Parameters.AddWithValue("@uye_askerlikDurumu", uye_askerlikDurumu);
                cmd.Parameters.AddWithValue("@uye_foto", uye_foto);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                durum = 1;

            }
            catch (Exception ex)
            {

                durum = 0;

            }

            return durum;

        }

        public int deleteData(int uye_id)
        {
            int durum = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("delete UYELER  WHERE uye_id=@uye_id", con);
                cmd.Parameters.AddWithValue("@uye_id", uye_id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                durum = 1;

            }
            catch (Exception ex)
            {

                durum = 0;

            }

            return durum;

        }

    }
}
