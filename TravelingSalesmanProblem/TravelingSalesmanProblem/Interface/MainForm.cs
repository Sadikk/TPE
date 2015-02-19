using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelingSalesmanProblem.Core;
using TravelingSalesmanProblem.Engine;


namespace TravelingSalesmanProblem.Interface
{
    public partial class MainForm : Form
    {

        Bitmap bmp = null;
        List<Engine.Point> lp = new List<Engine.Point>();
        Core.Core c;

        public MainForm()
        {
            InitializeComponent();
              
        }

        public void DrawPoint(List<Engine.Point> lp, Color color)
        {
            bmp = new Bitmap(panel1.Width, panel1.Height);
            panel1.BackgroundImage = (Image)bmp;
            foreach (Engine.Point p in lp)
            {
                bmp.SetPixel(p.X, p.Y, color);
                bmp.SetPixel(p.X + 1, p.Y, color);
                bmp.SetPixel(p.X - 1, p.Y, color);
                bmp.SetPixel(p.X, p.Y + 1, color);
                bmp.SetPixel(p.X, p.Y - 1, color);
            }

        }

        private void panel1_Click(object sender, EventArgs e)
        {        
            System.Drawing.Point point = panel1.PointToClient(Cursor.Position);
            lp.Add(new Engine.Point(point.X, point.Y));
            DrawPoint(lp , Color.Green);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Engine.Path> init = InitGen.Gen(50, lp);
            c = new Core.Core(init, this);
            c.Init();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            c.Stop();
        }





        

    }
}
