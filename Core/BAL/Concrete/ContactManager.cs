using BAL.Abstract;
using DAL.Abstract;
using EntityLayer.Concrete;

namespace BAL.Concrete;

public class ContactManager : IContectService
{
    private IContactRepo _contactRepo;

    public ContactManager(IContactRepo contactRepo)
    {
        _contactRepo = contactRepo;
    }

    public void ContactAdd(Contact contact)
    {
        _contactRepo.Insert(contact);
    }
}