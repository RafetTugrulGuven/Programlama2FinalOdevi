using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MezunTakip
{
    class DuyuruBasvuru
    {
        SqlConnection con;

        public DuyuruBasvuru(String conString)
        {

            con = new SqlConnection(conString);
        }
        public int insertData(int duyuru_id, int uye_tc)
        {

            int sonuc = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("insert into DUYURU_BASVURU(duyuru_id, uye_tc) values(@duyuru_id, @uye_tc);SELECT SCOPE_IDENTITY()",con);

                cmd.Parameters.AddWithValue("@duyuru_id", duyuru_id);
                cmd.Parameters.AddWithValue("@uye_tc", uye_tc);

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
        public int updateData(int duyuruBasvuru_id, int duyuru_id, int uye_tc)
        {
            int durum = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("update DUYURU_BASVURU set duyuru_id=@duyuru_id,uye_tc=@uye_tc WHERE duyuruBasvuru_id=@duyuruBasvuru_id", con);
                cmd.Parameters.AddWithValue("@duyuruBasvuru_id", duyuruBasvuru_id);
                cmd.Parameters.AddWithValue("@duyuru_id", duyuru_id);
                cmd.Parameters.AddWithValue("@uye_tc", uye_tc);

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

        public int deleteData(int duyuruBasvuru_id)
        {
            int durum = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("delete DUYURU_BASVURU  WHERE duyuruBasvuru_id=@duyuruBasvuru_id",con);
                cmd.Parameters.AddWithValue("@duyuruBasvuru_id", duyuruBasvuru_id);

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
