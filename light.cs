using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template
{
    class light
    {
        public float[] location;
        public float[] intensity;

        public light(float[] l, float[] i)
        {
            location = l;
            intensity = i;
        }
    }
}
