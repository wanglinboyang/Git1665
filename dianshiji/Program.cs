using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dianshiji
{
    class Program
    {
        static void Main(string[] args)
        {
            Tv tv = new Tv();


            Remote rm = new Remote();
            rm.TurnOn(tv);
            rm.Charend(tv);
            rm.TurnOff(tv);
            Console.ReadLine();
        }
    }
}
