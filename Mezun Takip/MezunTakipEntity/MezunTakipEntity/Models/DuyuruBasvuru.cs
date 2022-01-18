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
    public class DuyuruBasvuru
    {
        /*   cmd.Parameters.AddWithValue("@duyuruBasvuru_id", duyuruBasvuru_id);
                   cmd.Parameters.AddWithValue("@duyuru_id", duyuru_id);
                   cmd.Parameters.AddWithValue("@uye_tc", uye_tc);
   */
        [Key]
        [Required]
        public int duyuruBasvuru_id { get; set; }

        public System.Nullable<int> duyuruBasvuru_durum { get; set; }
        

        #region ForeignKey

        public int duyuru_id { get; set; }
        [ForeignKey("duyuru_id")]
        public virtual Duyurular Duyurular { get; set; }

        public string uye_tc { get; set; }
        [ForeignKey("uye_tc")]
        public virtual Uyeler Uyeler { get; set; }
        #endregion
    }
}
