using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Db 
    {
        public Db()
        {
            Products = new Collection<Product> {
                        new Product { Price = 35, Id = 1, Name = "my product" }
            };
        }
        public Collection<Product> Products { get; set; }
    }

    public class ProductRepository : IDisposable , IProductRepository
    {
        private Db db = new Db();

        public IEnumerable<Product> GetAll()
        {
            return db.Products;
        }

        public void Add(Product product)
        {
            db.Products.Add(product);
 
        }

        protected void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (db != null)
                {

                    db = null;
                }
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public Product GetById(int id)
        {
            return db.Products.FirstOrDefault(p => p.Id == id);
        }
    }
}