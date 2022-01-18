using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MezunTakip
{
    class Bolumler
    {
        SqlConnection con;

        public Bolumler(String conString)
        {

            con = new SqlConnection(conString);
        }
        public int insertData(string bolum_adi, int bolum_kodu, int bolumFakulte_kodu)
        {

            int sonuc = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("insert into BOLUMLER(bolum_adi, bolum_kodu, bolumFakulte_kodu) values(@bolum_adi, @bolum_kodu, @bolumFakulte_kodu);SELECT SCOPE_IDENTITY()",con);
               
                cmd.Parameters.AddWithValue("@bolum_adi", bolum_adi);
                cmd.Parameters.AddWithValue("@bolum_kodu", bolum_kodu);
                cmd.Parameters.AddWithValue("@bolumFakulte_kodu", bolumFakulte_kodu);

                con.Open();
                sonuc = cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex) {

                sonuc = 0;
                con.Close();

            }
            
            return sonuc;
            
       }
        public int updateData(int bolum_id,string bolum_adi, int bolum_kodu, int bolumFakulte_kodu)
        {
            int durum = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("update BOLUMLER set bolum_adi=@bolum_adi,bolum_kodu=@bolum_kodu,bolumFakulte_kodu=@bolumFakulte_kodu WHERE bolum_id=@bolum_id",con);
                cmd.Parameters.AddWithValue("@bolum_id", bolum_id);
                cmd.Parameters.AddWithValue("@bolum_adi", bolum_adi);
                cmd.Parameters.AddWithValue("@bolum_kodu", bolum_kodu);
                cmd.Parameters.AddWithValue("@bolumFakulte_kodu", bolumFakulte_kodu);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                durum = 1;

            }catch(Exception ex){

                durum = 0;

            }

            return durum;

        }

        public int deleteData(int bolum_id)
        {
            int durum = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("delete BOLUMLER  WHERE bolum_id=@bolum_id",con);
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
    }
}
