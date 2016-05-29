using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template
{
    class sphere : primitive
    {
        public int radius;
        public int[] position;

        public sphere() { }

        public sphere(int rad, int[] pos)
        {
            radius = rad;
            position = pos; 
        }
    }
}
