using FBags.Application.AutoMapper;
using FBags.Communication.Requests;
using FBags.Communication.Responses;
using FBags.Domain;
using FBags.Domain.Repositories.Bags;
using FBags.Exception.ExceptionBase;

namespace FBags.Application.UseCases.Bags.Register;
public class RegisterBagsUseCase : IRegisterBagsUseCase
{
    private readonly IBagsRepository _bagsRepository;
    private readonly IUnitOfWork _unitOfWork;

    public RegisterBagsUseCase(
        IBagsRepository bagsRepository,
        IUnitOfWork unitOfWork)
    {
        _bagsRepository = bagsRepository;
        _unitOfWork = unitOfWork;
    }

    public ResponseRegisteredBagJson Execute(RequestRegisterBagJson request)
    {
        Validate(request);

        var entity = request.RequestToEntity();

        _bagsRepository.Add(entity);

        _unitOfWork.Commit();

        return entity.EntityToResponse();
    }

    private void Validate(RequestRegisterBagJson request)
    {
        var validator = new RegisterBagsValidator().Validate(request);

        if (!validator.IsValid)
        {
            var errorMessages = validator.Errors.Select(e => e.ErrorMessage).ToList();

            throw new ValidationError(errorMessages);
        }
    }
}
