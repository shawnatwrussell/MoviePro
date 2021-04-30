using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MoviePro.Models
{
    public class Cast
    {
        public int Id  { get; set; }

        [Display(Name = "Movie")]
        public int MovieId { get; set; }

        //TMDB castId used to identify cast across movies
        public int CastId { get; set; }

        public string Department { get; set; }
        public string Name { get; set; }
        public string Character { get; set; }
        public int Order { get; set; }  //Top Billing first

        //Profile Image
        [Display(Name = "Profile Pic")] //Data Format
        public byte[] Poster { get; set; }
        public string ContentType { get; set; }


        public Movie Movie { get; set; }


    }
}
