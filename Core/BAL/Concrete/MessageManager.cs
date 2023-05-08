using System.Linq.Expressions;
using BAL.Abstract;
using DAL.Abstract;
using EntityLayer.Concrete;

namespace BAL.Concrete;

public class MessageManager : IMessageService
{
    private IMessageRepo _messageRepo;

    public MessageManager(IMessageRepo messageRepo)
    {
        _messageRepo = messageRepo;
    }

    public void TAdd(Message t)
    {
         
    }

    public void TDelete(Message t)
    {
        throw new NotImplementedException();
    }

    public void TUpdate(Message t)
    {
        throw new NotImplementedException();
    }

    public List<Message> GetList()
    {
        throw new NotImplementedException();
    }


    public Message? GetById(int id)
    {
        throw new NotImplementedException();
    }

    public List<Message> GetInboxListByWriter(string p)
    {
        return _messageRepo.List(x => x.Receiver == p);
    }

   
}