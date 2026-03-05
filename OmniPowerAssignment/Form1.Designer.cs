namespace OmniPowerAssignment
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            label3 = new Label();
            label2 = new Label();
            HumidityReading = new TextBox();
            PressureReading = new TextBox();
            TempReading = new TextBox();
            label1 = new Label();
            Graph = new MenuStrip();
            graphToolStripMenuItem = new ToolStripMenuItem();
            temperatureToolStripMenuItem = new ToolStripMenuItem();
            pressureToolStripMenuItem = new ToolStripMenuItem();
            humidityToolStripMenuItem = new ToolStripMenuItem();
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            trackBar1 = new TrackBar();
            tableLayoutPanel1.SuspendLayout();
            Graph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52F));
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(HumidityReading, 1, 1);
            tableLayoutPanel1.Controls.Add(PressureReading, 1, 2);
            tableLayoutPanel1.Controls.Add(TempReading, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(Graph, 1, 3);
            tableLayoutPanel1.Location = new Point(657, 25);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel1.Size = new Size(200, 251);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 163);
            label3.Name = "label3";
            label3.Size = new Size(90, 44);
            label3.TabIndex = 6;
            label3.Text = "Pressure(\\p)";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 103);
            label2.Name = "label2";
            label2.Size = new Size(90, 60);
            label2.TabIndex = 5;
            label2.Text = "Humidity(%)";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // HumidityReading
            // 
            HumidityReading.Anchor = AnchorStyles.None;
            HumidityReading.BackColor = SystemColors.ControlLightLight;
            HumidityReading.Location = new Point(101, 121);
            HumidityReading.Name = "HumidityReading";
            HumidityReading.ReadOnly = true;
            HumidityReading.Size = new Size(94, 23);
            HumidityReading.TabIndex = 1;
            // 
            // PressureReading
            // 
            PressureReading.Anchor = AnchorStyles.None;
            PressureReading.BackColor = SystemColors.Window;
            PressureReading.Location = new Point(101, 173);
            PressureReading.Name = "PressureReading";
            PressureReading.ReadOnly = true;
            PressureReading.Size = new Size(94, 23);
            PressureReading.TabIndex = 2;
            // 
            // TempReading
            // 
            TempReading.Anchor = AnchorStyles.None;
            TempReading.BackColor = SystemColors.ControlLightLight;
            TempReading.Location = new Point(101, 40);
            TempReading.Name = "TempReading";
            TempReading.ReadOnly = true;
            TempReading.Size = new Size(94, 23);
            TempReading.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(90, 103);
            label1.TabIndex = 4;
            label1.Text = "Temperature(C)";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Graph
            // 
            Graph.BackColor = SystemColors.ControlLightLight;
            Graph.Dock = DockStyle.None;
            Graph.Items.AddRange(new ToolStripItem[] { graphToolStripMenuItem });
            Graph.Location = new Point(96, 207);
            Graph.Name = "Graph";
            Graph.RenderMode = ToolStripRenderMode.Professional;
            Graph.Size = new Size(59, 24);
            Graph.TabIndex = 7;
            Graph.Text = "menuStrip1";
            // 
            // graphToolStripMenuItem
            // 
            graphToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { temperatureToolStripMenuItem, pressureToolStripMenuItem, humidityToolStripMenuItem });
            graphToolStripMenuItem.Name = "graphToolStripMenuItem";
            graphToolStripMenuItem.Size = new Size(51, 20);
            graphToolStripMenuItem.Text = "Graph";
            // 
            // temperatureToolStripMenuItem
            // 
            temperatureToolStripMenuItem.Name = "temperatureToolStripMenuItem";
            temperatureToolStripMenuItem.Size = new Size(180, 22);
            temperatureToolStripMenuItem.Text = "Temperature";
            temperatureToolStripMenuItem.Click += temperatureToolStripMenuItem_Click;
            // 
            // pressureToolStripMenuItem
            // 
            pressureToolStripMenuItem.Name = "pressureToolStripMenuItem";
            pressureToolStripMenuItem.Size = new Size(180, 22);
            pressureToolStripMenuItem.Text = "Pressure";
            pressureToolStripMenuItem.Click += pressureToolStripMenuItem_Click;
            // 
            // humidityToolStripMenuItem
            // 
            humidityToolStripMenuItem.Name = "humidityToolStripMenuItem";
            humidityToolStripMenuItem.Size = new Size(180, 22);
            humidityToolStripMenuItem.Text = "Humidity";
            humidityToolStripMenuItem.Click += humidityToolStripMenuItem_Click;
            // 
            // formsPlot1
            // 
            formsPlot1.DisplayScale = 1F;
            formsPlot1.Location = new Point(21, 32);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(611, 296);
            formsPlot1.TabIndex = 7;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(669, 283);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(183, 45);
            trackBar1.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 374);
            Controls.Add(trackBar1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(formsPlot1);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            Graph.ResumeLayout(false);
            Graph.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox HumidityReading;
        private TextBox PressureReading;
        private Label label3;
        private Label label2;
        private TextBox TempReading;
        private Label label1;
        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private MenuStrip Graph;
        private ToolStripMenuItem graphToolStripMenuItem;
        private ToolStripMenuItem temperatureToolStripMenuItem;
        private ToolStripMenuItem pressureToolStripMenuItem;
        private ToolStripMenuItem humidityToolStripMenuItem;
        private TrackBar trackBar1;
    }
}
