﻿using Recap.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap.Business.Abstract
{
    public interface IUserService
    {
        List<User> GetActives();
        User GetById(Guid id);
        void Add(User user);
        void Update(User user);
        void Delete(User user);
        bool CheckCredential(string username, string password);
        bool CheckCredential(string username);
    }
}
