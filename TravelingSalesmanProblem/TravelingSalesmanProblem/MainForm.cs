using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace TravelingSalesmanProblem
{
    public partial class MainForm : DevComponents.DotNetBar.Metro.MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm GetInstance()
        {
            if (this != null)
                return this;
            else
                return new MainForm();
        }
    }
}