namespace OmniPowerAssignment
{
    public partial class Form1 : Form
    {

        int threshold=0;

        //creating object for Sensor_Handler which will be used to gather data from sensor
        private Sensor_Handler SensorHandler1 = new Sensor_Handler();
        //creating timer object to use for automatic refresh 
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        //create enum to use instead of just an int for better readability in the future
        int Graphing_selector = 0;

        public Form1()
        {
            // form initialization
            InitializeComponent();
            //setting up x label for graph
            formsPlot1.Plot.XLabel("Time");
            formsPlot1.Plot.Title("Temperature Over Time");
            formsPlot1.Plot.YLabel("°C");
            formsPlot1.Refresh();

            //every 1.5 seconds refresh and get new values
            timer.Interval = 1500;

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
            TempReading.Text = SensorHandler1.SensorDataHistory[0].Last().ToString();
            HumidityReading.Text = SensorHandler1.SensorDataHistory[1].Last().ToString();
            PressureReading.Text = SensorHandler1.SensorDataHistory[2].Last().ToString();


            //setting up graph. 
            double[] data = SensorHandler1.SensorDataHistory[Graphing_selector].ToArray();
            double[] Time_stamp_Data = SensorHandler1.TimeStamp.ToArray();


            formsPlot1.Plot.Add.Scatter(Time_stamp_Data, data);
            formsPlot1.Plot.Axes.DateTimeTicksBottom();
            formsPlot1.Plot.Axes.AutoScale();
            formsPlot1.Refresh();



            //checking if threshold is passed. Will move the following to Sensor_handler
            if (checkBox1.Checked && threshold< SensorHandler1.SensorDataHistory[Graphing_selector].Last())
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
            formsPlot1.Plot.Clear();
            formsPlot1.Plot.Title("Temperature Over Time");
            formsPlot1.Plot.YLabel("°C");
            Graphing_selector = 0;
            formsPlot1.Refresh();


        }

        private void pressureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //clearing plot values, updating title, and changing variable being graphed
            formsPlot1.Plot.Clear();
            formsPlot1.Plot.Title("Pressure Over Time");
            formsPlot1.Plot.YLabel("p");
            Graphing_selector = 2;
            formsPlot1.Refresh();

        }

        private void humidityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //clearing plot values, updating title, and changing variable being graphed
            formsPlot1.Plot.Clear();
            formsPlot1.Plot.Title("Humidity Over Time");
            formsPlot1.Plot.YLabel("%");
            Graphing_selector = 1;
            formsPlot1.Refresh();

        }

        private void button1_Click(object sender, EventArgs e)
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
                Status.Text = "Runing";

            }
        }

        private void ThresholdValueChange (object sender, EventArgs e)
        {
            threshold = int.Parse(ThresholdValue.Text);
        }

    }
}
