using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MezunTakipMvc.Models
{
    public class Ilceler
    {

        [Key]
        [Required]
        public int ilce_id { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR")]
        public string ilce_adi { get; set; }
        #region ForeignKey

        public int ilce_SehirId { get; set; }
        [ForeignKey("ilce_SehirId")]
        public virtual Sehirler Sehirler { get; set; }
        #endregion
        #region InverseProperty
        [InverseProperty("Ilceler")]
        public virtual List<Uyeler> sUye { get; set; }
        #endregion

    }
}