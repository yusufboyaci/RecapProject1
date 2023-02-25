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
    public class CategoryService : ICategoryService
    {
        ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public void Add(Category category)
        {
            _categoryRepository.Add(category);
        }

        public void Delete(Category category)
        {
            _categoryRepository.Delete(category);
        }

        public List<Category> GetActives()
        {
            return _categoryRepository.GetAll(x => x.Status == Status.Active || x.Status == Status.Updated).ToList();
        }

        public Category GetById(Guid id)
        {
            return _categoryRepository.Get(id);
        }

        public void Update(Category category)
        {
            _categoryRepository.Update(category);
        }
    }
}
