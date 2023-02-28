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
    public class EfUserRepository : EfEntityRepositoryBase<User, AppDbContext>, IUserRepository
    {
        public bool CheckCredential(string username, string password)
        {
            return Any(x => x.Username == username && x.Password == password);
        }
    }
}
