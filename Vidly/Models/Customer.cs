using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public bool IsSubscribedToNewLetter { get; set; }
        public MemberShipType MemberShipType { get; set; }
        public byte MemberShipTypeId { get; set; }
        [Display(Name = "Date of Birth")]
        [Min18YearsIfAMember]
        public DateTime? BirthDate { get; set; }
    }
}