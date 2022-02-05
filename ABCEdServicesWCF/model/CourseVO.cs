using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ABCEdServicesWCF.model
{
    [DataContract]
    public class CourseVO
    {
        [DataMember]
        public string CourseID { get; set; }
        [DataMember]
        public string CourseName { get; set; }
        [DataMember]
        public Nullable<decimal> Cost { get; set; }
    }
}