using Recap.DataAccess.EntityFramework.Context;
using Recap.DataAccess.Repositories.Abstract;
using Recap.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap.DataAccess.Repositories.Concrete
{
    public class EfCategoryRepository : EfEntityRepositoryBase<Category, AppDbContext>, ICategoryRepository
    {
    }
}
