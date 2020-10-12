using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OnlineBooksStore.Models
{
    public class Customer
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        
        public bool IsSubscribedToNewsLetter { get; set; }
        
        public MembershipType MembershipType { get; set; }

        //MembershipType value
        [Display(Name ="Membership Type")]
        public byte MembershipTypeId { get; set; }
           
        //This Birthdate is not added in the Details View as there is null reference exception occuring.
        public DateTime? Birthdate { get; set; }

        public DateTime? DateOfBirth { get; set; }
    }
}