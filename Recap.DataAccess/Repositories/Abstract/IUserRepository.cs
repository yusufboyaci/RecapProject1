using Recap.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap.DataAccess.Repositories.Abstract
{
    public interface IUserRepository : IEntityRepository<User>
    {
        bool CheckCredential(string username, string password);
        bool CheckCredential(string username);
    }
}
