using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1.Models
{
    [Table("Labels")]
    public class LabelModel
    {
        public int Id { get; set; }
        public string DecimalNumber { get; set; }
        public string ProgramName { get; set; }
        public string DocumentCode { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public string VolumeSequenceNumber { get; set; }
        public string SetupDisc { get; set; }
        public string SourceDisc { get; set; }
        public string Note { get; set; }
    }
}
