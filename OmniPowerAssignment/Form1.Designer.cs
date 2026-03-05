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
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(HumidityReading, 1, 1);
            tableLayoutPanel1.Controls.Add(PressureReading, 1, 2);
            tableLayoutPanel1.Controls.Add(TempReading, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Location = new Point(657, 25);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tableLayoutPanel1.Size = new Size(200, 168);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 110);
            label3.Name = "label3";
            label3.Size = new Size(94, 58);
            label3.TabIndex = 6;
            label3.Text = "Pressure(\\p)";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 58);
            label2.Name = "label2";
            label2.Size = new Size(94, 52);
            label2.TabIndex = 5;
            label2.Text = "Humidity(%)";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // HumidityReading
            // 
            HumidityReading.Anchor = AnchorStyles.None;
            HumidityReading.BackColor = SystemColors.ControlLightLight;
            HumidityReading.Location = new Point(103, 72);
            HumidityReading.Name = "HumidityReading";
            HumidityReading.ReadOnly = true;
            HumidityReading.Size = new Size(94, 23);
            HumidityReading.TabIndex = 1;
            // 
            // PressureReading
            // 
            PressureReading.Anchor = AnchorStyles.None;
            PressureReading.BackColor = SystemColors.Window;
            PressureReading.Location = new Point(103, 127);
            PressureReading.Name = "PressureReading";
            PressureReading.ReadOnly = true;
            PressureReading.Size = new Size(94, 23);
            PressureReading.TabIndex = 2;
            // 
            // TempReading
            // 
            TempReading.Anchor = AnchorStyles.None;
            TempReading.BackColor = SystemColors.ControlLightLight;
            TempReading.Location = new Point(103, 17);
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
            label1.Size = new Size(94, 58);
            label1.TabIndex = 4;
            label1.Text = "Temperature(C)";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox HumidityReading;
        private TextBox PressureReading;
        private Label label3;
        private Label label2;
        private TextBox TempReading;
        private Label label1;
    }
}
