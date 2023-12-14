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
        public int MarketPlaceId { get; set; }

        [MaxLength(100)]
        public string MarketPlaceName { get; set; }

        [MaxLength(50)]
        public string MarketPlaceCode { get; set; }
    }
}
