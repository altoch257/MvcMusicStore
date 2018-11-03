using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Models
{
    public class Order
    {
        public int OrderID { get; set; }

        public DateTime OrderDate { get; set; }

        [Remote("checkUserName", "Account")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Your First Name is required.")]
        [StringLength(10, MinimumLength =3)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Your Last Name is required.")]
        [StringLength(160, ErrorMessage = "Last Name must be less than 160 characters.")]
        public string LastName { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string PostalCode { get; set; }

        public string Country { get; set; }

        public string Phone { get; set; }

        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", 
                            ErrorMessage = "You must enter a valid email address.")]
        public string Email { get; set; }

        public decimal Total { get; set; }
    }
}