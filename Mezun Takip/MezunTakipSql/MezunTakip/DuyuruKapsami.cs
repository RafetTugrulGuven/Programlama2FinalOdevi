using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MezunTakip
{
    class DuyuruKapsami
    {
        SqlConnection con;

        public DuyuruKapsami(String conString)
        {

            con = new SqlConnection(conString);
        }
        public int insertData(int duyuru_id, int calismaAlani_id)
        {

            int sonuc = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("insert into DUYURU_KAPSAMI(duyuru_id, calismaAlani_id) values(@duyuru_id, @calismaAlani_id);SELECT SCOPE_IDENTITY()", con);
   
                cmd.Parameters.AddWithValue("@duyuru_id", duyuru_id);
                cmd.Parameters.AddWithValue("@calismaAlani_id", calismaAlani_id);

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
        public int updateData(int duyuruKapsam_id, int duyuru_id, int calismaAlani_id)
        {
            int durum = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("update DUYURU_KAPSAMI set duyuru_id=@duyuru_id,calismaAlani_id=@calismaAlani_id WHERE duyuruKapsam_id=@duyuruKapsam_id", con);
                cmd.Parameters.AddWithValue("@duyuruKapsam_id", duyuruKapsam_id);
                cmd.Parameters.AddWithValue("@duyuru_id", duyuru_id);
                cmd.Parameters.AddWithValue("@calismaAlani_id", calismaAlani_id);

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

        public int deleteData(int duyuruKapsam_id)
        {
            int durum = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("delete DUYURU_KAPSAMI  WHERE duyuruKapsam_id=@duyuruKapsam_id", con);
                cmd.Parameters.AddWithValue("@duyuruKapsam_id", duyuruKapsam_id);

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
