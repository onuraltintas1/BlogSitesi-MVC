using BAL.Abstract;
using DAL.Abstract;
using EntityLayer.Concrete;

namespace BAL.Concrete;

public class NewsLetterManager : INewsLetterService
{
    private INewsLetterRepo _newsLetterRepo;

    public NewsLetterManager(INewsLetterRepo newsLetterRepo)
    {
        _newsLetterRepo = newsLetterRepo;
    }
    public void AddNewsLetter(NewsLetter newsLetter)
    {
        _newsLetterRepo.Insert(newsLetter);
    }
}