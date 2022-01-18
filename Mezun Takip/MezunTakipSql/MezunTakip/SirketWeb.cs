using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MezunTakip
{
    class SirketWeb
    {
        SqlConnection con;

        public SirketWeb(String conString)
        {

            con = new SqlConnection(conString);
        }
        public int insertData(string sirket_web, int sirket_id)
        {

            int sonuc = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("insert into SIRKET_WEB(sirket_web, sirket_id) values(@sirket_web, @sirket_id);SELECT SCOPE_IDENTITY()", con);

                cmd.Parameters.AddWithValue("@sirket_web", sirket_web);
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
        public int updateData(int sirketWeb_id, string sirket_web, int sirket_id)
        {
            int durum = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("update SIRKET_WEB set sirket_web=@sirket_web,sirket_id=@sirket_id WHERE sirketWeb_id=@sirketWeb_id", con);
                cmd.Parameters.AddWithValue("@sirketWeb_id", sirketWeb_id);
                cmd.Parameters.AddWithValue("@sirket_web", sirket_web);
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

        public int deleteData(int sirketWeb_id)
        {
            int durum = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("delete SIRKET_WEB WHERE sirketWeb_id=@sirketWeb_id", con);
                cmd.Parameters.AddWithValue("@sirketWeb_id", sirketWeb_id);

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