using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALUser
{
    public interface IAccessDAL
    {
        public bool AddUser(User user);
        public bool EditUser(User user);
        public User GetUser(int id);
        public List<User> GetUsersList();
    }
}
