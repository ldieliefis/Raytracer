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
        public Surface debug;
        public Surface render;


        int CreateColor(int red, int green, int blue)
        { return (red << 16) + (green << 8) + blue; }

        void Render()
        {
            // use camera to loop over pixels en generate 
            // ray for each pixel, to find nearest intersection
            // visualize result by plotting pixel
        }

        public void Init()
        {
            // maak een bol
            primitive eerstebol = new sphere(100, new int[] { 0, 0, 0 });
            primitive vierkant = new square(100, 100, new int[] { 0, 0, 0 });
            // voeg bol toe aan list
            scene.addprimitive(eerstebol);
            scene.addprimitive(vierkant);
            render = new Surface(512, 512);
            debug = new Surface(512,512);
        }
        // tick: renders one frame
        public void Tick()
        {
            screen.Clear(0);
            render.Print( "Dit is raytracer, niet game! Kusje, Laura", 2, 2, 0xffffff );

            List<primitive> primitieven = scene.getprimitives();
            
            if (primitieven[0].GetType().Equals(typeof(sphere)))
            {
                //square vierkant = (square)primitieven[1];
                //debug.Square(vierkant.position,vierkant.width,vierkant.height, CreateColor(255,255,255));
                sphere eerstebol = (sphere)primitieven[0];
                debug.Circle(eerstebol.position[0], eerstebol.position[2], eerstebol.radius, CreateColor(255, 255, 255));
                //call square function out of surface
            }
            else {
                primitive eersteding = primitieven[0];
            }

            render.CopyTo(screen, 0, 0);
            debug.CopyTo(screen, 512, 0);
            
            
            // TODO teken hier de spheres: links in 3d en rechts in 2d bovenaanzicht
        }

      

    }

}
