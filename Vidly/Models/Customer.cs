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
        public string Name { get; set; }
        public bool IsSubscribedToNewLetter { get; set; }
        public MemberShipType MemberShipType { get; set; }
        public byte MemberShipTypeId { get; set; }
        public DateTime? BirthDate { get; set; }
    }
}