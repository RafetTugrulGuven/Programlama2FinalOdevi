using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MezunTakip
{
    class UyeTel
    {
        SqlConnection con;

        public UyeTel(String conString)
        {

            con = new SqlConnection(conString);
        }
        public int insertData(string uye_tc, string uye_tel)
        {

            int sonuc = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("insert into UYE_TEL(uye_tc, uye_tel) values(@uye_tc, @uye_tel);SELECT SCOPE_IDENTITY()", con);
                
                cmd.Parameters.AddWithValue("@uye_tc", uye_tc);
                cmd.Parameters.AddWithValue("@uye_tel", uye_tel);

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
        public int updateData(int uyeTel_id, string uye_tc, string uye_tel)
        {
            int durum = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("update UYE_TEL set uye_tc=@uye_tc,uye_tel=@uye_tel WHERE uyeTel_id=@uyeTel_id", con);
                cmd.Parameters.AddWithValue("@uyeTel_id", uyeTel_id);
                cmd.Parameters.AddWithValue("@uye_tc", uye_tc);
                cmd.Parameters.AddWithValue("@uye_tel", uye_tel);

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

        public int deleteData(int uyeTel_id)
        {
            int durum = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("delete UYE_TEL WHERE uyeTel_id=@uyeTel_id", con);
                cmd.Parameters.AddWithValue("@uyeTel_id", uyeTel_id);

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
