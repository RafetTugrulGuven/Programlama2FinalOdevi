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
    public class Duyurular
    {
        /*  cmd.Parameters.AddWithValue("@duyuru_id", duyuru_id);
                 cmd.Parameters.AddWithValue("@duyuru_sahibiTc", duyuru_sahibiTc);
                 cmd.Parameters.AddWithValue("@duyuru_Basligi", duyuru_Basligi);
                 cmd.Parameters.AddWithValue("@duyuru_Metin", duyuru_Metin);
                 cmd.Parameters.AddWithValue("@duyuru_Resim", duyuru_Resim);
                 cmd.Parameters.AddWithValue("@duyuru_yayinTarihi", duyuru_yayinTarihi);
                 cmd.Parameters.AddWithValue("@duyuru_bitisTarihi", duyuru_bitisTarihi);
 */
        [Key]
        [Required]
        public int duyuru_id { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR")]
        public string duyuru_Basligi { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR")]
        public string duyuru_Metin { get; set; }

        [Column(TypeName = "IMAGE")]
        public byte[] duyuru_Resim { get; set; }

        public System.Nullable<DateTime> duyuru_yayinTarihi { get; set; }

        public System.Nullable<DateTime> duyuru_bitisTarihi { get; set; }
        #region ForeignKey


        public string duyuru_sahibiTc { get; set; }
        [ForeignKey("duyuru_sahibiTc")]
        public virtual Uyeler Uyeler { get; set; }
        #endregion
        #region InverseProperty


        [InverseProperty("Duyurular")]
        public virtual List<DuyuruBasvuru> DuyuruBasvuru { get; set; }
        #endregion
    }
}