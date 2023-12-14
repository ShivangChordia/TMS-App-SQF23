using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_DB.Model
{
    [Table("Buyer")]
    public class Buyer
    {
        [Key]
        public int BuyerId { get; set; }

        [MaxLength(50)]
        public string BuyerName { get; set; }

        [MaxLength(50)]
        public string BuyerPassword { get; set; }

        [MaxLength(100)]
        public string BuyerEmail { get; set; }

        public DateTime BuyerDOB { get; set; }

        [MaxLength(20)]
        public string BuyerPhone { get; set; }
    }
}
