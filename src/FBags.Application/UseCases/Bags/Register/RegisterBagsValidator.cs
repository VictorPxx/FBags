using FBags.Communication.Requests;
using FBags.Exception;
using FluentValidation;

namespace FBags.Application.UseCases.Bags.Register;
public class RegisterBagsValidator : AbstractValidator<RequestRegisterBagJson>
{
    public RegisterBagsValidator ()
    {
        RuleFor(x => x.Model).NotEmpty().WithMessage(ResourceErrorMessages.REQUIRED_MODEL);
        RuleFor(x => x.Color).NotEmpty().WithMessage(ResourceErrorMessages.REQUIRED_COLOR);
        RuleFor(x => x.UrlImage).NotEmpty().WithMessage(ResourceErrorMessages.REQUIRED_IMAGE_URL);
        RuleFor(x => x.Price).GreaterThan(0).WithMessage(ResourceErrorMessages.PRICE_LESS_THAN_ZERO);
    }
}
