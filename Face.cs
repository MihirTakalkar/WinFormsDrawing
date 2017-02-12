using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MihirDrawing
{
    class Face
    {
        public int x = 10;

        public void Draw(Graphics gfx)
        {

            gfx.FillEllipse(Brushes.White, x + 42, 27, 265, 230);
            gfx.FillEllipse(Brushes.Yellow, 93, 74, 50, 50);
            gfx.FillEllipse(Brushes.Yellow, 204, 79, 50, 50);
            gfx.DrawArc(Pens.Green, 145, 100, 100, 100, 50, 90);
            gfx.FillEllipse(Brushes.Green, 106, 91, 7, 7);
            gfx.FillEllipse(Brushes.Green, 125, 90, 7, 7);
        }
        public Face ()
        {
            
        }
    }
}
