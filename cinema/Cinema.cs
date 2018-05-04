using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinema
{
   public  class Cinema
    {
       public Cinema() { }
       public Cinema(Dictionary<string, Seat> item, List<Ticket> SoldTickets, Schedule Schedule) 
       {
           this.item = item;
           this.SoldTickets = SoldTickets;
           this.Schedule = Schedule;
       }
       //座位集合属性
       Dictionary<string, Seat> item = new Dictionary<string, Seat>();
       //放映计划
       private Schedule Schedule=new Schedule();
       //已售出电影票的集合
       List<Ticket> SoldTickets = new List<Ticket>();

       public List<Ticket> SoldTickets1
       {
           get { return SoldTickets; }
           set { SoldTickets = value; }
       }
       public Schedule Schedule1
       {
           get { return Schedule; }
           set { Schedule = value; }
       }
       public Dictionary<string, Seat> Item
        {
            get { return item; }
            set { item = value; }
        }
    }
}
