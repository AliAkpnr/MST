using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IUserService
    {
        List<User> GelAll();

        User Get(int id);

        User GetByEmailAndPassword(string email, string password);

        User Add(User user);

        User Update(User user);
        User Delete(User user);
    }
}