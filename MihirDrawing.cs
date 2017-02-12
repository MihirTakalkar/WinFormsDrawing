using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MihirDrawing
{
    public partial class MihirDrawing : Form
    {
        Graphics gfx;
        Bitmap bitmap;
        Face face;

        //test github change
        public MihirDrawing()
        {
            InitializeComponent();
            bitmap = new Bitmap(canvas.Width, canvas.Height);
            gfx = Graphics.FromImage(bitmap);
            face = new Face();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            face.Draw(gfx);
            //gfx.DrawRectangle(Pens.Coral, 10, 20, 300, 200);
            //gfx.FillEllipse(Brushes.White, 42, 27, 265, 230);
            //gfx.FillEllipse(Brushes.Yellow, 93, 74, 50, 50);
            //gfx.FillEllipse(Brushes.Yellow, 204, 79, 50, 50);
            //gfx.DrawArc(Pens.Green, 145, 100, 100, 100, 50, 90);
            //gfx.FillEllipse(Brushes.Green, 106, 91, 7, 7);
            //gfx.FillEllipse(Brushes.Green, 125, 90, 7, 7);
            //gfx.DrawArc();

            gfx.FillEllipse(Brushes.Yellow, 370, 94, 100, 100);
            gfx.FillEllipse(new SolidBrush(BackColor), 404, 95, 100, 100);

            canvas.Image = bitmap;
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            locationLabel.Text = e.Location.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //erase
            gfx.Clear(BackColor);

            //update
            face.x += 10;


            //draw
            face.Draw(gfx);
            canvas.Image = bitmap;
        }

        private void MihirDrawing_Load(object sender, EventArgs e)
        {

        }
    }
}
