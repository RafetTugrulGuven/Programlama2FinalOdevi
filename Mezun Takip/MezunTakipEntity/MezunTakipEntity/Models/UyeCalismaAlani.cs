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
    public class UyeCalismaAlani
    {

        /*      cmd.Parameters.AddWithValue("@uyeCalismaAlani_id", uyeCalismaAlani_id);
                 cmd.Parameters.AddWithValue("@uye_tc", uye_tc);
                 cmd.Parameters.AddWithValue("@calismaAlani_id", calismaAlani_id);
*/
        [Key]
        [Required]
        public int uyeCalismaAlani_id { get; set; }

       

        #region ForeignKey
        public int calismaAlani_id { get; set; }
        [ForeignKey("calismaAlani_id")]
        public virtual CalismaAlanlari CalismaAlanlari { get; set; }

        public string uye_tc { get; set; }
        [ForeignKey("uye_tc")]
        public virtual Uyeler Uyeler { get; set; }
        #endregion
        #region InverseProperty

        #endregion
    }
}

