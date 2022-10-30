using Behavioral.Obverser.UserRegisterNotification.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Obverser.UserRegisterNotification.Observer.Abstract
{
    public interface IUserObserver
    {
        void UserCreated(User user);
    }
}
