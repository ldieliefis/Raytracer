using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template
{
    class raytracer
    {
        scene scene;
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
            sphere eerstebol = new sphere(10, new[] { 0, 0, 0 });
            // voeg bol toe aan list
            //scene.addsphere(eerstebol);
        }
        // tick: renders one frame
        public void Tick()
        {
            screen.Clear(0);
            screen.Print( "Dit is raytracer, niet game! Kusje, Laura", 2, 2, 0xffffff );
            
            // TODO teken hier de spheres: links in 3d en rechts in 2d bovenaanzicht
        }
    }

}
