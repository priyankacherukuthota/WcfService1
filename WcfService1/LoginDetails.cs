using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService1
{
    [DataContract]
    [Table("tblLoginDetails")]
    public class LoginDetails
    {
        [DataMember]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        
        public string CustomerName { get; set; }
        public string Password { get; set; }
        public string ConfirmPass { get; set; }


        public System.DateTime Dob { get; set; }
        public int Contactno { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public int Pincode { get; set; }

        public string Citizen { get; set; }

        public string Type { get; set; }



    }
}