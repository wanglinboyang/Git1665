using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jixuanji
{
   public  class Calculator
    {
       public static Operation gets(string oper)
       {
           Operation op = null;
           switch (oper) 
                {
                    case "+":
                        {
                            op = new OperationAdd();
                            break;
                        }
                    case "-":
                        {
                            op = new jian();
                            break;
                        }
                    case "*":
                        {
                            op = new cheng();
                            break;
                        }
                    case "/":
                        {
                            op = new OperationDiv();
                            break;
                        }
                }
           return op;
       }
    }
}
