using static OmniPowerAssignment.Sensor_Handler;

namespace OmniPowerAssignment
{
    public partial class Form1 : Form
    {
        //enum object used for basic purposes

        private SensorType SensorType;
        //enum object used specifically for graphs
        private SensorType GraphingSelector = SensorType.Temperature;
        int threshold=0;

        //creating object for Sensor_Handler which will be used to gather data from sensor
        private Sensor_Handler SensorHandler1 = new Sensor_Handler();
        //creating timer object to use for automatic refresh 
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();


        public Form1()
        {
            // form initialization
            InitializeComponent();

            //initializing enum to use instead of random numbers.
            GraphingSelector = SensorType.Temperature;

            //setting up x label for graph
            formsPlot1.Plot.XLabel("Time");
            formsPlot1.Plot.Title("Temperature Over Time");
            formsPlot1.Plot.YLabel("°C");
            formsPlot1.Refresh();

            //every 2 seconds refresh and get new values
            timer.Interval = 2000;

            //call updateUI each tick cycle 
            timer.Tick += UpdateUI;


        }

        private void UpdateUI(object sender, EventArgs e)
        {


           //clearing plot 
            formsPlot1.Plot.Clear();


            //updating all values for each sensor
            SensorHandler1.Update_Values();

            //changing text accordingly showing newest value received by sensor 
            TempReading.Text = SensorHandler1.GetLatestValueAsString((int)SensorType.Temperature);
            HumidityReading.Text = SensorHandler1.GetLatestValueAsString((int)SensorType.Humidity);
            PressureReading.Text = SensorHandler1.GetLatestValueAsString((int)SensorType.Pressure);


            //setting up graph. 
            double[] data = SensorHandler1.GetSensorHistory((int)GraphingSelector);
            double[] Time_stamp_Data = SensorHandler1.TimeHistory();


            formsPlot1.Plot.Add.Scatter(Time_stamp_Data, data);
            formsPlot1.Plot.Axes.DateTimeTicksBottom();
            formsPlot1.Plot.Axes.AutoScale();
            formsPlot1.Refresh();



            //checking if threshold is passed. Will move the following to Sensor_handler
            if (checkBox1.Checked && SensorHandler1.ThresholdExceeded((int)GraphingSelector,threshold))
            {
                threshold_Indicator.Text = "Warning: Threshold Value Passed";
                threshold_Indicator.ForeColor = Color.Red;
            }
            else
            {
                threshold_Indicator.Text = "";

            }
        }

        private void temperatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //clearing plot values, updating title, and changing variable being graphed
            UpdateGraphTitle("Temperature Over Time", "C");
            GraphingSelector = SensorType.Temperature;
            formsPlot1.Refresh();


        }

        private void pressureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //clearing plot values, updating title, and changing variable being graphed
            UpdateGraphTitle("Pressure Over Time", "p");
            GraphingSelector = SensorType.Pressure;
            formsPlot1.Refresh();

        }

        private void humidityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //clearing plot values, updating title, and changing variable being graphed
            UpdateGraphTitle("Humidity Over Time", "%");
            GraphingSelector = SensorType.Humidity;
            formsPlot1.Refresh();

        }

        private void StartButtonToggler(object sender, EventArgs e)
        {
            //toggling state of gui each time button is clicked 
            if (timer.Enabled)
            {
                timer.Stop();
                button1.Text = "Start";
                Status.Text = "Stopped";
            }
            else
            {
                timer.Start();
                button1.Text = "Stop";
                Status.Text = "Running";

            }
        }

        private void ThresholdValueChange (object sender, EventArgs e)
        {


            //add guardlines to prevent user from typing text into box.. Debounce making message box to show twice-to fix later

            if (int.TryParse(ThresholdValue.Text, out int value))
            {
                threshold = value;
            }
            else
            {
                ThresholdValue.Text = "";

                MessageBox.Show("Please enter a valid number for the threshold!");
            }
        }
        //helper method for easier graph setu
        private void UpdateGraphTitle(string title, string yLabel)
        {
            formsPlot1.Plot.Clear();
            formsPlot1.Plot.Title(title);
            formsPlot1.Plot.YLabel(yLabel);
        }

    }
}
