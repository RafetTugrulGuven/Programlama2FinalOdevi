using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MezunTakipMvc.Models
{
    public class Sehirler
    {
        [Key]
        [Required]
        public int sehir_id { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR")]
        public string sehir_adi { get; set; }

        [Required]
        public int sehir_kodu { get; set; }

        #region InverseProperty


        [InverseProperty("Sehirler")]
        public virtual List<Ilceler> sIlce { get; set; }
        
        #endregion
    }
}