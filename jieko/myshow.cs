using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jieko
{
   public class myshow:Inc1
    {
       public void show() { }

       void Inc1.show()
       {
           throw new NotImplementedException();
       }
    }
}
