using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dianshiji
{
   public class Remote
    {
       //开机
       public void TurnOn(Tv tv) 
       {
           tv.Opne();
       }


       //关机
       public void TurnOff(Tv tv) 
       {
           tv.TrunOff();
       }


       //换台
       public void Charend(Tv tv) 
       {
           Console.WriteLine(" 输入电视频道");
           int num = Convert.ToInt32(Console.ReadLine());
           tv.Chareur(num);
       }
    }
}
