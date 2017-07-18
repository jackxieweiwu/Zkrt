using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Zkrt.bean
{
    [DataContract]
    class Ip
    {
        [DataMember(Order = 1, Name = "status")]
        public string status { get; set; }
        [DataMember(Order = 2, Name = "info")]
        public string info { get; set; }
        [DataMember(Order = 3, Name = "infocode")]
        public string infocode { get; set; }
        [DataMember(Order = 4, Name = "province")]
        public string province { get; set; }
        [DataMember(Order = 5, Name = "city")]
        public string city { get; set; }
        [DataMember(Order = 6, Name = "adcode")]
        public string adcode { get; set; }
        [DataMember(Order = 7, Name = "rectangle")]
        public string rectangle { get; set; }
    }
}
