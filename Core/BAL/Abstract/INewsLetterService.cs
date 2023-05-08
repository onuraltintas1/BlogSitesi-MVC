using EntityLayer.Concrete;

namespace BAL.Abstract;

public interface INewsLetterService
{
    void AddNewsLetter(NewsLetter newsLetter);
}