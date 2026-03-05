using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmniPowerAssignment
{
    public class Sensor
    {

        String NameOfSensor;
        String Units;
        int rangeOf;
        Random rand = new Random();


        public Sensor(string NameOfSensor, String Unit, int rangeOf)
        {
            this.NameOfSensor = NameOfSensor;
            this.Units = Unit;
            this.rangeOf = rangeOf;
        }
        public double GetValueOfsensor()
        {
            return rand.Next(rangeOf);

        }





    }
}
