using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using System.Text;

namespace LabHotelManagment.Entities
{
    public class Reservation
    {
        public int ReservationID { set; get; }
        public int GuestID { set; get; }      
        public Guest Guest { set; get; }    //Navigation Property for guest
        public int RoomNumber { set; get; }
        public Room Room { set; get; }  //NavigationProperty for room
        public bool withFood { set; get; }
        public DateTime From { set; get; }
        public DateTime To { set; get; }
    }
}
