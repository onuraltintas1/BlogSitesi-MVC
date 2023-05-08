using BAL.Abstract;
using DAL.Abstract;
using EntityLayer.Concrete;

namespace BAL.Concrete;

public class WriterManager : IWriterService
{
    private IWriterRepo _writerRepo;

    public WriterManager(IWriterRepo writerRepo)
    {
        _writerRepo = writerRepo;
    }

    public void TAdd(Writer t)
    {
        _writerRepo.Insert(t);
    }

    public void TDelete(Writer t)
    {
        _writerRepo.Delete(t);
    }

    public void TUpdate(Writer t)
    {
        _writerRepo.Update(t);
    }

    public List<Writer> GetList()
    {
        throw new NotImplementedException();
    }

    public Writer? GetById(int id)
    {
        return _writerRepo.GetById(id);
    }

    public List<Writer> GetWriterById(int id)
    {
       return _writerRepo.List(x=>x.Id ==id);
    }
}