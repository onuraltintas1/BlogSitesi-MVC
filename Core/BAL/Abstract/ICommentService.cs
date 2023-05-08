using EntityLayer.Concrete;

namespace BAL.Abstract;

public interface ICommentService
{
    void CommentAdd(Comment comment);
    //void CommentDelete(Category category);
    //void CommentUpdate(Category category);
    List<Comment> GetList(int id);
    //Comment? GetById(int id);
}