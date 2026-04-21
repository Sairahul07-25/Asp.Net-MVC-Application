using DALUser;
using Microsoft.AspNetCore.Mvc;

namespace PALUser.Controllers
{
    public class UserController : Controller
    {
        private IAccessDAL _repo;
        public UserController(IAccessDAL repo)
        {
            _repo = repo;
        }
        public List<DALUser.User> userL = new List<DALUser.User>();
        public List<MVCUser> mvcuL = new List<MVCUser>();
        public IActionResult Index()
        {
            userL = _repo.GetUsersList();
            foreach(var item in userL)
            {
                MVCUser mu = new MVCUser();
                mu.Id = item.Id;
                mu.FirstName = item.FirstName;
                mu.LastName = item.LastName;
                mu.Email = item.Email;
                mu.Password = item.Password;
                mu.IsActive = item.IsActive;
                mvcuL.Add(mu);
            }
            return View(mvcuL);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(MVCUser mu)
        {
            DALUser.User user = new DALUser.User();
            user.Id = mu.Id;
            user.FirstName = mu.FirstName;
            user.LastName = mu.LastName;
            user.Email = mu.Email;
            user.Password = mu.Password;
            user.IsActive = mu.IsActive;
            _repo.AddUser(user);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            DALUser.User u = _repo.GetUser(id);
            MVCUser mu = new MVCUser();
            mu.Id = u.Id;
            mu.FirstName = u.FirstName;
            mu.LastName = u.LastName;
            mu.Email = u.Email;
            mu.Password = u.Password;
            mu.IsActive = u.IsActive;
            return View(mu);
        }
        [HttpPost]
        public IActionResult Edit(MVCUser mu)
        {
            DALUser.User u = new DALUser.User();
            u.Id = mu.Id;
            u.FirstName = mu.FirstName;
            u.LastName = mu.LastName;
            u.Email = mu.Email;
            u.Password = mu.Password;
            u.IsActive = mu.IsActive;
            _repo.EditUser(u);
            return RedirectToAction("Index");
        }
    }
}
