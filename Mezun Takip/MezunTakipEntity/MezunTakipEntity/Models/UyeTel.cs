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
    public class UyeTel
    {
        /*  cmd.Parameters.AddWithValue("@uyeTel_id", uyeTel_id);
                  cmd.Parameters.AddWithValue("@uye_tc", uye_tc);
                  cmd.Parameters.AddWithValue("@uye_tel", uye_tel);*/

        [Key]
        [Required]
        public int uyeTel_id { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR")]
        public string uye_tel { get; set; }
        #region ForeignKey

        public string uye_tc { get; set; }
        [ForeignKey("uye_tc")]
        public virtual Uyeler Uyeler { get; set; }
        #endregion

    }
}
