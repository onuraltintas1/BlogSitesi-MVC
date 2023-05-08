using EntityLayer.Concrete;
using FluentValidation;

namespace BAL.Validators;

public class WriterValidator : AbstractValidator<Writer>
{
    public WriterValidator()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("Yazar adı boş geçilemez");
        RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail boş geçilemez");
        RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre boş geçilemez");
        RuleFor(x => x.Name).MinimumLength(2).WithMessage("En az 2 karakter girilebilir.");
        RuleFor(x => x.Name).MaximumLength(30).WithMessage("En fazla 30 karakter girilebilir.");
    }
}