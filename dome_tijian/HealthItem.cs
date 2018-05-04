using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dome_tijian
{
    //体检项目  （名字   描述   价格）
   public  class HealthItem
    {
       public HealthItem() { }
       public HealthItem(string name, string desc, int price) 
       {
           this.healthItemName = name;
           this.healthItemDesc = desc;
           this.heathItemPrice = price;
       }
       private string healthItemName;

       public string HealthItemName
       {
           get { return healthItemName; }
           set { healthItemName = value; }
       }


       private string healthItemDesc;

       public string HealthItemDesc
       {
           get { return healthItemDesc; }
           set { healthItemDesc = value; }
       }



       private int heathItemPrice;

       public int HeathItemPrice
       {
           get { return heathItemPrice; }
           set { heathItemPrice = value; }
       }   
   }
}
