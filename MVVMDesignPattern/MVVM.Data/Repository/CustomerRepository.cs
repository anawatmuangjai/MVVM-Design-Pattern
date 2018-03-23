using MVVM.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Data.Repository
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
    }
}
