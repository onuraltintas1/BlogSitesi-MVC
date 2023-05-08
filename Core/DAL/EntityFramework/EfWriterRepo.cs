using DAL.Abstract;
using DAL.Repositories;
using EntityLayer.Concrete;

namespace DAL.EntityFramework;

public class EfWriterRepo: GenericRepo<Writer> , IWriterRepo
{
    
}