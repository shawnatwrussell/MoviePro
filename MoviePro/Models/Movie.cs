using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using MoviePro.Enums;

namespace MoviePro.Models
{
    public class Movie //Represents the Movie Table
    {
        public int Id { get; set; } //Primary Key??
        //the movieID from TMDB

        public int MovieId { get; set; }  
        public string Title { get; set; }  //Title of the Movie
        public string TagLine { get; set; }
        public string Overview { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Movie Poster")]
        public byte[] Poster { get; set; }
        public string ContentType { get; set; }

        [Display(Name = "Background Image")]
        public byte[] BGImage { get; set; }
        public string BGContentType { get; set; }

        //Public URL of Trailer
        [Display(Name  = "Trailer URL")]
        public string Trailer { get; set; }

        //init the list ahead of the inserts

        public MovieRating Rating { get; set; }

        public ICollection<Cast> Cast { get; set; } = new HashSet<Cast>();  //Creates a Foreign Key
        public ICollection<Crew> Crew { get; set; } = new HashSet<Crew>();  //Creates a Foreign Key                                                                 

    }
}                                                                                                                         
