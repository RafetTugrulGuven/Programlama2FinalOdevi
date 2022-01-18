using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MezunTakip
{
    class Sehirler
    {
        SqlConnection con;

        public Sehirler(String conString)
        {

            con = new SqlConnection(conString);
        }
        public int insertData(string sehir_adi, int sehir_kodu)
        {

            int sonuc = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("insert into SEHIRLER(sehir_adi, sehir_kodu) values(@sehir_adi, @sehir_kodu);SELECT SCOPE_IDENTITY()", con);

                cmd.Parameters.AddWithValue("@sehir_adi", sehir_adi);
                cmd.Parameters.AddWithValue("@sehir_kodu", sehir_kodu);

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
        public int updateData(int sehir_id, string sehir_adi, int sehir_kodu)
        {
            int durum = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("update SEHIRLER set sehir_adi=@sehir_adi,sehir_kodu=@sehir_kodu WHERE sehir_id=@sehir_id", con);
                cmd.Parameters.AddWithValue("@sehir_id", sehir_id);
                cmd.Parameters.AddWithValue("@sehir_adi", sehir_adi);
                cmd.Parameters.AddWithValue("@sehir_kodu", sehir_kodu);

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

        public int deleteData(int sehir_id)
        {
            int durum = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("delete SEHIRLER  WHERE sehir_id=@sehir_id", con);
                cmd.Parameters.AddWithValue("@sehir_id", sehir_id);

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
