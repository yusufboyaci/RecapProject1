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
    public class UserService : IUserService
    {
        IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void Add(User user)
        {
            user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);//Servis katmanına bu tür özel durumları ekleyebilmek için ihtiyaç duyarız
            _userRepository.Add(user);
        }

        public bool CheckCredential(string username, string password)
        {
            password = BCrypt.Net.BCrypt.HashPassword(password);
            return _userRepository.CheckCredential(username, password);
        }

        public void Delete(User user)
        {
            _userRepository.Delete(user);
        }

        public List<User> GetActives()
        {
            return _userRepository.GetAll(x => x.Status == Status.Active || x.Status == Status.Updated);
        }

        public User GetById(Guid id)
        {
            return _userRepository.Get(id);
        }

        public void Update(User user)
        {
            _userRepository.Update(user);
        }
    }
}
