using Behavioral.Obverser.UserRegisterNotification.Models;
using Behavioral.Obverser.UserRegisterNotification.Observer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Obverser.UserRegisterNotification.Observer.Publisher
{
    public class UserObserverSubject
    {
        private readonly List<IUserObserver> _userObservers;

        public UserObserverSubject()
        {
            _userObservers = new List<IUserObserver>();
        }

        public void RegisterObserver(IUserObserver userObserver)
        {
            _userObservers.Add(userObserver);
        }

        public void RemoveObserver(IUserObserver userObserver)
        {
            _userObservers.Remove(userObserver);
        }

        public void NotifyObserver(User user)
        {
            _userObservers.ForEach(x =>
            {
                x.UserCreated(user);
            });
        }
    }
}
