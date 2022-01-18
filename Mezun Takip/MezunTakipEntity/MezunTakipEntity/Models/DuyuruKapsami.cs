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
    public class DuyuruKapsami
    {
        /*  cmd.Parameters.AddWithValue("@duyuruKapsam_id", duyuruKapsam_id);
                 cmd.Parameters.AddWithValue("@duyuru_id", duyuru_id);
                 cmd.Parameters.AddWithValue("@calismaAlani_id", calismaAlani_id);
 */
        [Key]
        [Required]
        public int duyuruKapsam_id { get; set; }
        #region ForeignKey
        
        public int duyuru_id { get; set; }
        [ForeignKey("duyuru_id")]
        public virtual Duyurular Duyurular { get; set; }

        public int calismaAlani_id { get; set; }
        [ForeignKey("calismaAlani_id")]
        public virtual CalismaAlanlari CalismaAlanlari { get; set; }
        #endregion
    }
}
