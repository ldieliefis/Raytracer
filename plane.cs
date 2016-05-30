using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template
{
    class plane : primitive
    {
        int[] normal;
        int distancetoorigin;

        public plane(int[] n, int d)
        {
            normal = n;
            distancetoorigin = d;
        }
    }
}
