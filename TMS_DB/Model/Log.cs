using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_DB.Model
{

    [Table("LogEntry")]
    public class LogEntry
    {

        [Key]
        public int LogId { get; set; }

        [MaxLength(200)]
        public DateTime Timestamp { get; set; }

        public string Action { get; set; }
        
        public string Description { get; set; }
        
    }


}
