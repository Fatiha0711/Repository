using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceRepository.DataAccessLayer
{
    public interface ICustomerRepository
    {
        List<Customer> Get();
        Customer Get(int id);
        bool Add(Customer model);
        bool Update(Customer model);
        bool Delete(int id);
    }
}
