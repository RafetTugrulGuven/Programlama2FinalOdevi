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
    public class CalismaAlanlari
    {/*   cmd.Parameters.AddWithValue("@calismaAlani_id", calismaAlani_id);
                cmd.Parameters.AddWithValue("@calismaAlani_adi", calismaAlani_adi);
                cmd.Parameters.AddWithValue("@bolum_Id", bolum_Id);
*/
        [Key]
        [Required]
        public int calismaAlani_id { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR")]
        public string calismaAlani_adi { get; set; }
        #region ForeignKey


        public int bolum_Id { get; set; }
        [ForeignKey("bolum_Id")]
        public virtual Bolumler Bolumler { get; set; }
        #endregion
        #region InverseProperty


        [InverseProperty("CalismaAlanlari")]
        public virtual List<DuyuruKapsami> DuyuruKapsami { get; set; }

        [InverseProperty("CalismaAlanlari")]
        public virtual List<UyeCalismaAlani> UyeCalismaAlani { get; set; }
        #endregion
    }
}
