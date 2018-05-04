using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinema
{
   public class Movie
    {
       public Movie() { }
       public Movie(string MovieName, string Poster, string Driector, string Actor, MovieType MovieType, int Price) 
       {
           this.MovieName = MovieName;
           this.Poster = Poster;
           this.Driector = Driector;
           this.Actor = Actor;
           this.MovieType = MovieType;
           this.Price = Price;
       }
        //电影名
        private string MovieName;
        //海报图片名
        private string Poster;
        //导演名
        private string Driector;
        //主演
        private string Actor;
        //电影类型
        private MovieType MovieType;
       //定价
        private int Price;

        public int Price1
        {
            get { return Price; }
            set { Price = value; }
        }
        internal MovieType MovieType1
        {
            get { return MovieType; }
            set { MovieType = value; }
        }
        public string Actor1
        {
            get { return Actor; }
            set { Actor = value; }
        }

        public string Driector1
        {
            get { return Driector; }
            set { Driector = value; }
        }
       
        public string Poster1
        {
            get { return Poster; }
            set { Poster = value; }
        }
        public string MovieName1
        {
            get { return MovieName; }
            set { MovieName = value; }
        }

    }
}
