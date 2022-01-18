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
    public class UyeAdres
    {
        /*  cmd.Parameters.AddWithValue("@uyeAdres_id", uyeAdres_id);
                 cmd.Parameters.AddWithValue("@uye_tc", uye_tc);
                 cmd.Parameters.AddWithValue("@uye_adres", uye_adres);
                 */
        [Key]
        [Required]
        public int uyeAdres_id { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR")]
        public string uye_adres { get; set; }
        #region ForeignKey

        public string uye_tc { get; set; }
        [ForeignKey("uye_tc")]
        public virtual Uyeler Uyeler { get; set; }
        #endregion
    }
}
