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
    public class UyeMail
    {
        /*  cmd.Parameters.AddWithValue("@uyeMail_id", uyeMail_id);
                 cmd.Parameters.AddWithValue("@uye_tc", uye_tc);
                 cmd.Parameters.AddWithValue("@uyeMail_adres", uyeMail_adres);
 */
        [Key]
        [Required]
        public int uyeMail_id { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR")]
        public string uyeMail_adres { get; set; }
        #region ForeignKey
        
        public string uye_tc { get; set; }
        [ForeignKey("uye_tc")]
        public virtual Uyeler Uyeler { get; set; }
        #endregion
    }
}
