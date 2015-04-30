using System.ComponentModel.DataAnnotations;

namespace OilScraper.Domain.Model
{
    public class RigInfo
    {
        [Key]
        public int Id { get; set; }
        public string RigName { get; set; }
        public string Manager { get; set; }
        public string RigType { get; set; }
        public string RatedWaterDepth { get; set; }
        public string DrillingDepth { get; set; }
    }
}
