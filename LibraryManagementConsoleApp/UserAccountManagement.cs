using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementConsoleApp
{
    class UserAccountManagement
    {

        private GenericCRUD<User> crud = new();

        public void AddUser(User user)
        {
            crud.Add(user);
        }

        public void RemoveUser(User user)
        {
            crud.Remove(user);
        }

        public void UpdateUser(User user, User updatedUser)
        {
            crud.Update(user, updatedUser);
        }

        public List<User> GetAllUsers()
        {
            return crud.GetAll();
        }

    }
}
