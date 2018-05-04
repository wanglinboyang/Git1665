using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinema
{
   public  class FreeTicket:Ticket
    {
       public FreeTicket() { }
       public FreeTicket(string CustomerName) 
       {
           this.CustomerName = CustomerName;
       }
       //获得赠票者的名字属性
       private string CustomerName;

       public string CustomerName1
       {
           get { return CustomerName; }
           set { CustomerName = value; }
       }
       //重写父类计算票价的方法
       public override void CalcPrice()
       {
           base.CalcPrice();
       }
       //重写父类打印售票信息的方法
       public override void Print()
       {
           base.Print();
       }
       //重写父类显示当前售出票价的信息方法
       public override void Show()
       {
           base.Show();
       }
   }
}
