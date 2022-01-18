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
    public class OgrenimDurumlari
    {
        /* cmd.Parameters.AddWithValue("@ogrenimD_id", ogrenimD_id);
                 cmd.Parameters.AddWithValue("@ogrenimD_tanim", ogrenimD_tanim);
 */
        [Key]
        [Required]
        public int ogrenimD_id { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR")]
        public string ogrenimD_tanim { get; set; }

        #region ForeignKey

        #endregion
        #region InverseProperty
        [InverseProperty("OgrenimDurumlari")]
        public virtual List<UyeOgrenimDurumu> UyeOgrenimDurum { get; set; }


        #endregion
    }
}

