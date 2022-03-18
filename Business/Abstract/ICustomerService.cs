using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        List<Customer> GelAll();

        Customer Get(int id);

        Customer Add(Customer customer);

        Customer Update(Customer customer);
        Customer Delete(Customer customer);

    }


}