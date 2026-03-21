using LabHotelManagment.Entities;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Text;
using Dapper;
using System.Data.Common;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace LabHotelManagment.Managers
{
    internal class ReservationManager : IManager<Reservation>
    {
        DbConnection CN = new SqlConnection(ConfigurationManager.ConnectionStrings["Hotel"].ConnectionString);


        public bool Add(Reservation item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(object ID)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> GetAll()
        {
            string sqlcmd = """
                                SELECT Reservations.* , Guests.*, Rooms.*
                                FROM   Guests
                                INNER JOIN  Reservations ON Guests.ID = Reservations.GuestID 
                                INNER JOIN  Rooms ON Reservations.RoomNumber = Rooms.RoomNumber

                """;


            var ResList = CN.Query<Reservation, Guest, Room, Reservation>(sqlcmd, (R, G, Rm) =>
            {
                R.Guest = G;
                R.Room = Rm;
                return R;
            } , splitOn: "ID,RoomNumber");

            return ResList.ToList();
        }

        public Reservation GetOne(object ID)
        {
            throw new NotImplementedException();
        }

        public bool Update(Reservation item)
        {
            throw new NotImplementedException();
        }
    }
}
