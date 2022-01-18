using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MezunTakip
{
    class Duyurular
    {
        SqlConnection con;

        public Duyurular(String conString)
        {

            con = new SqlConnection(conString);
        }
        public int insertData(string duyuru_sahibiTc, string duyuru_Basligi, string duyuru_Metin, string duyuru_Resim, DateTime duyuru_yayinTarihi, DateTime duyuru_bitisTarihi)
        {

            int sonuc = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("insert into DUYURULAR(duyuru_sahibiTc, duyuru_Basligi,duyuru_Metin,duyuru_Resim,duyuru_yayinTarihi,duyuru_bitisTarihi) values(@duyuru_sahibiTc, @duyuru_Basligi, @duyuru_Metin,@duyuru_Resim,@duyuru_yayinTarihi,@duyuru_bitisTarihi);SELECT SCOPE_IDENTITY()", con);

                cmd.Parameters.AddWithValue("@duyuru_sahibiTc", duyuru_sahibiTc);
                cmd.Parameters.AddWithValue("@duyuru_Basligi", duyuru_Basligi);
                cmd.Parameters.AddWithValue("@duyuru_Metin", duyuru_Metin);
                cmd.Parameters.AddWithValue("@duyuru_Resim", duyuru_Resim);
                cmd.Parameters.AddWithValue("@duyuru_yayinTarihi", duyuru_yayinTarihi);
                cmd.Parameters.AddWithValue("@duyuru_bitisTarihi", duyuru_bitisTarihi);

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
        public int updateData(int duyuru_id, string duyuru_sahibiTc, string duyuru_Basligi, string duyuru_Metin, string duyuru_Resim, DateTime duyuru_yayinTarihi, DateTime duyuru_bitisTarihi)
        {
            int durum = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("update DUYURULAR set duyuru_sahibiTc=@duyuru_sahibiTc,duyuru_Basligi=@duyuru_Basligi,duyuru_Metin=@duyuru_Metin,duyuru_Resim=@duyuru_Resim,duyuru_yayinTarihi=@duyuru_yayinTarihi,duyuru_bitisTarihi=@duyuru_bitisTarihi WHERE duyuru_id=@duyuru_id", con);
                cmd.Parameters.AddWithValue("@duyuru_id", duyuru_id);
                cmd.Parameters.AddWithValue("@duyuru_sahibiTc", duyuru_sahibiTc);
                cmd.Parameters.AddWithValue("@duyuru_Basligi", duyuru_Basligi);
                cmd.Parameters.AddWithValue("@duyuru_Metin", duyuru_Metin);
                cmd.Parameters.AddWithValue("@duyuru_Resim", duyuru_Resim);
                cmd.Parameters.AddWithValue("@duyuru_yayinTarihi", duyuru_yayinTarihi);
                cmd.Parameters.AddWithValue("@duyuru_bitisTarihi", duyuru_bitisTarihi);


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

        public int deleteData(int duyuru_id)
        {
            int durum = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("delete DUYURULAR  WHERE duyuru_id=@duyuru_id", con);
                cmd.Parameters.AddWithValue("@duyuru_id", duyuru_id);

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