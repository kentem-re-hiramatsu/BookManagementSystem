using BookSystem.Cores.Model;
using System.Collections.Generic;

namespace BookSystem.Cores.Manager
{
    public class UserManager
    {
        private List<User> _userDatas = new List<User>();

        public IReadOnlyCollection<User> UserDatas { get { return _userDatas; } }

        public void Add(User user)
        {
            _userDatas.Add(user);
        }

        public User Get(int index)
        {
            return _userDatas[index];
        }
    }
}
