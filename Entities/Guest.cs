using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LabHotelManagment.Entities
{
	public enum Gender
	{
		Male,
		Female
	}
    public class Guest
    {
        [Key]
        public int ID { set; get; }

		[Required]
        [MaxLength(20)]
        public string Fname { set; get; }
        
        [MaxLength(20)]
        public string Lname { set; get; }

		public DateTime? BDay { set; get; }

		[MaxLength(20)]
		public string PhoneNo { set; get; }

		public required Gender Gender { set; get; }

    }
}
