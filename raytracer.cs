using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template
{
    class raytracer
    {
        scene scene = new scene();
        camera camera;
        public Surface screen;

        void Render()
        {
            // use camera to loop over pixels en generate 
            // ray for each pixel, to find nearest intersection
            // visualize result by plotting pixel
        }

        public void Init()
        {
            // maak een bol
            primitive eerstebol = new sphere(10, new int[] { 0, 0, 0 });
            // voeg bol toe aan list
            scene.addprimitive(eerstebol);
        }
        // tick: renders one frame
        public void Tick()
        {
            screen.Clear(0);
            screen.Print( "Dit is raytracer, niet game! Kusje, Laura", 2, 2, 0xffffff );

            List<primitive> primitieven = scene.getprimitives();
            if (primitieven[0].GetType().Equals(typeof(sphere)))
            {
                sphere eerstebol = new sphere();
                eerstebol = (sphere)primitieven[0];
                for (int x = eerstebol.position[0] - eerstebol.radius; x < eerstebol.position[0] + eerstebol.radius; x++)
                {
                        int y = (int)Math.Sqrt( - Math.Pow(x,2) + Math.Pow(eerstebol.radius, 2)) + eerstebol.position[2];
                        int location = x + y + screen.height/2 * screen.width;    
                    screen.pixels[location] = CreateColor(255, 255, 255);
                }
            }
            else {
                primitive eersteding = primitieven[0];
            }

            
            
            // TODO teken hier de spheres: links in 3d en rechts in 2d bovenaanzicht
        }
        int CreateColor(int red, int green, int blue)
        { return (red << 16) + (green << 8) + blue; }
    }

}
