using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LabHotelManagment.Entities
{
    /*[room_type] [nchar](10) NULL,
				[room_floor] [nchar](10) NULL,
				[room_number] [nchar](10) NULL,*/

    public enum RoomType
    {
        Single,
        Double,
        Triple
    }

    public class Room
    {
        [Key]
        public int RoomNumber { set; get; }

        public required RoomType Type { set; get; }    //single and double options only

        public int floor { set; get; }
    }
}
