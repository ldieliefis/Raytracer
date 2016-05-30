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
            // maak de spheres
            primitive eerstebol = new sphere(100, new int[] { 0, 0, -100 });
            primitive tweedebol = new sphere(100, new int[] { 200, 0, -100 });
            primitive derdebol = new sphere(100, new int[] { -200, 0, -100 });
            primitive vierdebol = new sphere(75, new int[] { 0, 0, 200 });
            primitive vijfdebol = new sphere(50, new int[] { -100, 0, 125 });
            //primitive vierkant = new square(100, 100, new int[] { 0, 0, 0 });
            // voeg spheres toe aan list
            scene.addprimitive(eerstebol);
            scene.addprimitive(tweedebol);
            scene.addprimitive(derdebol);
            scene.addprimitive(vierdebol);
            scene.addprimitive(vijfdebol);
            //scene.addprimitive(vierkant);
            render = new Surface(512, 512);
            debug = new Surface(512,512);
        }
        // tick: renders one frame
        public void Tick()
        {
            screen.Clear(0);
            render.Print( "Dit is raytracer, niet game! Kusje, Laura", 2, 2, 0xffffff );

            List<primitive> primitieven = scene.getprimitives();
            int teller = 0;
            int color;

            foreach(primitive primitieve in primitieven)
            {
                if (teller > 3)
                    teller = 0;
                switch(teller)
                {
                    case 0:
                        color = CreateColor(255, 0, 0); // red
                        break;
                    case 1:
                        color = CreateColor(0, 255, 0); // green
                        break;
                    case 2:
                        color = CreateColor(0, 0, 255); // blue
                        break;
                    case 3:
                        color = CreateColor(255, 0, 255); // pink??
                        break;
                    default:
                        color = CreateColor(255, 255, 255); // white
                        break;                        
                }
            if (primitieve.GetType().Equals(typeof(square)))
            {

                square vierkant = (square)primitieve;
                debug.Plane(vierkant.position,vierkant.width,vierkant.height, color);
                    teller++;

            }
            else if (primitieve.GetType().Equals(typeof(sphere)))
                {
                    sphere bol = (sphere)primitieve;
                    debug.Circle(bol.position[0], bol.position[2], bol.radius, color);
                    teller++;
                }
            }
            render.CopyTo(screen, 0, 0);
            debug.CopyTo(screen, 512, 0);
            
            
            // TODO teken hier de spheres: links in 3d en rechts in 2d bovenaanzicht
        }

      

    }

}
