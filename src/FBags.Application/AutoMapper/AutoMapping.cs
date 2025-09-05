using AutoMapper;
using FBags.Communication.Requests;
using FBags.Communication.Responses;
using FBags.Domain.Entities;

namespace FBags.Application.AutoMapper;
public class AutoMapping : Profile
{

    public AutoMapping()
    {
        RequestToEntity();
        EntityToResponse();
    }

    private void RequestToEntity()
    {
        CreateMap<RequestRegisterBagJson, Bag>();
    }

    private void EntityToResponse()
    {
        CreateMap<Bag, ResponseRegisteredBagJson>();
    }
}
