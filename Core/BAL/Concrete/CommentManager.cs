using BAL.Abstract;
using DAL.Abstract;
using EntityLayer.Concrete;

namespace BAL.Concrete;

public class CommentManager : ICommentService
{
    private ICommentRepo _commentRepo;

    public CommentManager(ICommentRepo commentRepo)
    {
        _commentRepo = commentRepo;
    }
    
    public void CommentAdd(Comment comment)
    {
        _commentRepo.Insert(comment);
    }

    public List<Comment> GetList(int id)
    {
        return _commentRepo.List(x => x.BlogID == id);
    }

    
}