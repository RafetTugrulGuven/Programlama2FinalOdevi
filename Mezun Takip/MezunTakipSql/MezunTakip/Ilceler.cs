using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MezunTakip
{
    class Ilceler
    {
        SqlConnection con;

        public Ilceler(String conString)
        {

            con = new SqlConnection(conString);
        }
        public int insertData(string ilce_adi, int ilceSehir_Kodu)
        {

            int sonuc = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("insert into ILCELER(ilce_adi, ilceSehir_Kodu) values(@ilce_adi, @ilceSehir_Kodu);SELECT SCOPE_IDENTITY()", con);
   
                cmd.Parameters.AddWithValue("@ilce_adi", ilce_adi);
                cmd.Parameters.AddWithValue("@ilceSehir_Kodu", ilceSehir_Kodu);

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
        public int updateData(int ilce_id, string ilce_adi, int ilceSehir_Kodu)
        {
            int durum = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("update ILCELER set ilce_adi=@ilce_adi,ilceSehir_Kodu=@ilceSehir_Kodu WHERE ilce_id=@ilce_id", con);
                cmd.Parameters.AddWithValue("@ilce_id", ilce_id);
                cmd.Parameters.AddWithValue("@ilce_adi", ilce_adi);
                cmd.Parameters.AddWithValue("@ilceSehir_Kodu", ilceSehir_Kodu);

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

        public int deleteData(int ilce_id)
        {
            int durum = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("delete ILCELER  WHERE ilce_id=@ilce_id", con);
                cmd.Parameters.AddWithValue("@ilce_id", ilce_id);

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

