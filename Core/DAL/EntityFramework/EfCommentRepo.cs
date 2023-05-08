using DAL.Abstract;
using DAL.Repositories;
using EntityLayer.Concrete;

namespace DAL.EntityFramework;

public class EfCommentRepo: GenericRepo<Comment> , ICommentRepo
{
    
}