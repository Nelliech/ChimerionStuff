using System.ComponentModel.DataAnnotations;

namespace ChimerionStuffApi.Models
{
    public abstract class BasicStuff :BasicEntity
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Manufacturer { get; set; }
        public DateTime ProductionDate { get; set; }
        public string ProductionPlace { get; set; }


    }
}
