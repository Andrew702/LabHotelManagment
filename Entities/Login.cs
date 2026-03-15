using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LabHotelManagment.Entities
{
    public enum AccType
    {
        Kitchen,
        Reservation
    }

    public class Login
    {
        [Key]
        [Required]
        [MaxLength(20)]
        public required string Username { set; get; }

        [Required]
        [MaxLength(20)]
        public required string Password { set; get; }

        [Required]
        public required AccType AccType { set; get; }
    }
}
