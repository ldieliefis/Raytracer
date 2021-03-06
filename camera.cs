﻿using System;

namespace template
{
    public class camera
    {
        // membervariabelen
        public float[] location = { 0, 0, 0 };
        public float[] direction = { 0, 0, -1 };
        plane screenplane;// = new plane(new int[] { 0, 0, 1 },1);

        // function: update screenplane corners if camera position or direction is modified
        public camera(float[] l, float[] dir, float distancetoorigin, float[] normal)
        {
            location = l;
            direction = dir;
            screenplane = new plane(normal, distancetoorigin);
        }

        public plane getscreenplane()
        {
            return screenplane;
        }
    }
}