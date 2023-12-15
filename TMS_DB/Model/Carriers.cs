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

        [Required]
        [StringLength(50)]
        public string DepotCity { get; set; }

        public int FTLAvailability { get; set; }

        public int LTLAvailability { get; set; }

        public double FTLRate { get; set; }

        public double LTLRate { get; set; }

        public double ReefCharge { get; set; }
    }
}
