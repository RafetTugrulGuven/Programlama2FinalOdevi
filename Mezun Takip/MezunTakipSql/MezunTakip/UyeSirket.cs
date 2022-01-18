using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MezunTakip
{
    class UyeSirket
    {
        SqlConnection con;

        public UyeSirket(String conString)
        {

            con = new SqlConnection(conString);
        }
        public int insertData(string uye_tc, int sirket_id, int uyeSirket_durum)
        {

            int sonuc = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("insert into UYE_SIRKET(uye_tc, sirket_id,uyeSirket_durum) values(@uye_tc, @sirket_id, @uyeSirket_durum);SELECT SCOPE_IDENTITY()", con);
                cmd.Parameters.AddWithValue("@uye_tc", uye_tc);
                cmd.Parameters.AddWithValue("@sirket_id", sirket_id);
                cmd.Parameters.AddWithValue("@uyeSirket_durum", uyeSirket_durum);

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
        public int updateData(int uyeSirket_id, string uye_tc, int sirket_id, int uyeSirket_durum)
        {
            int durum = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("update UYE_SIRKET set uye_tc=@uye_tc,sirket_id=@sirket_id,uyeSirket_durum=@uyeSirket_durum WHERE uyeSirket_id=@uyeSirket_id", con);
                cmd.Parameters.AddWithValue("@uyeSirket_id", uyeSirket_id);
                cmd.Parameters.AddWithValue("@uye_tc", uye_tc);
                cmd.Parameters.AddWithValue("@sirket_id", sirket_id);
                cmd.Parameters.AddWithValue("@uyeSirket_durum", uyeSirket_durum);

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

        public int deleteData(int uyeSirket_id)
        {
            int durum = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("delete UYE_SIRKET WHERE uyeSirket_id=@uyeSirket_id", con);
                cmd.Parameters.AddWithValue("@uyeSirket_id", uyeSirket_id);

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
