using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_DB.Model
{
    [Table("Carriers")]
    public class Carrier
    {
        [Key]
        public int CarrierID { get; set; }

        [Required]
        [StringLength(100)]
        public string CarrierName { get; set; }

        [StringLength(50)]
        public string City { get; set; }
    }
}
