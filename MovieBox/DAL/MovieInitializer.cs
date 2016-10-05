using System;
using System.Collections.Generic;
using MovieBox.Models;


namespace MovieBox.DAL
{
    public class MovieInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<MovieContext>
    {
        protected override void Seed(MovieContext context)
        {
            var Movie = new List<Movie>
            {
             new Movie{Title="Spectre",Director="Sam Mendes", ReleaseDate=DateTime.Parse("2015-10-26"),Genre="Action",Price=("€25")},
             new Movie{Title="Legend",Director="Brian Helgeland", ReleaseDate=DateTime.Parse("2015-09-09"),Genre="Action",Price=("€24.99")},
             new Movie{Title="Creed",Director="Ryan Coogler", ReleaseDate=DateTime.Parse("2015-11-25"),Genre="Action",Price=("€26")},
             new Movie{Title="The Man from U.N.C.L.E.",Director="Guy Ritchie", ReleaseDate=DateTime.Parse("2015-08-14"),Genre="Action",Price=("€22")},
             new Movie{Title="Ant-Man",Director="Peyton Reed", ReleaseDate=DateTime.Parse("2015-07-17"),Genre="Action",Price=("€20")},
             new Movie{Title="The Martian",Director="Ridley Scott", ReleaseDate=DateTime.Parse("2015-09-30"),Genre="Drama",Price=("€24")},
             new Movie{Title="Trainwreck",Director="Judd Apatow", ReleaseDate=DateTime.Parse("2015-08-14"),Genre="Comedy",Price=("€19.99")},
             new Movie{Title="Vacation ",Director="John Francis Daley, Jonathan M. Goldstein", ReleaseDate=DateTime.Parse("2015-08-21"),Genre="Comedy",Price=("€17.99")},
             new Movie{Title="Birdman",Director="Alejandro González Iñárritu", ReleaseDate=DateTime.Parse("2014-10-17"),Genre="Drama",Price=("€20.99")},
             new Movie{Title="Boyhood",Director="Richard Linklater", ReleaseDate=DateTime.Parse("2014-07-11"),Genre="Drama",Price=("€14.99")},
             new Movie{Title="The Grand Budapest Hotel",Director="Wes Anderson", ReleaseDate=DateTime.Parse("2014-03-07"),Genre="Adventure, Comedy, Drama",Price=("€20")},
             new Movie{Title="The Lego Movie",Director="Phil Lord, Christopher Miller", ReleaseDate=DateTime.Parse("2014-02-14"),Genre="Animation, Action, Adventure",Price=("€14.99")},
             new Movie{Title="Interstellar",Director="Christopher Nolan", ReleaseDate=DateTime.Parse("2014-11-07"),Genre="Drama, Sci-Fi ",Price=("€24.99")},
             new Movie{Title="Gone Girl",Director="David Fincher", ReleaseDate=DateTime.Parse("2014-10-02"),Genre="Crime, Drama, Mystery",Price=("€20")},
             new Movie{Title="Whiplash",Director="Damien Chazelle", ReleaseDate=DateTime.Parse("2015-01-16"),Genre="Drama, Music",Price=("€15.99")},
             new Movie{Title="Guardians of the Galaxy",Director="James Gunn", ReleaseDate=DateTime.Parse("2014-07-31"),Genre="Action, Adventure, Sci-Fi",Price=("€19.99")},
                        };
            Movie.ForEach(s => context.Movies.Add(s));
            context.SaveChanges();

            var Actor = new List<Actor>
            {
                new Actor{Name="Daniel Craig", Age="47"},
                new Actor{Name="Tom Hardy", Age="38"},
                new Actor{Name="Henry Cavill", Age="32"},
                new Actor{Name="Christina Applegate", Age="44"},
                new Actor{Name="Ed Helms", Age="41"},
                new Actor{Name="Paul Rudd", Age="46"},
                new Actor{Name="Christoph Waltz", Age="59"},
                new Actor{Name="Robert Downey Jr.", Age="50"},
                new Actor{Name="Jamie Foxx", Age="47"},
                new Actor{Name="Hugh Jackman", Age="47"},
                new Actor{Name="Vin Diesel", Age="48"},
                new Actor{Name="Michael Fassbender", Age="38"},
                 };
            Actor.ForEach(s => context.Actors.Add(s));
            context.SaveChanges();

            var Sale = new List<Sale>
            {
                new Sale {MovieName = "Grown Up", Price=("€10") },
                new Sale {MovieName = "Skyfall", Price=("€15") },
                new Sale {MovieName = "Mission: Impossible – Rogue Nation", Price=("€13.99") },
                new Sale {MovieName = "Ted", Price=("€11") },
                new Sale {MovieName = "Gravity", Price=("€12") },
                new Sale {MovieName = "Man of Steel", Price=("€18") },
                new Sale {MovieName = "Iron Man 3", Price=("€17") },
                new Sale {MovieName = "American Hustle", Price=("€16") },
                new Sale {MovieName = "Furious 6", Price=("€15") },
                new Sale {MovieName = "Thor: The Dark World", Price=("€17") },
                new Sale {MovieName = "The Wolverine", Price=("€12") },
                new Sale {MovieName = "Anchorman 2: The Legend Continues", Price=("€12") },
                };
            Sale.ForEach(s => context.Sales.Add(s));
            context.SaveChanges();

            var ComingSoon = new List<ComingSoon>
            {
             new ComingSoon{Title="Ride Along 2",Director="Tim Story", ReleaseDate=DateTime.Parse("2016-01-15"),Genre="Comedy"},
             new ComingSoon{Title="kung fu panda 3",Director="Jennifer Yuh Nelson, Alessandro Carloni", ReleaseDate=DateTime.Parse("2016-01-29"),Genre="Comedy"},
             new ComingSoon{Title="Deadpool",Director="Tim Miller", ReleaseDate=DateTime.Parse("2016-02-04"),Genre="Action"},
             new ComingSoon{Title="Zoolander 2",Director="Ben Stiller", ReleaseDate=DateTime.Parse("2016-02-12"),Genre="Comedy"},
             new ComingSoon{Title="London Has Fallen",Director="Babak Najafi", ReleaseDate=DateTime.Parse("2016-01-21"),Genre="Action, Thriller"},
             new ComingSoon{Title="Batman v Superman: Dawn of Justice",Director="Zack Snyder", ReleaseDate=DateTime.Parse("2016-03-25"),Genre="Action"},
             new ComingSoon{Title="Captain America: Civil War",Director="Kevin Feige", ReleaseDate=DateTime.Parse("2016-04-29"),Genre="Action, Sci-Fi, Thriller"},
             new ComingSoon{Title="X-Men: Apocalypse",Director="Bryan Singer", ReleaseDate=DateTime.Parse("2016-05-19"),Genre="Action, Fantasy"},
             new ComingSoon{Title="Suicide Squad ",Director="David Ayer", ReleaseDate=DateTime.Parse("2016-08-05"),Genre="Action"},
             new ComingSoon{Title="Now You See Me 2 ",Director="Jon M. Chu", ReleaseDate=DateTime.Parse("2016-06-10"),Genre="Action, Comedy, Thriller"},
                        };
            ComingSoon.ForEach(s => context.ComingSoon.Add(s));
            context.SaveChanges();
        }
    }
}