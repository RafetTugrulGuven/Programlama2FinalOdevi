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
    public class Sirketler
    {

        /*  cmd.Parameters.AddWithValue("@sirket_id", sirket_id);
                  cmd.Parameters.AddWithValue("@sirket_adi", sirket_adi);
                  */
        [Key]
        [Required]
        public int sirket_id { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR")]
        public string sirket_adi { get; set; }
        
        #region InverseProperty

      
        [InverseProperty("Sirketler")]
        public virtual List<SirketTel> sTel { get; set; }

        [InverseProperty("Sirketler")]
        public virtual List<SirketAdres> sAdres { get; set; }

        [InverseProperty("Sirketler")]
        public virtual List<SirketWeb> sWeb { get; set; } 
        #endregion
    }
}
