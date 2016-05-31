using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template
{
    class plane : primitive
    {
        public int[] normal;
        public int distancetoorigin;

        public plane(int[] n, int d)
        {
            normal = n;
            distancetoorigin = d;
        }
    }
}
