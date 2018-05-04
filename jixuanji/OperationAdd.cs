using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jixuanji
{
   public  class OperationAdd:Operation
    {
       public override double GerResult()
       {
           double result = NumberA + NumberB;
           return result;
       }
    }
}
