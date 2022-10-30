using Behavioral.Obverser.UserRegisterNotification.Models;
using Behavioral.Obverser.UserRegisterNotification.Observer.Consumer;
using Behavioral.Obverser.UserRegisterNotification.Observer.Publisher;

var userObserverSubject = new UserObserverSubject();
userObserverSubject.RegisterObserver(new UserObserverWriteToConsole());
userObserverSubject.RegisterObserver(new UserObserverSendMail());
userObserverSubject.RegisterObserver(new UserObsorverCreateDiscount());

var user1 = new User
{
    Id = 1,
    UserName = "User1",
    Password = "123456",
    Email = "User1@mail.com",
};

var user2 = new User
{
    Id = 2,
    UserName = "User2",
    Password = "123456",
    Email = "User2@mail.com",
};

userObserverSubject.NotifyObserver(user1);
Console.WriteLine();
userObserverSubject.NotifyObserver(user2);

Console.ReadLine();

