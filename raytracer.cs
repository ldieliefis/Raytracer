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
            primitive eerstebol = new sphere(1, new float[] { 0, 0, -1 });
            primitive tweedebol = new sphere(1, new float[] { 2, 0, -1 });
            primitive derdebol = new sphere(1, new float[] { -2, 0, -1 });
            primitive vierdebol = new sphere(0.75f, new float[] { 0, 0, 0 });
            primitive vijfdebol = new sphere(0.50f, new float[] { -1, 0, 1.25f });
            plane cameraplane = new plane(new float[] { 0,0,-1}, 3);
            camera = new camera(new float[] { 0, 0, 2 }, cameraplane.normal, cameraplane.distancetoorigin, cameraplane.normal);
            light lightsource = new light(new float[] { 0, 0, 0 }, new float[] { 1f, 1f, 1f });
            // voeg spheres toe aan list
            scene.addprimitive(eerstebol);
            scene.addprimitive(tweedebol);
            scene.addprimitive(derdebol);
            scene.addprimitive(vierdebol);
            scene.addprimitive(vijfdebol);
            scene.addprimitive(cameraplane);
            scene.addlightsource(lightsource);
            render = new Surface(512, 512);
            debug = new Surface(512,512);
        }
        // tick: renders one frame
        public void Tick()
        {
            screen.Clear(0);
            render.Print( "Dit is raytracer, niet game! Kusje, Laura", 2, 2, 0xffffff );

            // geef camera weer op scherm
            //debug.Box(camera.location[0], camera.location[2], camera.location[0] + 0.1f, camera.location[2] + 0.1f, CreateColor(255,255,255));

            List<primitive> primitieven = scene.getprimitives();
            int color;
            int teller = 0;

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
            if (primitieve.GetType().Equals(typeof(plane)))
            {

                plane screenplane = (plane)primitieve;
                    // vanuit positie camera en richting camera en FOV (hoek) en afstand camera tot scherm
                    // (FOV is nu 90)
                    // bepaal je de lengte van het scherm.
                    float[] middenscreenplane = new float[3];
                    middenscreenplane = nieuwelocatie(camera.location, screenplane.distancetoorigin, camera.direction);
                    float lengtehalfscherm = (float)(Math.Tan(45) * screenplane.distancetoorigin);
                    float[] punt1 = nieuwelocatie(middenscreenplane, lengtehalfscherm, nieuwerichting(camera.direction, 1));
                    float[] punt2 = nieuwelocatie(middenscreenplane, lengtehalfscherm, nieuwerichting(camera.direction, 0));

                    debug.Line(punt1[0], punt1[2], punt2[0], punt2[2], CreateColor(0, 255, 0));

                    // op basis van de lengte van het scherm en de normaal (of de kijkrichting) bepaal je
                    // de uiterste punten van de plane, zowel x, y als z
                    // met x en z teken je de plane als een lijn op je scherm
                    //debug.Plane(plane.position,plane.width,plane.height, color);
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

        private float[] nieuwelocatie(float[] oudelocatie, float afstand, float[] richting)
        {
            float[] nieuwelocatie = new float[3];
            nieuwelocatie[0] = oudelocatie[0] + richting[0] * afstand;
            nieuwelocatie[1] = oudelocatie[1] + richting[1] * afstand;
            nieuwelocatie[2] = oudelocatie[2] + richting[2] * afstand;

            return nieuwelocatie;
        }
      
        private float[] nieuwerichting(float[] ouderichting, int bovenonder) // boven = 1
        {
            float[] nieuwerichting = new float[3];
            if(bovenonder == 0)
            {
                nieuwerichting[0] = ouderichting[2] * -1;
                nieuwerichting[1] = 0;
                nieuwerichting[2] = ouderichting[0];
            }
            else
            {
                nieuwerichting[0] = ouderichting[2];
                nieuwerichting[1] = 0;
                nieuwerichting[2] = ouderichting[0] * -1;
            }
            return nieuwerichting;
        }

    }

}
