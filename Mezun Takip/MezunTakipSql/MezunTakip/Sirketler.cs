using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MezunTakip
{
    class Sirketler
    {

        SqlConnection con;

        public Sirketler(String conString)
        {

            con = new SqlConnection(conString);
        }
        public int insertData(string sirket_adi)
        {

            int sonuc = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("insert into SIRKETLER(sirket_adi) values(@sirket_adi);SELECT SCOPE_IDENTITY()", con);

                cmd.Parameters.AddWithValue("@sirket_adi", sirket_adi);

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
        public int updateData(int sirket_id, string sirket_adi)
        {
            int durum = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("update SIRKETLER set sirket_adi=@sirket_adi WHERE sirket_id=@sirket_id", con);
                cmd.Parameters.AddWithValue("@sirket_id", sirket_id);
                cmd.Parameters.AddWithValue("@sirket_adi", sirket_adi);

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

        public int deleteData(int sirket_id)
        {
            int durum = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("delete SIRKETLER  WHERE sirket_id=@sirket_id", con);
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

    }
}
