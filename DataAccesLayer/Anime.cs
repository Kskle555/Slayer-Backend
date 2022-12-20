using System.ComponentModel.DataAnnotations;

namespace Fansub.DataAccesLayer
{
    public class Anime
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Episode { get; set; }
        public string Genre { get; set; }
    }
}
