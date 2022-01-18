using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MezunTakip
{
    class OgrenimDurumlari
    {
        SqlConnection con;

        public OgrenimDurumlari(String conString)
        {

            con = new SqlConnection(conString);
        }
        public int insertData(string ogrenimD_tanim)
        {

            int sonuc = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("insert into OGRENIM_DURUMLARI(ogrenimD_tanim) values(@ogrenimD_tanim);SELECT SCOPE_IDENTITY()", con);

                cmd.Parameters.AddWithValue("@ogrenimD_tanim", ogrenimD_tanim);

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
        public int updateData(int ogrenimD_id, string ogrenimD_tanim)
        {
            int durum = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("update OGRENIM_DURUMLARI set ogrenimD_tanim=@ogrenimD_tanim WHERE ogrenimD_id=@ogrenimD_id", con);
                cmd.Parameters.AddWithValue("@ogrenimD_id", ogrenimD_id);
                cmd.Parameters.AddWithValue("@ogrenimD_tanim", ogrenimD_tanim);

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

        public int deleteData(int ogrenimD_id)
        {
            int durum = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("delete OGRENIM_DURUMLARI  WHERE ogrenimD_id=@ogrenimD_id", con);
                cmd.Parameters.AddWithValue("@ogrenimD_id", ogrenimD_id);

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

