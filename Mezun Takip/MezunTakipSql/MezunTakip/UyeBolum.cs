using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MezunTakip
{
    class UyeBolum
    {
        SqlConnection con;

        public UyeBolum(String conString)
        {

            con = new SqlConnection(conString);
        }
        public int insertData(string uye_tc, int bolum_id)
        {

            int sonuc = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("insert into UYE_BOLUM(uye_tc, bolum_id) values(@uye_tc, @bolum_id);SELECT SCOPE_IDENTITY()", con);
                cmd.Parameters.AddWithValue("@uye_tc", uye_tc);
                cmd.Parameters.AddWithValue("@bolum_id", bolum_id);

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
        public int updateData(int uyeBolum_id, string uye_tc, int bolum_id)
        {
            int durum = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("update UYE_BOLUM set uye_tc=@uye_tc,bolum_id=@bolum_id WHERE uyeBolum_id=@uyeBolum_id", con);
                cmd.Parameters.AddWithValue("@uyeBolum_id", uyeBolum_id);
                cmd.Parameters.AddWithValue("@uye_tc", uye_tc);
                cmd.Parameters.AddWithValue("@bolum_id", bolum_id);

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

        public int deleteData(int uyeBolum_id)
        {
            int durum = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("delete UYE_BOLUM WHERE uyeBolum_id=@uyeBolum_id", con);
                cmd.Parameters.AddWithValue("@uyeBolum_id", uyeBolum_id);

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
