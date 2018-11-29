using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace IEXTrading.Models
{
    public class Headline
    {
        public string datetime { get; set; }
        public string headline { get; set; }
        public string source { get; set; }
        public string summary { get; set; }
        [Key]
        public string url { get; set; }
        public string related { get; set; }
    }
}
