using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmniPowerAssignment
{
    public class Sensor_Handler
    {


        Sensor temp = new Sensor("temperature", "C", 12);
        Sensor Humidity = new Sensor("Humidity", "%", 40);
        Sensor Pressure = new Sensor("Pressure", "/p", 32);


        public Queue<double> Temp_History = new Queue<double>();
        public Queue<double> Humidity_History = new Queue<double>();
        public Queue<double> Pressure_History = new Queue<double>();
        public Queue<double> TimeStamp = new Queue<double>();



        public void Update_Values()

        {
            //getting timestamp for all readings 
            double Current_Time = DateTime.Now.ToOADate();
            //getting values for eaach sensor and adding it to the queue
            Temp_History.Enqueue(temp.GetValueOfsensor());
            Humidity_History.Enqueue(Humidity.GetValueOfsensor());
            Pressure_History.Enqueue(Pressure.GetValueOfsensor());
            TimeStamp.Enqueue(Current_Time);
            //we only need to keep track of one queue 
            if (Temp_History.Count > 30)
            {
                //getting rid of oldest value
                Temp_History.Dequeue();
                Humidity_History.Dequeue();
                Pressure_History.Dequeue();
                TimeStamp.Dequeue();
            }

        }
    }
}
