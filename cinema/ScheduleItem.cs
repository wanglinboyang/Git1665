using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinema
{
   public  class ScheduleItem
    {
       public ScheduleItem() { }
       public ScheduleItem(string Time, Movie Movie) 
       {
           this.Time = Time;
           this.Movie = Movie;
       }
       //放映时间属性
        private string Time;
       //本场所放映电影属性
        private Movie Movie;

        public Movie Movie1
        {
            get { return Movie; }
            set { Movie = value; }
        }
        public string Time1
        {
            get { return Time; }
            set { Time = value; }
        }
    }
}
