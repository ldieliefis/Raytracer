using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template
{
    class scene
    {
        List<primitive> primitives;
        List<light> lightsources;
        /*
        intersection Intersect()
        {
            // loop over primitives and return closest intersection
            return intersection;
        }
        */
        public void addsphere(sphere bol)
        {
            // voegt een sphere toe aan de lijst van primitives
            primitives.Add(bol);
        }

        public void addlightsource(light lichtbron)
        {
            // voegt een lichtbron toe aan de lijst van lightsources
            lightsources.Add(lichtbron);
        }
    }
}
