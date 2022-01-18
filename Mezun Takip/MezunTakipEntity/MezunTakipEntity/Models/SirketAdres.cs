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
    public class SirketAdres
    {/*   cmd.Parameters.AddWithValue("@sirketAdres_id", sirketAdres_id);
                cmd.Parameters.AddWithValue("@sirket_adres", sirket_adres);
                cmd.Parameters.AddWithValue("@sirket_id", sirket_id);
*/
        [Key]
        [Required]
        public int sirketAdres_id { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR")]
        public string sirket_adres { get; set; }
        #region ForeignKey

     

     
        public int sirket_Id { get; set; }
        [ForeignKey("sirket_Id")]
        public virtual Sirketler Sirketler { get; set; }
        #endregion
    }
}
