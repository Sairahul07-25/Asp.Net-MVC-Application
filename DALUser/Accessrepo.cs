using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALUser
{
    public class Accessrepo : IAccessDAL
    {
        private UserContext _context;
        public Accessrepo()
        {
            _context = new UserContext();
        }
        public bool AddUser(User user)
        {
            _context.tbUser.Add(user);
            _context.SaveChanges();
            return true;
        }

        public bool EditUser(User user)
        {
            User oldu = _context.tbUser.Find(user.Id);
            oldu.Id = user.Id;
            oldu.FirstName = user.FirstName;
            oldu.LastName = user.LastName;
            oldu.Email = user.Email;
            oldu.Password = user.Password;
            oldu.IsActive = user.IsActive;
            _context.SaveChanges();
            return true;
        }

        public User GetUser(int id)
        {
            return _context.tbUser.Find(id);
        }

        public List<User> GetUsersList()
        {
            return _context.tbUser.ToList();
        }
    }
}
