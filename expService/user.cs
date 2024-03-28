using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace expService
{
    [DataContract]
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [DataMember]
        public string UserName { get; set; }

        [DataMember]
        public string email { get; set; }

        [DataMember]
        public string password { get; set; }
    }
}