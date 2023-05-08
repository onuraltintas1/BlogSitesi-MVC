using EntityLayer.Concrete;
using FluentValidation;

namespace BAL.Validators;

public class BlogValidator : AbstractValidator<Blog>
{
    public BlogValidator()
    {
        RuleFor(x => x.Title).NotEmpty().WithMessage("Blog başlığını boş geçemezsiniz");
        RuleFor(x => x.Content).NotEmpty().WithMessage("İçeriği boş geçemezsiniz");
        RuleFor(x => x.Image).NotEmpty().WithMessage("Blog görselini boş geçemezsiniz");
        RuleFor(x => x.Title).MaximumLength(150).WithMessage("Lütfen 150 karakterden az giriş yapın");
        RuleFor(x => x.Title).MinimumLength(5).WithMessage("Lütfen 5 karakterden fazla giriş yapın");
    }
}