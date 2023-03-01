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
        /// <summary>
        /// hash leme olmadan kullanıcı adı ve şifre varmı kontrolünü yapar. Bu method kullanılmıyor.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool CheckCredential(string username, string password)
        {
            return Any(x => x.Username == username && x.Password == password);
        }
        /// <summary>
        /// ash leme olmadan kullanıcı adı kontrolünü yapar. Bu method kullanılmıyor.
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public bool CheckCredential(string username)
        {
            return Any(x => x.Username == username);
        }
    }
}
