using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Collections;

namespace MovieBox.Models
{
    public class Sale
    {
        [Key]
        public int Sale_ID { get; set; }



        public string MovieName { get; set; }

        public string Price { get; set; }


        public virtual ICollection<Movie> Movie { get; set; }
    }
}