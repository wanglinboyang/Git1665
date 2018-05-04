using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dianshiji
{
   public class Tv
    {
       private bool isOn = false;
       //开机
       public void Opne()
       {
           if (isOn)
           {
               Console.WriteLine("电视机已开");
           }
           else 
           {
               Console.WriteLine("成功打开电视机");
               isOn = true;
           }
       }


       //关机
       public void TrunOff() 
       {
           if (isOn)
           {
               Console.WriteLine("正在关机");
               isOn = false;
           }
           else 
           {
               Console.WriteLine("电视机已关闭");
           }
       }


       //换台

       public void Chareur(int Num)
       {
           if (isOn) 
           {
               Console.WriteLine("正在切换第{0}",Num);
           }
       }
    }
}
