using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MezunTakip
{
    class SirketTel
    {
        SqlConnection con;

        public SirketTel(String conString)
        {

            con = new SqlConnection(conString);
        }
        public int insertData(string sirket_tel, int sirket_id)
        {

            int sonuc = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("insert into SIRKET_TEL(sirket_tel, sirket_id) values(@sirket_tel, @sirket_id);SELECT SCOPE_IDENTITY()", con);
                
                cmd.Parameters.AddWithValue("@sirket_tel", sirket_tel);
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
        public int updateData(int sirketTel_id, string sirket_tel, int sirket_id)
        {
            int durum = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("update SIRKET_TEL set sirket_tel=@sirket_tel,sirket_id=@sirket_id WHERE sirketTel_id=@sirketTel_id", con);
                cmd.Parameters.AddWithValue("@sirketTel_id", sirketTel_id);
                cmd.Parameters.AddWithValue("@sirket_tel", sirket_tel);
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

        public int deleteData(int sirketTel_id)
        {
            int durum = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("delete SIRKET_TEL WHERE sirketTel_id=@sirketTel_id", con);
                cmd.Parameters.AddWithValue("@sirketTel_id", sirketTel_id);

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
