using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 
using System;
using MA.Models;

namespace MA.Models
{
    public class PresenceViewModel
    {   
        [Key]
        public int Id { get; set; }  
       
        [Required]
        public string StudentName { get; set; } = string.Empty; 
        
        [Required]
        public int Counter { get; set; } 
        
        [Required]
        public DateTime DateTime { get; set; } = DateTime.Now; 

        [Required]
        public bool Check { get; set; }  

        public int StudentId { get; set; } 

        [ForeignKey("StudentId")]
        public Student? Student { get; set; }  // Agora a referência está correta
    }
}
