using Recap.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetActives();
        Category GetById(Guid id);
        void Add(Category category);
        void Update(Category category);
        void Delete(Category category);
    }
}
