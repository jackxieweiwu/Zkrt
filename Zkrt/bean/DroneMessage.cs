using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Zkrt.bean
{
    [DataContract]
    class DroneMessage
    {
        [DataMember(Order = 1, Name = "DroneId")]
        public string DroneId { get; set; }
        [DataMember(Order = 2, Name = "DroneGpsLat")]
        public string DroneGpsLat { get; set; }
        [DataMember(Order = 3, Name = "DroneGpsLng")]
        public string DroneGpsLng { get; set; }
        [DataMember(Order = 4, Name = "Drone_alt")]
        public string Drone_alt { get; set; }
        [DataMember(Order = 5, Name = "Drone_y")]
        public string Drone_y { get; set; }
        [DataMember(Order = 6, Name = "Drone_r")]
        public string Drone_r { get; set; }
        [DataMember(Order = 7, Name = "Drone_p")]
        public string Drone_p { get; set; }
    }
}
