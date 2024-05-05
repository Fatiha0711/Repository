using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceRepository.DataAccessLayer
{
    public class CustomerRepository : ICustomerRepository
    {
        List<Customer> listCustomer = new List<Customer>()
        {
            new Customer(1, "Kaniz", "Dhaka"),
            new Customer(2, "Tamanna", "Khulna"),
            new Customer(3, "Shauli", "Jhinaidah"),
            new Customer(4, "Rimpy", "Jashore")
        };
        public List<Customer> Get()
        {
            return listCustomer.OrderBy(x => x.Name).ToList();
        }

        public Customer Get(int id)
        {
            Customer oCustomer = listCustomer.Where(x => x.Id == id).FirstOrDefault();
            return oCustomer;
        }

        public bool Add(Customer model)
        {
            listCustomer.Add(model);
            return true;
        }

        public bool Update(Customer model)
        {
            bool isExecuted = false;
            Customer oCustomer = listCustomer.Where(x => x.Id == model.Id).FirstOrDefault();
            if (oCustomer != null)
            {
                listCustomer.Remove(oCustomer);
                listCustomer.Add(model);
                isExecuted = true;
            }
            return isExecuted;
        }

        public bool Delete(int id)
        {
            bool isExecuted = false;
            Customer oCustomer = listCustomer.Where(x => x.Id == id).FirstOrDefault();
            if (oCustomer != null)
            {
                listCustomer.Remove(oCustomer);
                isExecuted = true;
            }
            return isExecuted;
        }
    }
}
