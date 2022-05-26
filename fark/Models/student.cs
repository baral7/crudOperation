using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace fark.Models
{
    public partial class student
    {
       [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        
        
    }
}
