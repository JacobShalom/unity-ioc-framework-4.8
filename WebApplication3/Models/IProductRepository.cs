using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        Product GetById(int id);
        void Add(Product product);
    }


}
