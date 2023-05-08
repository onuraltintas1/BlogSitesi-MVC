using DAL.Abstract;
using DAL.Repositories;
using EntityLayer.Concrete;

namespace DAL.EntityFramework;

public class EfCategoryRepo : GenericRepo<Category> ,ICategoryRepo
{
    
}