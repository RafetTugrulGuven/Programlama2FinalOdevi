using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MezunTakip
{
    class UyeCalismaAlani
    {
 
            SqlConnection con;

            public UyeBolum(String conString)
            {

                con = new SqlConnection(conString);
            }
            public int insertData(string uye_tc, int calismaAlani_id)
            {

                int sonuc = 0;
                try
                {
                    SqlCommand cmd = new SqlCommand("insert into UYE_CALISMAALANI(uye_tc, calismaAlani_id) values(@uye_tc, @calismaAlani_id);SELECT SCOPE_IDENTITY()", con);
                    
                    cmd.Parameters.AddWithValue("@uye_tc", uye_tc);
                    cmd.Parameters.AddWithValue("@calismaAlani_id", calismaAlani_id);

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
            public int updateData(int uyeCalismaAlani_id, string uye_tc, int calismaAlani_id)
            {
                int durum = 0;
                try
                {
                    SqlCommand cmd = new SqlCommand("update UYE_CALISMAALANI set uye_tc=@uye_tc,calismaAlani_id=@calismaAlani_id WHERE uyeCalismaAlani_id=@uyeCalismaAlani_id", con);
                    cmd.Parameters.AddWithValue("@uyeCalismaAlani_id", uyeCalismaAlani_id);
                    cmd.Parameters.AddWithValue("@uye_tc", uye_tc);
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

            public int deleteData(int uyeCalismaAlani_id)
            {
                int durum = 0;
                try
                {
                    SqlCommand cmd = new SqlCommand("delete UYE_CALISMAALANI WHERE uyeCalismaAlani_id=@uyeCalismaAlani_id", con);
                    cmd.Parameters.AddWithValue("@uyeCalismaAlani_id", uyeCalismaAlani_id);

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

