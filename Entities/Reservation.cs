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
        [Key]
        public int ReservationID { set; get; }
        public int GuestID { set; get; }      

        public virtual Guest Guest { set; get; }    //Navigation Property for guest

        [ForeignKey(nameof(Room))]
        public int RoomNumber { set; get; }
        public virtual Room Room { set; get; }  //NavigationProperty for room
        public bool withFood { set; get; }
        public DateTime From { set; get; }
        public DateTime To { set; get; }
        public bool MealDeliveredFlag { set; get; }
        public override string ToString() => $"{Guest.Fname} {Guest.Lname} {RoomNumber}";
        
    }
}
