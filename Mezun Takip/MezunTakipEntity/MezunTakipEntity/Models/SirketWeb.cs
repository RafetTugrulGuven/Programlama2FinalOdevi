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
    public class SirketWeb
    {
        /*   cmd.Parameters.AddWithValue("@sirketWeb_id", sirketWeb_id);
                 cmd.Parameters.AddWithValue("@sirket_web", sirket_web);
                 cmd.Parameters.AddWithValue("@sirket_id", sirket_id);
 */
        [Key]
        [Required]
        public int sirketWeb_id { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR")]
        public string sirket_web { get; set; }
        #region ForeignKey

       

     
        public int sirket_Id { get; set; }
        [ForeignKey("sirket_Id")]
        public virtual Sirketler Sirketler { get; set; }
        #endregion
    }
}