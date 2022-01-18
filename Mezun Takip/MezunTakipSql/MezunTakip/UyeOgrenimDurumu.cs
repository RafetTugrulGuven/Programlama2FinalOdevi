using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MezunTakip
{
    class UyeOgrenimDurumu
    {
        SqlConnection con;

        public UyeOgrenimDurumu(String conString)
        {

            con = new SqlConnection(conString);
        }
        public int insertData(string uye_tc, int ogrenimD_id, int ogrenimD_durum)
        {

            int sonuc = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("insert into UYE_OGRENIMDURUMU(uye_tc, ogrenimD_id,ogrenimD_durum) values(@uye_tc, @ogrenimD_id, @ogrenimD_durum);SELECT SCOPE_IDENTITY()", con);
                
                cmd.Parameters.AddWithValue("@uye_tc", uye_tc);
                cmd.Parameters.AddWithValue("@ogrenimD_id", ogrenimD_id);
                cmd.Parameters.AddWithValue("@ogrenimD_durum", ogrenimD_durum);

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
        public int updateData(int uyeOgrenimD_id, string uye_tc, int ogrenimD_id, int ogrenimD_durum)
        {
            int durum = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("update UYE_OGRENIMDURUMU set uye_tc=@uye_tc,ogrenimD_id=@ogrenimD_id,ogrenimD_durum=@ogrenimD_durum WHERE uyeOgrenimD_id=@uyeOgrenimD_id", con);
                cmd.Parameters.AddWithValue("@uyeOgrenimD_id", uyeOgrenimD_id);
                cmd.Parameters.AddWithValue("@uye_tc", uye_tc);
                cmd.Parameters.AddWithValue("@ogrenimD_id", ogrenimD_id);
                cmd.Parameters.AddWithValue("@ogrenimD_durum", ogrenimD_durum);

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

        public int deleteData(int uyeOgrenimD_id)
        {
            int durum = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("delete UYE_OGRENIMDURUMU WHERE uyeOgrenimD_id=@uyeOgrenimD_id", con);
                cmd.Parameters.AddWithValue("@uyeOgrenimD_id", uyeOgrenimD_id);

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
