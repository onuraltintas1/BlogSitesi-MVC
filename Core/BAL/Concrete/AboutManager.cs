using BAL.Abstract;
using DAL.Abstract;
using EntityLayer.Concrete;

namespace BAL.Concrete;

public class AboutManager : IAboutService
{
    private IAboutRepo _aboutRepo;

    public AboutManager(IAboutRepo aboutRepo)
    {
        _aboutRepo = aboutRepo;
    }

    public void TAdd(About t)
    {
        throw new NotImplementedException();
    }

    public void TDelete(About t)
    {
        throw new NotImplementedException();
    }

    public void TUpdate(About t)
    {
        throw new NotImplementedException();
    }

    public List<About> GetList()
    {
       return _aboutRepo.GetListAll();
    }

    public About? GetById(int id)
    {
        throw new NotImplementedException();
    }
}