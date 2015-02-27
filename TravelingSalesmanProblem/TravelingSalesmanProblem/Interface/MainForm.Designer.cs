namespace TravelingSalesmanProblem.Interface
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.monoFlat_ThemeContainer1 = new TravelingSalesmanProblem.Interface.MonoFlat_ThemeContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.monoFlat_Label3 = new TravelingSalesmanProblem.Interface.MonoFlat_Label();
            this.SizeTrackBar = new TravelingSalesmanProblem.Interface.MonoFlat_TrackBar();
            this.BestDistLb = new TravelingSalesmanProblem.Interface.MonoFlat_Label();
            this.monoFlat_Label2 = new TravelingSalesmanProblem.Interface.MonoFlat_Label();
            this.monoFlat_HeaderLabel2 = new TravelingSalesmanProblem.Interface.MonoFlat_HeaderLabel();
            this.monoFlat_HeaderLabel1 = new TravelingSalesmanProblem.Interface.MonoFlat_HeaderLabel();
            this.monoFlat_Separator1 = new TravelingSalesmanProblem.Interface.MonoFlat_Separator();
            this.monoFlat_Label1 = new TravelingSalesmanProblem.Interface.MonoFlat_Label();
            this.StartStopBt = new TravelingSalesmanProblem.Interface.MonoFlat_Toggle();
            this.monoFlat_ControlBox1 = new TravelingSalesmanProblem.Interface.MonoFlat_ControlBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLb = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.monoFlat_ThemeContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "0";
            // 
            // monoFlat_ThemeContainer1
            // 
            this.monoFlat_ThemeContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.monoFlat_ThemeContainer1.Controls.Add(this.statusStrip1);
            this.monoFlat_ThemeContainer1.Controls.Add(this.panel1);
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_Label3);
            this.monoFlat_ThemeContainer1.Controls.Add(this.SizeTrackBar);
            this.monoFlat_ThemeContainer1.Controls.Add(this.BestDistLb);
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_Label2);
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_HeaderLabel2);
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_HeaderLabel1);
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_Separator1);
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_Label1);
            this.monoFlat_ThemeContainer1.Controls.Add(this.StartStopBt);
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_ControlBox1);
            this.monoFlat_ThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monoFlat_ThemeContainer1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.monoFlat_ThemeContainer1.Location = new System.Drawing.Point(0, 0);
            this.monoFlat_ThemeContainer1.Name = "monoFlat_ThemeContainer1";
            this.monoFlat_ThemeContainer1.Padding = new System.Windows.Forms.Padding(10, 70, 10, 9);
            this.monoFlat_ThemeContainer1.RoundCorners = true;
            this.monoFlat_ThemeContainer1.Sizable = true;
            this.monoFlat_ThemeContainer1.Size = new System.Drawing.Size(534, 343);
            this.monoFlat_ThemeContainer1.SmartBounds = true;
            this.monoFlat_ThemeContainer1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.monoFlat_ThemeContainer1.TabIndex = 4;
            this.monoFlat_ThemeContainer1.Text = "Traveling Salesman Problem - TPE";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(13, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 219);
            this.panel1.TabIndex = 12;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // monoFlat_Label3
            // 
            this.monoFlat_Label3.AutoSize = true;
            this.monoFlat_Label3.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.monoFlat_Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.monoFlat_Label3.Location = new System.Drawing.Point(464, 136);
            this.monoFlat_Label3.Name = "monoFlat_Label3";
            this.monoFlat_Label3.Size = new System.Drawing.Size(42, 15);
            this.monoFlat_Label3.TabIndex = 11;
            this.monoFlat_Label3.Text = "Size : 0";
            // 
            // SizeTrackBar
            // 
            this.SizeTrackBar.JumpToMouse = false;
            this.SizeTrackBar.Location = new System.Drawing.Point(303, 133);
            this.SizeTrackBar.Maximum = 100;
            this.SizeTrackBar.Minimum = 0;
            this.SizeTrackBar.MinimumSize = new System.Drawing.Size(47, 22);
            this.SizeTrackBar.Name = "SizeTrackBar";
            this.SizeTrackBar.Size = new System.Drawing.Size(134, 22);
            this.SizeTrackBar.TabIndex = 10;
            this.SizeTrackBar.Text = "SizzeTrackBar";
            this.SizeTrackBar.Value = 0;
            this.SizeTrackBar.ValueDivison = TravelingSalesmanProblem.Interface.MonoFlat_TrackBar.ValueDivisor.By1;
            this.SizeTrackBar.ValueToSet = 0F;
            this.SizeTrackBar.ValueChanged += new TravelingSalesmanProblem.Interface.MonoFlat_TrackBar.ValueChangedEventHandler(this.SizeTrackBar_ValueChanged);
            // 
            // BestDistLb
            // 
            this.BestDistLb.AutoSize = true;
            this.BestDistLb.BackColor = System.Drawing.Color.Transparent;
            this.BestDistLb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BestDistLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.BestDistLb.Location = new System.Drawing.Point(398, 222);
            this.BestDistLb.Name = "BestDistLb";
            this.BestDistLb.Size = new System.Drawing.Size(58, 15);
            this.BestDistLb.TabIndex = 9;
            this.BestDistLb.Text = "Unknown";
            // 
            // monoFlat_Label2
            // 
            this.monoFlat_Label2.AutoSize = true;
            this.monoFlat_Label2.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.monoFlat_Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.monoFlat_Label2.Location = new System.Drawing.Point(307, 222);
            this.monoFlat_Label2.Name = "monoFlat_Label2";
            this.monoFlat_Label2.Size = new System.Drawing.Size(85, 15);
            this.monoFlat_Label2.TabIndex = 8;
            this.monoFlat_Label2.Text = "Best distance : ";
            // 
            // monoFlat_HeaderLabel2
            // 
            this.monoFlat_HeaderLabel2.AutoSize = true;
            this.monoFlat_HeaderLabel2.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_HeaderLabel2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.monoFlat_HeaderLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.monoFlat_HeaderLabel2.Location = new System.Drawing.Point(303, 70);
            this.monoFlat_HeaderLabel2.Name = "monoFlat_HeaderLabel2";
            this.monoFlat_HeaderLabel2.Size = new System.Drawing.Size(66, 20);
            this.monoFlat_HeaderLabel2.TabIndex = 7;
            this.monoFlat_HeaderLabel2.Text = "Settings";
            // 
            // monoFlat_HeaderLabel1
            // 
            this.monoFlat_HeaderLabel1.AutoSize = true;
            this.monoFlat_HeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_HeaderLabel1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.monoFlat_HeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.monoFlat_HeaderLabel1.Location = new System.Drawing.Point(303, 198);
            this.monoFlat_HeaderLabel1.Name = "monoFlat_HeaderLabel1";
            this.monoFlat_HeaderLabel1.Size = new System.Drawing.Size(60, 20);
            this.monoFlat_HeaderLabel1.TabIndex = 6;
            this.monoFlat_HeaderLabel1.Text = "Results";
            // 
            // monoFlat_Separator1
            // 
            this.monoFlat_Separator1.Location = new System.Drawing.Point(303, 183);
            this.monoFlat_Separator1.Name = "monoFlat_Separator1";
            this.monoFlat_Separator1.Size = new System.Drawing.Size(217, 12);
            this.monoFlat_Separator1.TabIndex = 5;
            this.monoFlat_Separator1.Text = "monoFlat_Separator1";
            // 
            // monoFlat_Label1
            // 
            this.monoFlat_Label1.AutoSize = true;
            this.monoFlat_Label1.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.monoFlat_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.monoFlat_Label1.Location = new System.Drawing.Point(385, 103);
            this.monoFlat_Label1.Name = "monoFlat_Label1";
            this.monoFlat_Label1.Size = new System.Drawing.Size(134, 15);
            this.monoFlat_Label1.TabIndex = 4;
            this.monoFlat_Label1.Text = "Start/Stop Computation";
            // 
            // StartStopBt
            // 
            this.StartStopBt.Location = new System.Drawing.Point(303, 94);
            this.StartStopBt.Name = "StartStopBt";
            this.StartStopBt.Size = new System.Drawing.Size(76, 33);
            this.StartStopBt.TabIndex = 3;
            this.StartStopBt.Text = "StartStopBt";
            this.StartStopBt.Toggled = false;
            this.StartStopBt.Type = TravelingSalesmanProblem.Interface.MonoFlat_Toggle._Type.CheckMark;
            this.StartStopBt.ToggledChanged += new TravelingSalesmanProblem.Interface.MonoFlat_Toggle.ToggledChangedEventHandler(this.StartStopBt_ToggledChanged);
            // 
            // monoFlat_ControlBox1
            // 
            this.monoFlat_ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monoFlat_ControlBox1.EnableHoverHighlight = false;
            this.monoFlat_ControlBox1.EnableMaximizeButton = true;
            this.monoFlat_ControlBox1.EnableMinimizeButton = true;
            this.monoFlat_ControlBox1.Location = new System.Drawing.Point(422, 15);
            this.monoFlat_ControlBox1.Name = "monoFlat_ControlBox1";
            this.monoFlat_ControlBox1.Size = new System.Drawing.Size(100, 25);
            this.monoFlat_ControlBox1.TabIndex = 2;
            this.monoFlat_ControlBox1.Text = "monoFlat_ControlBox1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.statusLb,
            this.statusProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(10, 312);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(514, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.White;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(82, 17);
            this.toolStripStatusLabel1.Text = "Current work :";
            // 
            // statusLb
            // 
            this.statusLb.BackColor = System.Drawing.Color.White;
            this.statusLb.Name = "statusLb";
            this.statusLb.Size = new System.Drawing.Size(36, 17);
            this.statusLb.Text = "None";
            // 
            // statusProgressBar
            // 
            this.statusProgressBar.Name = "statusProgressBar";
            this.statusProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(534, 343);
            this.Controls.Add(this.monoFlat_ThemeContainer1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Traveling Salesman Problem - TPE";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.monoFlat_ThemeContainer1.ResumeLayout(false);
            this.monoFlat_ThemeContainer1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        private MonoFlat_ThemeContainer monoFlat_ThemeContainer1;
        private MonoFlat_ControlBox monoFlat_ControlBox1;
        private MonoFlat_Label monoFlat_Label2;
        private MonoFlat_HeaderLabel monoFlat_HeaderLabel2;
        private MonoFlat_HeaderLabel monoFlat_HeaderLabel1;
        private MonoFlat_Separator monoFlat_Separator1;
        private MonoFlat_Label monoFlat_Label1;
        private MonoFlat_Toggle StartStopBt;
        public MonoFlat_Label BestDistLb;
        private MonoFlat_Label monoFlat_Label3;
        private MonoFlat_TrackBar SizeTrackBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel statusLb;
        private System.Windows.Forms.ToolStripProgressBar statusProgressBar;

    }
}