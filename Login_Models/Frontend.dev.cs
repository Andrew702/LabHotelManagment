using System;
using System.Collections.Generic;
using System.Text;

namespace LabHotelManagment.Login_Models
{
    public partial class Frontend
    {
        public override int GetHashCode() => HashCode.Combine(UserName, PassWord);
        public override bool Equals(object? obj)
        {
            if (obj is Frontend other && other != null)
                return UserName.Equals(other.UserName) && PassWord.Equals(other.PassWord);
            else
                return false;
        }
    }
}
