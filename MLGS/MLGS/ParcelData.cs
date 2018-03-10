using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MLGS
{
    public class ParcelData
    {
        public int ParcelDataId { get; set; }
        public float Temperature_sensor_value { get; set; }
        public float Pressure_sensor_value { get; set; }
        public float Humidity_value { get; set; }
        public float Light_sensor_value { get; set; }
    }
}
