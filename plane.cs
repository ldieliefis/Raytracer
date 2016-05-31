using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template
{
    public class plane : primitive
    {
        public float[] normal;
        public float distancetoorigin;

        public plane(float[] n, float d)
        {
            normal = n;
            distancetoorigin = d;
        }
    }
}
