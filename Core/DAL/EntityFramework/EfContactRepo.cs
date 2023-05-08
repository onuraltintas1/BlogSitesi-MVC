using DAL.Abstract;
using DAL.Repositories;
using EntityLayer.Concrete;

namespace DAL.EntityFramework;

public class EfContactRepo : GenericRepo<Contact> , IContactRepo
{
    
}