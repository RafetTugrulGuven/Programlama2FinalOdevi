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
    public class SirketTel
    {
        /*   cmd.Parameters.AddWithValue("@sirketTel_id", sirketTel_id);
                 cmd.Parameters.AddWithValue("@sirket_tel", sirket_tel);
                 cmd.Parameters.AddWithValue("@sirket_id", sirket_id);
 */
        [Key]
        [Required]
        public int sirketTel_id { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR")]
        public string sirket_tel { get; set; }
        #region ForeignKey

      

       
        public int sirket_Id { get; set; }
        [ForeignKey("sirket_Id")]
        public virtual Sirketler Sirketler { get; set; } 
        #endregion
    }
}
