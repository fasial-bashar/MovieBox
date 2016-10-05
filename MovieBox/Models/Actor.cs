using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Collections;

namespace MovieBox.Models
{
    public class Actor
    {
        [Key]
        public int Actor_ID { get; set; }


        public string Name { get; set; }


        public string Age { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }


    }
}