using LabHotelManagment.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Dapper;
using System.Data.Common;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace LabHotelManagment.Managers
{
    public class RoomManager : IManager<Room>
    {
        DbConnection CN = new SqlConnection(ConfigurationManager.ConnectionStrings["Hotel"].ConnectionString);

        public bool Add(Room item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(object ID)
        {
            throw new NotImplementedException();
        }

        public List<Room> GetAll()
        {
            string sqlcmd = "Select * from Rooms";
            return CN.Query<Room>(sqlcmd).ToList();
        }

        public Room GetOne(object ID)
        {
            throw new NotImplementedException();
        }

        public bool Update(Room item)
        {
            throw new NotImplementedException();
        }
    }
}
