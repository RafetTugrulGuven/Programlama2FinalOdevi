using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MezunTakip
{
    class UyeAdres
    {
        SqlConnection con;

        public UyeAdres(String conString)
        {

            con = new SqlConnection(conString);
        }
        public int insertData(string uye_tc, string uye_adres)
        {

            int sonuc = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("insert into UYE_ADRES(uye_tc, uye_adres) values(@uye_tc, @uye_adres);SELECT SCOPE_IDENTITY()", con);

                cmd.Parameters.AddWithValue("@uye_tc", uye_tc);
                cmd.Parameters.AddWithValue("@uye_adres", uye_adres);

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
        public int updateData(int uyeAdres_id, string uye_tc, string uye_adres)
        {
            int durum = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("update UYE_ADRES set uye_tc=@uye_tc,uye_adres=@uye_adres WHERE uyeAdres_id=@uyeAdres_id", con);
                cmd.Parameters.AddWithValue("@uyeAdres_id", uyeAdres_id);
                cmd.Parameters.AddWithValue("@uye_tc", uye_tc);
                cmd.Parameters.AddWithValue("@uye_adres", uye_adres);

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

        public int deleteData(int uyeAdres_id)
        {
            int durum = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("delete UYE_ADRES WHERE uyeAdres_id=@uyeAdres_id", con);
                cmd.Parameters.AddWithValue("@uyeAdres_id", uyeAdres_id);

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
