namespace TravelingSalesmanProblem.Interface
{
    partial class PerceptronForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.monoFlat_ThemeContainer1 = new TravelingSalesmanProblem.Interface.MonoFlat_ThemeContainer();
            this.monoFlat_Button4 = new TravelingSalesmanProblem.Interface.MonoFlat_Button();
            this.monoFlat_Button2 = new TravelingSalesmanProblem.Interface.MonoFlat_Button();
            this.monoFlat_Button1 = new TravelingSalesmanProblem.Interface.MonoFlat_Button();
            this.Output = new System.Windows.Forms.RichTextBox();
            this.monoFlat_ThemeContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monoFlat_ThemeContainer1
            // 
            this.monoFlat_ThemeContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_Button4);
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_Button2);
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_Button1);
            this.monoFlat_ThemeContainer1.Controls.Add(this.Output);
            this.monoFlat_ThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monoFlat_ThemeContainer1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.monoFlat_ThemeContainer1.Location = new System.Drawing.Point(0, 0);
            this.monoFlat_ThemeContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.monoFlat_ThemeContainer1.Name = "monoFlat_ThemeContainer1";
            this.monoFlat_ThemeContainer1.Padding = new System.Windows.Forms.Padding(13, 86, 13, 11);
            this.monoFlat_ThemeContainer1.RoundCorners = true;
            this.monoFlat_ThemeContainer1.Sizable = true;
            this.monoFlat_ThemeContainer1.Size = new System.Drawing.Size(865, 478);
            this.monoFlat_ThemeContainer1.SmartBounds = true;
            this.monoFlat_ThemeContainer1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.monoFlat_ThemeContainer1.TabIndex = 0;
            this.monoFlat_ThemeContainer1.Text = "Perceptron - Artificial Neuron Sample";
            // 
            // monoFlat_Button4
            // 
            this.monoFlat_Button4.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Button4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.monoFlat_Button4.Image = null;
            this.monoFlat_Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.monoFlat_Button4.Location = new System.Drawing.Point(17, 437);
            this.monoFlat_Button4.Name = "monoFlat_Button4";
            this.monoFlat_Button4.Size = new System.Drawing.Size(829, 29);
            this.monoFlat_Button4.TabIndex = 4;
            this.monoFlat_Button4.Text = "Clear";
            this.monoFlat_Button4.TextAlignment = System.Drawing.StringAlignment.Center;
            this.monoFlat_Button4.Click += new System.EventHandler(this.monoFlat_Button4_Click);
            // 
            // monoFlat_Button2
            // 
            this.monoFlat_Button2.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Button2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.monoFlat_Button2.Image = null;
            this.monoFlat_Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.monoFlat_Button2.Location = new System.Drawing.Point(602, 75);
            this.monoFlat_Button2.Name = "monoFlat_Button2";
            this.monoFlat_Button2.Size = new System.Drawing.Size(244, 55);
            this.monoFlat_Button2.TabIndex = 2;
            this.monoFlat_Button2.Text = "AND Learning";
            this.monoFlat_Button2.TextAlignment = System.Drawing.StringAlignment.Center;
            this.monoFlat_Button2.Click += new System.EventHandler(this.monoFlat_Button2_Click);
            // 
            // monoFlat_Button1
            // 
            this.monoFlat_Button1.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Button1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.monoFlat_Button1.Image = null;
            this.monoFlat_Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.monoFlat_Button1.Location = new System.Drawing.Point(17, 75);
            this.monoFlat_Button1.Name = "monoFlat_Button1";
            this.monoFlat_Button1.Size = new System.Drawing.Size(250, 55);
            this.monoFlat_Button1.TabIndex = 1;
            this.monoFlat_Button1.Text = "OR Learning";
            this.monoFlat_Button1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.monoFlat_Button1.Click += new System.EventHandler(this.monoFlat_Button1_Click);
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(17, 137);
            this.Output.Margin = new System.Windows.Forms.Padding(4);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(829, 299);
            this.Output.TabIndex = 0;
            this.Output.Text = "";
            // 
            // PerceptronForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 478);
            this.Controls.Add(this.monoFlat_ThemeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PerceptronForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perceptron - Artificial Neuron Sample";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.monoFlat_ThemeContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MonoFlat_ThemeContainer monoFlat_ThemeContainer1;
        public System.Windows.Forms.RichTextBox Output;
        private MonoFlat_Button monoFlat_Button2;
        private MonoFlat_Button monoFlat_Button1;
        private MonoFlat_Button monoFlat_Button4;
    }
}