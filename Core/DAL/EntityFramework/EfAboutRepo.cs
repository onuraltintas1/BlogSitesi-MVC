using DAL.Abstract;
using DAL.Repositories;
using EntityLayer.Concrete;

namespace DAL.EntityFramework;

public class EfAboutRepo: GenericRepo<About> , IAboutRepo
{
    
}