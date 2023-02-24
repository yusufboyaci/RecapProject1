using Recap.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetActives();
        Product GetById(Guid id);
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}
