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
/*
 * 
    CREATE TABLE [dbo].[reservation](
        [Id] [int] IDENTITY(1011,1) NOT NULL,
        [first_name] [nvarchar](50) NULL,
        [last_name] [nvarchar](50) NULL,
        [birth_day] [nvarchar](50) NULL,
        [gender] [nvarchar](50) NULL,
        [phone_number] [nvarchar](50) NULL,
        [email_address] [nvarchar](max) NULL,
        [number_guest] [int] NULL,
        [street_address] [nvarchar](max) NULL,
        [apt_suite] [nvarchar](50) NULL,
        [city] [nvarchar](max) NULL,
        [state] [nvarchar](50) NULL,
        [zip_code] [nchar](10) NULL,
        [room_type] [nchar](10) NULL,
        [room_floor] [nchar](10) NULL,
        [room_number] [nchar](10) NULL,
        [total_bill] [float] NULL,
        [payment_type] [nchar](10) NULL,
        [card_type] [nchar](10) NULL,
        [card_number] [nvarchar](50) NULL,
        [card_exp] [nvarchar](50) NULL,
        [card_cvc] [nchar](10) NULL,
        [arrival_time] [date] NULL,
        [leaving_time] [date] NULL,
        [check_in] [bit] NULL,
        [break_fast] [int] NULL,
        [lunch] [int] NULL,
        [dinner] [int] NULL,
        [cleaning] [bit] NULL,
        [towel] [bit] NULL,
        [s_surprise] [bit] NULL,
        [supply_status] [bit] NULL,
        [food_bill] [int] NULL,
 */