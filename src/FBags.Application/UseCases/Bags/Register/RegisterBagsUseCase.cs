using AutoMapper;
using FBags.Communication.Requests;
using FBags.Communication.Responses;
using FBags.Domain;
using FBags.Domain.Entities;
using FBags.Domain.Repositories.Bags;
using FBags.Exception.ExceptionBase;

namespace FBags.Application.UseCases.Bags.Register;
public class RegisterBagsUseCase : IRegisterBagsUseCase
{
    private readonly IBagsRepository _bagsRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public RegisterBagsUseCase(
        IBagsRepository bagsRepository,
        IUnitOfWork unitOfWork,
        IMapper mapper)
    {
        _bagsRepository = bagsRepository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public ResponseRegisteredBagJson Execute(RequestRegisterBagJson request)
    {
        Validate(request);
        
        var entity = _mapper.Map<Bag>(request);

        _bagsRepository.Add(entity);
        
        _unitOfWork.Commit();

        return _mapper.Map<ResponseRegisteredBagJson>(entity);
    }

    private void Validate(RequestRegisterBagJson request)
    {
        var validator = new RegisterBagsValidator().Validate(request);

        if(!validator.IsValid)
        {
            var errorMessages = validator.Errors.Select(e => e.ErrorMessage).ToList();

            throw new ValidationError(errorMessages) ;
        }
    }
}
