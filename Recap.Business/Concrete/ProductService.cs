using Recap.Business.Abstract;
using Recap.Core.Enum;
using Recap.DataAccess.Repositories.Abstract;
using Recap.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap.Business.Concrete
{
    public class ProductService: IProductService
    {
        IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void Add(Product product)
        {
            _productRepository.Add(product);
        }

        public void Delete(Product product)
        {
            _productRepository.Delete(product);
        }

        public List<Product> GetActives()
        {
            return _productRepository.GetAll(x => x.Status == Status.Active || x.Status == Status.Updated);
        }

        public Product GetById(Guid id)
        {
          return _productRepository.Get(id);
        }

        public void Update(Product product)
        {
            _productRepository.Update(product);
        }
    }
}
