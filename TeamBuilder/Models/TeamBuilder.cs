using System;
using System.ComponentModel.DataAnnotations;

namespace TeamBuilder.Models
{
    public class TeamBuilder
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [Required]
        public DateTime Created { get; set; }// Myles first line of code. 5/5/2022 approx 6:15 am est: "JJJDJD", love you son. 
        public DateTime Starts { get; set; }
        public DateTime Ends { get; set; }
        [Required]
        public Int64 Attending { get; set; }
    }
}
