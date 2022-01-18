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
    public class Uyeler
    {
        /*   cmd.Parameters.AddWithValue("@uye_id", uye_id);
                 cmd.Parameters.AddWithValue("@uye_tc", uye_tc);
                 cmd.Parameters.AddWithValue("@uye_ad", uye_ad);
                 cmd.Parameters.AddWithValue("@uye_soyad", uye_soyad);
                 cmd.Parameters.AddWithValue("@uye_dogumTarihi", uye_dogumTarihi);
                 cmd.Parameters.AddWithValue("@uye_dogumYeri_id", uye_dogumYeri_id);
                 cmd.Parameters.AddWithValue("@uye_cinsiyet", uye_cinsiyet);
                 cmd.Parameters.AddWithValue("@uye_askerlikDurumu", uye_askerlikDurumu);
                 cmd.Parameters.AddWithValue("@uye_foto", uye_foto);
 */
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        [Required]
        public int uye_id { get; set; }

        [Key]
        [Required]
        [Column(TypeName = "VARCHAR")]
        public string uye_tc { get; set; }


        [Required]
        [Column(TypeName = "VARCHAR")]
        public string uye_ad { get; set; }

        [Column(TypeName = "VARCHAR")]
        public string uye_soyad { get; set; }

        [Column(TypeName = "VARCHAR")]
        public string uye_sifre { get; set; }

        public System.Nullable<DateTime> uye_dogumTarihi { get; set; }

        public int uye_cinsiyet { get; set; }

        public System.Nullable<int> uye_askerlikDurumu { get; set; }

        [Column(TypeName = "IMAGE")]
        public byte[] uye_foto { get; set; }

        #region ForeignKey
        public int uye_dogumYeri_id { get; set; }
        [ForeignKey("uye_dogumYeri_id")]
        public virtual Ilceler Ilceler { get; set; }

        #endregion

        #region InverseProperty

        [InverseProperty("Uyeler")]
        public virtual List<Duyurular> Duyurular { get; set; }

        [InverseProperty("Uyeler")]
        public virtual List<UyeCalismaAlani> UyeCalismaAlani { get; set; }

        [InverseProperty("Uyeler")]
        public virtual List<UyeOgrenimDurumu> UyeOgrenimDurumu { get; set; }
        #endregion
    }
}
