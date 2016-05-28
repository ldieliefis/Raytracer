using System;

namespace template
{
    public class camera
    {
        // membervariabelen
        int[] location = { 0, 0, 0 };
        int[] direction = { 0, 0, -1 };
        int[,] screenplane = { { -1, 1, 0 }, { 1, 1, 0 }, { 1, -1, 0 }, { -1, -1, 0 } };

        // function: update screenplane corners if camera position or direction is modified
        public camera()
        {

        }
    }
}