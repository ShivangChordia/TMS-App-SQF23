using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_DB.Model
{
    [Table("Trips")]
    public class Trips
    {
        [Key]
        public int TripID { get; set; }

        public int OrderID { get; set; }

        public int CarrierID { get; set; }

        [ForeignKey("OrderID")]
        public Order Order { get; set; }

        [ForeignKey("CarrierID")]
        public Carrier Carrier { get; set; }
    }
}
