using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using MovieBox.DAL;

namespace MovieBox
{
    /// <summary>
    /// Summary description for MovieService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
     [System.Web.Script.Services.ScriptService]
    public class MovieService : System.Web.Services.WebService
    {
        private MovieContext db = new MovieContext();

        [WebMethod]
        public string[] GetMovieByTitle(string namePart)
        {
            List<string> movies = new List<string>();

            if (namePart != "")
            {
                foreach (var movie in db.Movies
                                        .Where(a => a.Title.Contains(namePart))
                                        .ToList())
                {
                    movies.Add(movie.Title);
                }
            }
            return movies.ToArray();
        }

        [WebMethod]
        public string[] GetActorByName(string namePart)
        {
            List<string> actors = new List<string>();

            if (namePart != "")
            {
                foreach (var actor in db.Actors
                                        .Where(a => a.Name.Contains(namePart))
                                        .ToList())
                {
                    actors.Add(actor.Name);
                }
            }
            return actors.ToArray();
        }
    }
}