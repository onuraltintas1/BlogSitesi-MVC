using BAL.Abstract;
using DAL.Abstract;
using EntityLayer.Concrete;

namespace BAL.Concrete;

public class NotificationManager : INotificationService
{
    private INotificationRepo _notificationRepo;

    public NotificationManager(INotificationRepo notificationRepo)
    {
        _notificationRepo = notificationRepo;
    }

    public void TAdd(Notification t)
    {
        _notificationRepo.Insert(t);
    }

    public void TDelete(Notification t)
    {
        _notificationRepo.Delete(t);
    }

    public void TUpdate(Notification t)
    {
        _notificationRepo.Update(t);
    }

    public List<Notification> GetList()
    {
        return _notificationRepo.GetListAll();
    }

    public Notification? GetById(int id)
    {
        throw new NotImplementedException();
    }
}