using BussinessLayer.Interface;
using DatabaseLayer.User;
using RepositoryLayer.Interfaces;
using System;

namespace BuisnessLayer.Services
{
    public class UserBL : IUserBl
    {
        IUserRL userRL;
        public UserBL(IUserRL userRL)
        {
            this.userRL = userRL;
        }

        public void AddUser(UserPostModel userPostModel)
        {
            try
            {
                userRL.AddUser(userPostModel);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}


