using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine:Figure
    {
        
        public VerticalLine(int x, int yLower, int yUpper, char sym )
        {
            plist = new List<Point>();
            for (int y = yLower; y <= yUpper; y++)
            {
                Point p = new Point(x, y, sym);
                plist.Add(p);
            }
        }
      
    }
}
