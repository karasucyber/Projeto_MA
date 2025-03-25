using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;

namespace MA.Models
{
    public class Student 
    {
        [Key]
        public int Id { get; set; }  

        [Required]
        public string Name { get; set; } = string.Empty; 

        [Required]
        [StringLength(11)]
        public string Cpf { get; set; } = string.Empty; 

        [Required]
        public DateTime DateBirth { get; set; } 

        public List<PresenceViewModel>? Presences { get; set; }  
    }
}
