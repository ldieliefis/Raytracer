using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template
{
    class sphere : primitive
    {
        public float radius;
        public float[] position;

        public sphere() { }

        public sphere(float rad, float[] pos)
        {
            radius = rad;
            position = pos; 
        }
    }
}
