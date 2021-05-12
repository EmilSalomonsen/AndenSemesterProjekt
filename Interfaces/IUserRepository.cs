using AndenSemesterProjekt.Pages.Users;
using System;
using System.Collections.Generic;
using AndenSemesterProjekt.Models;

namespace AndenSemesterProjekt.Interfaces
{
    public interface IUserRepository
    {
        IEnumerable<Users> FilterUser(string criteria);
        IEnumerable<Users> GetAllPUser();
        Users GetUser(int id);
        Users AddUser(Users u);
        Users UpdateUser(Users u);
        Users RemoveUser(int id);
        void AddUser(CreateUsersModel users);
    }
}