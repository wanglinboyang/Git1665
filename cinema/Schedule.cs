using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace cinema
{
   public  class Schedule
    {
       public Schedule() { }
       public Schedule(Dictionary<string, ScheduleItem> items)
       {
           this.item = items;
       }
       //01.定义一个和当前放映计划对应的   【放映场次的集合】
         Dictionary<string, ScheduleItem> item = new Dictionary<string, ScheduleItem>();

        public Dictionary<string, ScheduleItem> Item
        {
            get { return item; }
            set { item = value; }
        }
       //02.定义一个解析XML文件的方法
        public void LoadItems()
        {
            XmlDocument MyXml = new XmlDocument();
            MyXml.Load("ShowList.xml");
            XmlNode root = MyXml.DocumentElement;
            foreach (XmlNode item in root.ChildNodes)
            {
                Movie movie = new Movie();
                //一个item代表一个movie
                movie.MovieName1 = item["Name"].InnerText;
                movie.Poster1 = item["Poster"].InnerText;
                movie.Driector1 = item["Director"].InnerText;
                movie.Actor1 = item["Actor"].InnerText;
                //电影类型  xml读取出来的是没有类型的，都是字符串，转换成枚举
                movie.MovieType1 = (MovieType)Enum.Parse(typeof(MovieType), item["Type"].InnerText);
                movie.Price1 = Convert.ToInt32(item["Price"].InnerText);
                foreach (XmlNode schedule in item["Schedule"].ChildNodes)
                {
                   //一个schedule代表一个放映场次
                    ScheduleItem sitem = new ScheduleItem();
                    sitem.Time1 = schedule.InnerText;
                    sitem.Movie1 = movie;
                    Item.Add(sitem.Time1, sitem);
                }
            }
        }
    }
}
