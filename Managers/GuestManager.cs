using LabHotelManagment.Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using Dapper;
using System.Configuration;

namespace LabHotelManagment.Managers
{
    public class GuestManager : IManager<Guest>
    {
        DbConnection CN = new SqlConnection(ConfigurationManager.ConnectionStrings["Hotel"].ConnectionString);

        public bool Add(Guest item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(object ID)
        {
            throw new NotImplementedException();
        }

        public List<Guest> GetAll()
        {
            string sqlcmd = "Select * from Guests";
            return CN.Query<Guest>(sqlcmd).ToList();
        }

        public Guest GetOne(object ID)
        {
            throw new NotImplementedException();
        }

        public bool Update(Guest item)
        {
            throw new NotImplementedException();
        }
    }
}
