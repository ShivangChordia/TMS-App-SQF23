using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_DB.Model
{
    [Table("ContractMarketplace")]
    public class ContractMarketplace
    {
        [Key]
        public int Id { get; set; } // Assuming you have an ID field in the table

        [MaxLength(255)]
        public string ClientName { get; set; }

        [MaxLength(100)]
        public string JobType { get; set; }

        public int Quantity { get; set; }

        [MaxLength(100)]
        public string Origin { get; set; }

        [MaxLength(100)]
        public string Destination { get; set; }

        [MaxLength(50)]
        public string VanType { get; set; }
    }
}
