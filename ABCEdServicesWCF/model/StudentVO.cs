using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ABCEdServicesWCF.model
{
    [DataContract]
    public class StudentVO
    {
        [DataMember]
        public string StudentID { get; set; }
        [DataMember]
        public string StudentName { get; set; }
        [DataMember]
        public Nullable<System.DateTime> DateEnrolled { get; set; }
    }
}