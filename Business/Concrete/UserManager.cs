using Business.Abstract;
using DataAccess.Concrete;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public User GetByEmailAndPassword(string email, string password)
        {
            return _userDal.Get(u => u.Email == email && u.Password == password);
        }

        public User Add(User user)
        {
            return _userDal.Add(user);
        }

        public User Delete(User user)
        {
            return _userDal.Delete(user);
        }


        public List<User> GelAll()
        {
            return _userDal.GetAll();
        }

        public User Get(int id)
        {
            return _userDal.Get(x => x.Id == id);
        }

        public User Update(User user)
        {
            return _userDal.Update(user);
        }
    }
}