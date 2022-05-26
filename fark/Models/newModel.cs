using System.ComponentModel.DataAnnotations;

namespace fark.Models
{
    public class newModel
    {
        [Key]
 
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
