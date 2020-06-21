using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5_Lab
{
    class Movement
    {
       private int x = 250;
        private int y = 200;
        private static int distance ;
        List<string> history = new List<string>();


        public int X
        {
           get { return x; }
           set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public int Distance
        {
            get { return distance; }
            set { distance = value; }
        }


        public Movement(int xaxis, int yaxis)
        {
            x = xaxis;
            y = yaxis;
        }
        public int DistanceChange(int newdistance)
        {
            history.Add(newdistance.ToString());
            return this.Distance = newdistance;

        }
        
           
            

        }











    
}
