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
    public class UyeSirket
    {
        /* cmd.Parameters.AddWithValue("@uyeSirket_id", uyeSirket_id);
                 cmd.Parameters.AddWithValue("@uye_tc", uye_tc);
                 cmd.Parameters.AddWithValue("@sirket_id", sirket_id);
                 cmd.Parameters.AddWithValue("@uyeSirket_durum", uyeSirket_durum);

             */
        [Key]
        [Required]
        public int uyeSirket_id { get; set; }

        [Required]
        public int uyeSirket_durum { get; set; }

       
        #region ForeignKey

        public int sirket_id { get; set; }
        [ForeignKey("sirket_id")]
        public virtual Sirketler Sirketler { get; set; }
        public string uye_tc { get; set; }
        [ForeignKey("uye_tc")]
        public virtual Uyeler Uyeler { get; set; }
        #endregion

    }
}
