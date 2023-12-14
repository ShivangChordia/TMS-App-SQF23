using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_DB.Model
{
    [Table("Admin")]
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }

        [MaxLength(50)]
        public string AdminName { get; set; }

        [MaxLength(50)]
        public string AdminPassword { get; set; }

        public DateTime AdminDOB { get; set; }

        [MaxLength(100)]
        public string AdminEmail { get; set; }

        [MaxLength(20)]
        public string AdminPhone { get; set; }
    }
}
