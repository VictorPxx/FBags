using FBags.Communication.Requests;
using FBags.Communication.Responses;

namespace FBags.Application.UseCases.Bags.Register;
public interface IRegisterBagsUseCase
{
    ResponseRegisteredBagJson Execute(RequestRegisterBagJson request);
}
