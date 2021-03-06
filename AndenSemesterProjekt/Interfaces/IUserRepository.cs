using AndenSemesterProjekt.Models;
using AndenSemesterProjekt.Pages.Users;
using System;
using System.Collections.Generic;

namespace AndenSemesterProjekt.Interfaces
{
    public interface IUserRepository
    {
		IEnumerable<User> FilterUser(string criteria);
		IEnumerable<User> GetAllPUser();
		User GetUser(int id);
		User AddUser(User u);
		User UpdateUser(User u);
		User RemoveUser(int id);
        void AddUser(CreateUsersModel users);
    }
}
