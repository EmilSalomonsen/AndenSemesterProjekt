using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AndenSemesterProjekt.Models

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
	}
}
