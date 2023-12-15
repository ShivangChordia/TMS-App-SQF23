using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_DB.Model
{
    [Table("Route")]
    public class Route
    {
        [Key]
        public int RouteID { get; set; }

        public string RouteStartPoint { get; set; }

        public string RouteEndPoint { get; set; }

        public int TotalDistance  { get; set; }

        public float TimeInHours  { get; set; }

    }
}
