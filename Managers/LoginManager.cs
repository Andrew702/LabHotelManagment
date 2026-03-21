using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Text;
using Dapper;
using LabHotelManagment.Entities;

namespace LabHotelManagment
{
    public class LoginManager : IManager<Login>
    {
        DbConnection CN = new SqlConnection(ConfigurationManager.ConnectionStrings["hotel"].ConnectionString);

        public bool Add(Login item)
        {
            try
            {
                return CN.Execute("INSERT INTO Logins (Username, Password, AccType) VALUES (@Username,@Password,@AccType)", item) > 0;
            }
            catch { throw; }
        }

        public bool Delete(object ID)
        {
            try
            {
                return CN.Execute("DELETE FROM Logins WHERE (Username = @Username)", new {Username = (string)ID}) > 0;
            }
            catch {   throw; }
        }

        public List<Login> GetAll()
        {
            try
            {
                if (CN.Query<Login>("Select * from Logins") is List<Login> ResList)
                    return ResList;
                else
                    return new List<Login>();
            }
            catch{throw;}
        }

        public Login GetOne(object ID)
        {
            if (CN.QueryFirstOrDefault<Login>("Select * from Logins where Username = @Username", new {Username = (string)ID}) is Login Res)
                return Res;
            else
                return new Login() { AccType = 0 , Username = "NA", Password = "NA" };
        }

        public bool Update(Login item)
        {
            try
            {
               return CN.Execute("UPDATE Logins SET Password = @Password, AccType = @AccType WHERE (Username = @Username)", item) > 0;
            }
            catch {throw;}
        }
    }
}
