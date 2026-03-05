using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmniPowerAssignment
{
    public class Sensor
    {
        //object indicating name, units, and range of sensor
        private String NameOfSensor;
        private String Units;
        private int rangeOf;
        private Random rand = new Random();


        //constructor for setting values
        public Sensor(string NameOfSensor, String Unit, int rangeOf)
        {
            this.NameOfSensor = NameOfSensor;
            this.Units = Unit;
            this.rangeOf = rangeOf;
        }



        //function of double type to return random value
        public double GetValueOfsensor()
        {
            return rand.Next(rangeOf);

        }





    }
}
