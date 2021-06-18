using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace MedicineTrackingSystem.BusinessModel
{
    [DataContract]
    public class ResponseModel<T>
    {
        [DataMember]
        public bool IsSuccess { get; set; }

        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public T Data { get; set; }

    }
}
