using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Collections;
namespace MovieBox.Models
{
    public class Movie
    {
        [Key]
        public int Movie_ID { get; set; }


        public string Title { get; set; }

        public string Director { get; set; }

        public DateTime ReleaseDate { get; set; }


        public string Genre { get; set; }


        public string Price { get; set; }


        public virtual Actor Actor { get; set; }

        public virtual Sale Sale { get; set; }


    }
}