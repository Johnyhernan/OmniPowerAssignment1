namespace OmniPowerAssignment
{
    public partial class Form1 : Form
    {
        private Sensor_Handler SensorHandler1 = new Sensor_Handler();
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        public Form1()
        {
            InitializeComponent();
            timer.Interval = 1500;

            timer.Tick += UpdateUI;
            timer.Start();

        }

        private void UpdateUI(object sender, EventArgs e)
        {
            SensorHandler1.Update_Values();
            TempReading.Text = SensorHandler1.Temp_History.Last().ToString();
            HumidityReading.Text = SensorHandler1.Humidity_History.Last().ToString();
            PressureReading.Text = SensorHandler1.Pressure_History.Last().ToString();

        }
    }
}
