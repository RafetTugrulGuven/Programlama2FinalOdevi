using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MezunTakip
{
    class UyeMail
    {
        SqlConnection con;

        public UyeMail(String conString)
        {

            con = new SqlConnection(conString);
        }
        public int insertData(string uye_tc, string uyeMail_adres)
        {

            int sonuc = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("insert into UYE_MAIL(uye_tc, uyeMail_adres) values(@uye_tc, @uyeMail_adres);SELECT SCOPE_IDENTITY()", con);
                cmd.Parameters.AddWithValue("@uye_tc", uye_tc);
                cmd.Parameters.AddWithValue("@uyeMail_adres", uyeMail_adres);

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
        public int updateData(int uyeMail_id, string uye_tc, string uyeMail_adres)
        {
            int durum = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("update UYE_MAIL set uye_tc=@uye_tc,uyeMail_adres=@uyeMail_adres WHERE uyeMail_id=@uyeMail_id", con);
                cmd.Parameters.AddWithValue("@uyeMail_id", uyeMail_id);
                cmd.Parameters.AddWithValue("@uye_tc", uye_tc);
                cmd.Parameters.AddWithValue("@uyeMail_adres", uyeMail_adres);

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

        public int deleteData(int uyeMail_id)
        {
            int durum = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("delete UYE_MAIL WHERE uyeMail_id=@uyeMail_id", con);
                cmd.Parameters.AddWithValue("@uyeMail_id", uyeMail_id);

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
