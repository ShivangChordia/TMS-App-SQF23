using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_DB.Model
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        public int UserId { get; set; }

        [MaxLength(50)]
        public string UserName { get; set; }

        [MaxLength(100)]
        public string UserEmail { get; set; }

        [MaxLength(50)]
        public string UserPassword { get; set; }

        public DateTime UserDOB { get; set; }

        [MaxLength(20)]
        public string UserPhone { get; set; }
    }

}
