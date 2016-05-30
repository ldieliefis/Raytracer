using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template
{
    class square : primitive
    {
        public int width;
        public int height;
        public int[] position;

        public square(int w, int h, int[] pos)
        {
            width = w;
            height = h;
            position = pos;
        }
    }
}
