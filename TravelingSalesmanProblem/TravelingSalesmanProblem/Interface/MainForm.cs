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
        #region Fields
        bool isDrawing; /* Determins if we draw lines between points or only points */
        List<Engine.Point> lp = new List<Engine.Point>();
        List<System.Drawing.Point> Points = new List<System.Drawing.Point>();
        Core.Core c;
        Tuple<System.Drawing.Point, System.Drawing.Point> pToDraw;
        int size;
        #endregion

        #region Constructors
        public MainForm()
        {
            InitializeComponent();            
        }
        #endregion

        #region Interface Methods
        private void StartStopBt_ToggledChanged()
        {
            if (StartStopBt.Toggled)
            {
                if (lp.Count > 1) /* Check the number of points */
                {
                    List<Engine.Path> init = InitGen.Gen(size, lp);
                    c = new Core.Core(init, this);
                    c.Init();
                }
                else
                    MessageBox.Show("Please enter more than 3 points.");
            }
            else
            {
                c.Stop();
            }
        }

        private void monoFlat_Button2_Click(object sender, EventArgs e)
        {
            PerceptronForm f = new PerceptronForm();
            Perceptron p = new Perceptron(f);
            f.Show();
            p.AND();
        }

        private void SizeTrackBar_ValueChanged()
        {
            monoFlat_Label3.Text = "Size : " + SizeTrackBar.Value;
            size = SizeTrackBar.Value;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            System.Drawing.Point point = panel1.PointToClient(Cursor.Position);
            lp.Add(new Engine.Point(point.X, point.Y));
            Points.Add(point);
            panel1.Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (Points != null)
            {
                using (var p = new Pen(Color.Blue, 1))
                {
                    for (int i = 0; i < Points.Count; i++)
                    {
                        if (i == 0)
                            e.Graphics.DrawRectangle(new Pen(Color.Green, 1), Points[i].X, Points[i].Y, 3, 3);
                        else
                            e.Graphics.DrawEllipse(p, Points[i].X, Points[i].Y, 3, 3);
                    }
                }
            }
            if (Points != null && isDrawing)
            {
                using (var p = new Pen(Color.FromArgb(181, 41, 42), 1))
                {
                    for (int i = 0; i < Points.Count - 1; i++)
                    {
                        e.Graphics.DrawLine(p, Points[i], Points[i + 1]);
                    }
                }
            }
        }

        private void monoFlat_Button1_Click(object sender, EventArgs e)
        {
            /* Draw actual best path button click */
            if (c.running)
            {
               /* if computation is running, stop it before drawing the best path */
               if (MessageBox.Show("Computation is running ! Stop it and draw best path ?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
               {
                   c.Stop();
                   DrawPath(c.current_best);
               }
            }
            else
            {
                DrawPath(c.current_best);
            }
        }
        #endregion

        #region Public Methods
        public void DrawPath(Path p)
        {
            /* Draw a path on the panel */
            // TODO : Use it at each step of the Core process
            isDrawing = true;
            Points = p.DrawingPoints();
            panel1.Invalidate();
        }

        public void SetStatus(string status)
        {
            // TODO : Use it at each step of the Core process.
            statusLb.Text = status;
        }

        public void SetProgress(int value)
        {
            // TODO : Use it at each step of the Core process
            statusProgressBar.Value = value;
        }

        public void SetNewTask(int min, int max)
        {
            // TODO : Use it at each step of the Core process
            statusProgressBar.Minimum = min;
            statusProgressBar.Maximum = max;
        }
        #endregion

       

        


        

        

        





        

    }
}
