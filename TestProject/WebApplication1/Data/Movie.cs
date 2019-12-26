
using System.Collections.Generic;

namespace WebApplication1.Data
{
    public class Movie
    {
        public string Name { get; set; }

        public string Image { get; set; }
        public string Summary { get; set; }
        public Movie(string _name, string _image, string _summary)
        {
            Name = _name;
            Image = _image;
            Summary = _summary;

        }
    }

    public class MovieService
    {
        public  List<Movie> Movies { get; set; }
        public MovieService()
        {
            Movies = new List<Movie>();

            Movies.Add(new Movie("Star Wars: The Rise of Skywalker", "https://image.tmdb.org/t/p/w600_and_h900_bestv2/db32LaOibwEliAmSL2jjDF6oDdj.jpg", "The surviving Resistance faces the First Order once again as the journey of Rey, Finn and Poe Dameron continues. With the power and knowledge of generations behind them, the final battle begins."));
            Movies.Add(new Movie("Ad Astra", "https://image.tmdb.org/t/p/w185_and_h278_bestv2/xBHvZcjRiWyobQ9kxBhO6B2dtRI.jpg", "The near future, a time when both hope and hardships drive humanity to look to the stars and beyond. While a mysterious phenomenon menaces to destroy life on planet Earth, astronaut Roy McBride undertakes a mission"));
            Movies.Add(new Movie("Joker","https://image.tmdb.org/t/p/w185_and_h278_bestv2/udDclJoHjfjb8Ekgsd4FDteOkCU.jpg","During the 1980s, a failed stand-up comedian is driven insane and turns to a life of crime and chaos in Gotham City while becoming an infamous psychopathic crime figure."));

            Movies.Add(new Movie("Jumanji: The Next Level", "https://image.tmdb.org/t/p/w600_and_h900_bestv2/db32LaOibwEliAmSL2jjDF6oDdj.jpg", "As the gang return to Jumanji to rescue one of their own, they discover that nothing is as they expect. The players will have to brave parts unknown and unexplored in order to escape the world’s most dangerous game."));



        }
    }
}
