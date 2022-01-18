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
    public class UyeOgrenimDurumu
    {/*  cmd.Parameters.AddWithValue("@uyeOgrenimD_id", uyeOgrenimD_id);
                cmd.Parameters.AddWithValue("@uye_tc", uye_tc);
                cmd.Parameters.AddWithValue("@ogrenimD_id", ogrenimD_id);
                cmd.Parameters.AddWithValue("@ogrenimD_durum", ogrenimD_durum);

            */

        [Key]
        [Required]
        public int uyeOgrenimD_id { get; set; }

        [Required]
        public int ogrenimD_durum { get; set; }

        #region ForeignKey
        public int ogrenimD_id { get; set; }
        [ForeignKey("ogrenimD_id")]
        public virtual OgrenimDurumlari OgrenimDurumlari { get; set; }

        public string uye_tc { get; set; }
        [ForeignKey("uye_tc")]
        public virtual Uyeler Uyeler { get; set; }
        #endregion
        #region InverseProperty

        #endregion
    }
}
