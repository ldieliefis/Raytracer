using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template
{
    class scene
    {
        List<primitive> primitives = new List<primitive>();
        List<light> lightsources = new List<light>();

        /*
        intersection Intersect()
        {
            // loop over primitives and return closest intersection
            return intersection;
        }
        */
        public scene() { }

        public List<primitive> getprimitives()
        {
            return primitives;
        }
        public List<light> getlightsources()
        {
            return lightsources;
        }
        public void addprimitive(primitive bol)
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
