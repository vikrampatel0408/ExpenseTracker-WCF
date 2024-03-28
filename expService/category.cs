using System;
using System.Runtime.Serialization;

namespace expService
{
    [DataContract]
    public class Category
    {
        [DataMember]
        public int CategoryId { get; set; }

        [DataMember]
        public string CategoryName { get; set; }
    }
}