using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmniPowerAssignment
{
    public class Sensor_Handler
    {


        //creating an array of size three. Each cell will hold a queue holding up to 30 values max
        public Queue<double>[] SensorDataHistory = new Queue<double>[3];


        //enum SensorType to show which queue is linked to which dataset instead of just '0','1','2'
        public enum SensorType
        {
            Temperature,
            Humidity,
            Pressure
        }


        //creating a queue for each sensor
        public Sensor_Handler()
        {
            SensorDataHistory[(int)SensorType.Temperature] = new Queue<double>(); 
            SensorDataHistory[(int)SensorType.Humidity] = new Queue<double>(); 
            SensorDataHistory[(int)SensorType.Pressure] = new Queue<double>();
        }

        //time stamp that all sensors will use
        public Queue<double> TimeStamp = new Queue<double>();


        //creating objects that will be used for value generation 
        Sensor temp = new Sensor("temperature", "C", 12);
        Sensor Humidity = new Sensor("Humidity", "%", 40);
        Sensor Pressure = new Sensor("Pressure", "/p", 32);




        //function to update all values accordinglu

        public void Update_Values()

        {
            //getting timestamp for all readings 
            double Current_Time = DateTime.Now.ToOADate();
            //getting values for eaach sensor and adding it to the queue
            SensorDataHistory[(int)SensorType.Temperature].Enqueue(temp.GetValueOfsensor());
            SensorDataHistory[(int)SensorType.Humidity].Enqueue(Humidity.GetValueOfsensor());
            SensorDataHistory[(int)SensorType.Pressure].Enqueue(Pressure.GetValueOfsensor());
            TimeStamp.Enqueue(Current_Time);
            //we only need to keep track of one queue size
            if (SensorDataHistory[0].Count > 30)
            {
                //getting rid of oldest value for each queue. There is a better way of doin this.Too much repition and very messy. Create a loop from 0-4 to deque...same for emqueue 
                SensorDataHistory[0].Dequeue();
                SensorDataHistory[1].Dequeue();
                SensorDataHistory[2].Dequeue();
                TimeStamp.Dequeue();
            }

        }
        //creating helper method to enqueue and dequeue
    }
}
