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
            primitive eerstebol = new sphere(250, new int[] { 0, 0, 0 });
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
                sphere eerstebol = (sphere)primitieven[0];
                screen.Circle(eerstebol.position[0], eerstebol.position[2], eerstebol.radius, CreateColor(255, 255, 255));
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
