using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinema
{
   public  class Ticket
    {
       public Ticket() { }
       public Ticket(ScheduleItem scheduleItem, Seat seat, int Price) 
       {
           this.ScheduleItem = scheduleItem;
           this.Seat = seat;
           this.Price = Price;
       }
       //放映场次
        private ScheduleItem ScheduleItem;
       //所属座位对象
        private Seat Seat;
       //票价
        private int Price;

        public int Price1
        {
            get { return Price; }
            set { Price = value; }
        }
        public Seat Seat1
        {
            get { return Seat; }
            set { Seat = value; }
        }

        public ScheduleItem ScheduleItem1
        {
            get { return ScheduleItem; }
            set { ScheduleItem = value; }
        }
       //计算票价
        public virtual void CalcPrice()
        {
            this.Price = ScheduleItem.Movie1.Price1;
        }
        //打印票价
        public virtual void Print()
        {

        }
        //显示当前售出的票价
        public virtual void Show()
        {

        }
   }
}
