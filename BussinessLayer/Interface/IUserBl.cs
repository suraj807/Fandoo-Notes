using DatabaseLayer.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessLayer.Interface
{
    public interface IUserBl
    {
        public void AddUser(UserPostModel userPostModel);
    }
}
