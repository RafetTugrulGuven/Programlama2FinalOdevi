using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MezunTakipMvc.Models
{
    public class UyeBolum
    {
        /*    cmd.Parameters.AddWithValue("@uyeBolum_id", uyeBolum_id);
                cmd.Parameters.AddWithValue("@uye_tc", uye_tc);
                cmd.Parameters.AddWithValue("@bolum_id", bolum_id);

              */
        [Key]
        [Required]
        public int uyeBolum_id { get; set; }



        #region ForeignKey

        public int bolum_id { get; set; }
        [ForeignKey("bolum_id")]
        public virtual Bolumler Bolumler { get; set; }
        public string uye_tc { get; set; }
        [ForeignKey("uye_tc")]
        public virtual Uyeler Uyeler { get; set; }
        #endregion
    }
}
