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
    public class Fakulteler
    {/*  cmd.Parameters.AddWithValue("@fakulte_id", fakulte_id);
                cmd.Parameters.AddWithValue("@fakulte_adi", fakulte_adi);
                cmd.Parameters.AddWithValue("@fakulte_kodu", fakulte_kodu);
*/
        [Key]
        [Required]
        public int fakulte_id { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR")]
        public string fakulte_adi { get; set; }

        [Required]
        public int fakulte_kodu { get; set; }
        #region InverseProperty

      
        [InverseProperty("Fakulteler")]
        public virtual List<Bolumler> fBolum { get; set; }  
        #endregion
    }
}

