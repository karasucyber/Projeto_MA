using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MA.Models;

namespace  MA.Models
{
    public class Grade
    {
        [Key]
        public int Id {get; set;}

        [Required]
        public int StudentId { get; set; }
        
        [ForeignKey('StudentId')]
        public Student? student {get; set;}
    }
    
}