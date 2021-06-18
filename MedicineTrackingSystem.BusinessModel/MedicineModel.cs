using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace MedicineTrackingSystem.BusinessModel
{
    [DataContract]
    public class Medicine
    {
        [DataMember]
        [Key]
        public int MedicineId { get; set; }

        [DataMember]
        public string MedicineName { get; set; }

        [DataMember]
        public string Brand { get; set; }

        [DataMember]
        public decimal Price { get; set; }

        [DataMember]
        public int Quantity { get; set; }

        [DataMember]
        public DateTime ExpiryDate { get; set; }

        [DataMember]
        public string Notes { get; set; }

    }
}
