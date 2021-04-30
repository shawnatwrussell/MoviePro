using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MoviePro.Enums
{
    public enum MovieRating
    {
        G,
        PG,
        [Display(Name = "PG-13")]
        PG13, //PG-13 for display
        R,
        [Display(Name = "NC-17")]
        NC17,  //NC-17
        NR

    }
}
