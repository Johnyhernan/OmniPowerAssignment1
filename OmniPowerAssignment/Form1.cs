namespace OmniPowerAssignment
{
    public partial class Form1 : Form
    {
        private Sensor_Handler SensorHandler1 = new Sensor_Handler();
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        public Form1()
        {
            InitializeComponent();

            formsPlot1.Plot.Title("Temperature Over Time");
            formsPlot1.Plot.YLabel("°C");
            formsPlot1.Plot.XLabel("Time");
            timer.Interval = 1500;//every 1.5 seconds refresh and get new values

            timer.Tick += UpdateUI;//call updateUI each tick cycle 

            timer.Start();

        }

        private void UpdateUI(object sender, EventArgs e)
        {
            formsPlot1.Plot.Clear();
            SensorHandler1.Update_Values();
            TempReading.Text = SensorHandler1.Temp_History.Last().ToString();
            HumidityReading.Text = SensorHandler1.Humidity_History.Last().ToString();
            PressureReading.Text = SensorHandler1.Pressure_History.Last().ToString();


            double[] data = SensorHandler1.Temp_History.ToArray();
            double[] data2 = SensorHandler1.TimeStamp.ToArray();
            formsPlot1.Plot.Add.Scatter(data2, data);
            formsPlot1.Plot.Axes.DateTimeTicksBottom();
            formsPlot1.Plot.Axes.AutoScale();

            formsPlot1.Refresh();


        }

        private void temperatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formsPlot1.Plot.Title("Temperature Over Time");
            formsPlot1.Plot.YLabel("°C");

            formsPlot1.Plot.Clear();
            double[] data = SensorHandler1.Temp_History.ToArray();
            double[] data2 = SensorHandler1.TimeStamp.ToArray();
            formsPlot1.Plot.Add.Scatter(data2, data);
            formsPlot1.Plot.Axes.DateTimeTicksBottom();
            formsPlot1.Plot.Axes.AutoScale();

            formsPlot1.Refresh();

        }

        private void pressureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formsPlot1.Plot.Title("Pressure Over Time");
            formsPlot1.Plot.YLabel("p");

            formsPlot1.Plot.Clear();
            double[] data = SensorHandler1.Pressure_History.ToArray();
            double[] data2 = SensorHandler1.TimeStamp.ToArray();
            formsPlot1.Plot.Add.Scatter(data2, data);
            formsPlot1.Plot.Axes.DateTimeTicksBottom();
            formsPlot1.Plot.Axes.AutoScale();

            formsPlot1.Refresh();

        }

        private void humidityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formsPlot1.Plot.Title("Humidity Over Time");
            formsPlot1.Plot.YLabel("%");

            formsPlot1.Plot.Clear();
            double[] data = SensorHandler1.Humidity_History.ToArray();
            double[] data2 = SensorHandler1.TimeStamp.ToArray();
            formsPlot1.Plot.Add.Scatter(data2, data);
            formsPlot1.Plot.Axes.DateTimeTicksBottom();
            formsPlot1.Plot.Axes.AutoScale();

            formsPlot1.Refresh();
        }
    }
}
