using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinema
{
   public  class StudentTicket:Ticket
    {
       public StudentTicket() { }
       public StudentTicket(int Discount)
       {
           this.Discount = Discount;
       }
       //学生票的折扣
        private int Discount;

        public int Discount1
        {
            get { return Discount; }
            set { Discount = value; }
        }
       //重写父类计算票价的方法
        public override void CalcPrice()
        {
            this.Price1 = this.ScheduleItem1.Movie1.Price1 * Discount1 / 10;
        }
       //重写父类显示当前票价信息的方法
        public override void Print()
        {
            base.Print();
        }
   }
}
