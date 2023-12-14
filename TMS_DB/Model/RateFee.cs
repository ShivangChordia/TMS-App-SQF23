using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_DB.Model
{
    [Table("RateFee")]
    public class RateFee
    {
        [Key]
        public int RateFeeID { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        public decimal FeeAmount { get; set; }
    }
}
