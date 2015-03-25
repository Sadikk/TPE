using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelingSalesmanProblem.Engine;

namespace TravelingSalesmanProblem.Interface
{
    public partial class PerceptronForm : Form
    {
        #region Fields
        public Perceptron Perceptron;
        #endregion

        #region Constructors
        public PerceptronForm()
        {
            InitializeComponent();
            Perceptron = new Perceptron(this);
        }
        #endregion

        #region UI Methods
        private void monoFlat_Button1_Click(object sender, EventArgs e)
        {
            Perceptron.OR();
        }

        private void monoFlat_Button2_Click(object sender, EventArgs e)
        {
            Perceptron.AND();
        }

        private void monoFlat_Button4_Click(object sender, EventArgs e)
        {
            this.Output.Clear();
            Perceptron.Clear();
        }
        #endregion
    }
}
