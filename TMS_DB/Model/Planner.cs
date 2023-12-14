using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_DB.Model
{
    [Table("Planner")]
    public class Planner
    {
        [Key]
        public int PlannerId { get; set; }

        [MaxLength(50)]
        public string PlannerName { get; set; }

        [MaxLength(50)]
        public string PlannerPassword { get; set; }

        [MaxLength(100)]
        public string PlannerEmail { get; set; }

        public DateTime PlannerDOB { get; set; }

        [MaxLength(20)]
        public string PlannerPhone { get; set; }
    }

}
