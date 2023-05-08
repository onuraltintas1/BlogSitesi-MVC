using EntityLayer.Concrete;

namespace BAL.Abstract;

public interface IMessageService : IGenericService<Message>
{
    List<Message> GetInboxListByWriter(string p);
}