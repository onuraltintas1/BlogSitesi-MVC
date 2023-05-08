using EntityLayer.Concrete;

namespace BAL.Abstract;

public interface IWriterService : IGenericService<Writer>
{
    List<Writer> GetWriterById(int id);
}