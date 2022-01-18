using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MezunTakipMvc.Models
{
    public class Bolumler
    {/*   cmd.Parameters.AddWithValue("@bolum_id", bolum_id);
                cmd.Parameters.AddWithValue("@bolum_adi", bolum_adi);
                cmd.Parameters.AddWithValue("@bolum_kodu", bolum_kodu);
                cmd.Parameters.AddWithValue("@bolumFakulte_kodu", bolumFakulte_kodu);
*/

        [Key]
        [Required]
        public int bolum_id { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR")]
        public string bolum_adi { get; set; }

        [Required]
        public int bolum_kodu { get; set; }
        #region ForeignKey
        
        public int bolum_FakulteId { get; set; }
        [ForeignKey("bolum_FakulteId")]
        public virtual Fakulteler Fakulteler { get; set; }
        #endregion
        #region InverseProperty
        
        [InverseProperty("Bolumler")]
        public virtual List<CalismaAlanlari> bCalismaAlani { get; set; }
        #endregion
    }
}
