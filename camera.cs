using System;

namespace template
{
    public class camera
    {
        // membervariabelen
        public int[] location = { 0, 0, 0 };
        int[] direction = { 0, 0, -1 };
        plane screenplane;// = new plane(new int[] { 0, 0, 1 },1);

        // function: update screenplane corners if camera position or direction is modified
        public camera(int[] l, int[] d, int distancetoorigin, int[] normal)
        {
            location = l;
            direction = d;
            screenplane = new plane(normal, distancetoorigin);
        }
    }
}