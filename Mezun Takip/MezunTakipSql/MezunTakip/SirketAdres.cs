using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MezunTakip
{
    class SirketAdres
    {

        SqlConnection con;

        public SirketAdres(String conString)
        {

            con = new SqlConnection(conString);
        }
        public int insertData(string sirket_adres, int sirket_id)
        {

            int sonuc = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("insert into SIRKET_ADRES(sirket_adres, sirket_id) values(@sirket_adres, @sirket_id);SELECT SCOPE_IDENTITY()", con);
 
                cmd.Parameters.AddWithValue("@sirket_adres", sirket_adres);
                cmd.Parameters.AddWithValue("@sirket_id", sirket_id);

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
        public int updateData(int sirketAdres_id, string sirket_adres, int sirket_id)
        {
            int durum = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("update SIRKET_ADRES set sirket_adres=@sirket_adres,sirket_id=@sirket_id WHERE sirketAdres_id=@sirketAdres_id", con);
                cmd.Parameters.AddWithValue("@sirketAdres_id", sirketAdres_id);
                cmd.Parameters.AddWithValue("@sirket_adres", sirket_adres);
                cmd.Parameters.AddWithValue("@sirket_id", sirket_id);

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

        public int deleteData(int sirketAdres_id)
        {
            int durum = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("delete SIRKET_ADRES  WHERE sirketAdres_id=@sirketAdres_id", con);
                cmd.Parameters.AddWithValue("@sirketAdres_id", sirketAdres_id);

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
