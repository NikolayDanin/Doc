using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1.Models
{
    [Table("Ipxes")]
    public class IpxModel
    {
        public int Id { get; set; }
        public string DecimalNumber { get; set; }
        public string ProgramName { get; set; }
        public string Subject { get; set; }
        public string DocumentUsage { get; set; }
        public string Letter { get; set; }
        public string Author { get; set; }
        public string Organization { get; set; }
        public string Producer { get; set; }
        public string Owner { get; set; }
        public string ResponsiblePerson { get; set; }
        public string HeadOfBmd { get; set; }
        public string SetupDisc { get; set; }
        public string SourceDisc { get; set; }
        public string Note { get; set; }
    }
}
