using Behavioral.Obverser.UserRegisterNotification.Models;
using Behavioral.Obverser.UserRegisterNotification.Observer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Obverser.UserRegisterNotification.Observer.Consumer;

internal class UserObserverWriteToConsole : IUserObserver
{
    public void UserCreated(User user)
    {
        Console.WriteLine($"UserName : {user.UserName} Password : {user.Password} created..");
    }
}
