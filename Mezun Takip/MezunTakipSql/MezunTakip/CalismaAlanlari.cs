using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MezunTakip
{
    class CalismaAlanlari
    {
        SqlConnection con;

        public CalismaAlanlari(String conString)
        {

            con = new SqlConnection(conString);
        }
        public int insertData(string calismaAlani_adi, int bolum_Id)
        {

            int sonuc = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("insert into CALISMA_ALANLARI(calismaAlani_adi,bolum_Id) values(@calismaAlani_adi, @bolum_Id);SELECT SCOPE_IDENTITY()",con);
                cmd.Parameters.AddWithValue("@calismaAlani_adi", calismaAlani_adi);
                cmd.Parameters.AddWithValue("@bolum_Id", bolum_Id);

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
        public int updateData(int calismaAlani_id, string calismaAlani_adi, int bolum_Id)
        {
            int durum = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("update CALISMA_ALANLARI set calismaAlani_adi=@calismaAlani_adi,bolum_Id=@bolum_Id WHERE calismaAlani_id=@calismaAlani_id",con);
                cmd.Parameters.AddWithValue("@calismaAlani_id", calismaAlani_id);
                cmd.Parameters.AddWithValue("@calismaAlani_adi", calismaAlani_adi);
                cmd.Parameters.AddWithValue("@bolum_Id", bolum_Id);

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

        public int deleteData(int calismaAlani_id)
        {
            int durum = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("delete CALISMA_ALANLARI  WHERE calismaAlani_id=@calismaAlani_id",con);
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
    
}
}
