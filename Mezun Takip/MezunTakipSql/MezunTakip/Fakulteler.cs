using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MezunTakip
{
    class Fakulteler
    {
        SqlConnection con;

        public Fakulteler(String conString)
        {

            con = new SqlConnection(conString);
        }
        public int insertData(string fakulte_adi, int fakulte_kodu)
        {

            int sonuc = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("insert into FAKULTELER(fakulte_adi, fakulte_kodu) values(@fakulte_adi, @fakulte_kodu);SELECT SCOPE_IDENTITY()", con);

                cmd.Parameters.AddWithValue("@fakulte_adi", fakulte_adi);
                cmd.Parameters.AddWithValue("@fakulte_kodu", fakulte_kodu);

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
        public int updateData(int fakulte_id, string fakulte_adi, int fakulte_kodu)
        {
            int durum = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("update FAKULTELER set fakulte_adi=@fakulte_adi,fakulte_kodu=@fakulte_kodu WHERE fakulte_id=@fakulte_id", con);
                cmd.Parameters.AddWithValue("@fakulte_id", fakulte_id);
                cmd.Parameters.AddWithValue("@fakulte_adi", fakulte_adi);
                cmd.Parameters.AddWithValue("@fakulte_kodu", fakulte_kodu);

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

        public int deleteData(int fakulte_id)
        {
            int durum = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("delete FAKULTELER  WHERE fakulte_id=@fakulte_id", con);
                cmd.Parameters.AddWithValue("@fakulte_id", fakulte_id);
    
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

