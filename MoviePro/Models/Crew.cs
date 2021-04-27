using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MoviePro.Models
{
    public class Crew
    {
        public int Id { get; set; }
        public int MovieId { get; set; }

        //TMDB crewId used to identify crew across movies
        public int CrewId { get; set; }

        public string Department { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }

        //Profile Image
        [Display(Name = "Profile Pic")] //Data Format
        public byte[] Profile { get; set; } //Profile Pic
        public string ContentType { get; set; } //to display Profile Pic

    }
}
