using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace cinema
{
   public class Seat
    {
       public Seat() { }
       public Seat(string SeatNum, Color color)
       {
           this.SeatNum = SeatNum;
           this.Color = color;
       }

      
        //座位号
        private string SeatNum;

        public string SeatNum1
        {
            get { return SeatNum; }
            set { SeatNum = value; }
        }
        //颜色
        private Color Color;
        public Color Color1
        {
            get { return Color; }
            set { Color = value; }
        }
    }
}
