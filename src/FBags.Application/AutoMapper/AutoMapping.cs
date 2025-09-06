using FBags.Communication.Requests;
using FBags.Communication.Responses;
using FBags.Domain.Entities;

namespace FBags.Application.AutoMapper;
public static class AutoMapping
{


    public static Bag RequestToEntity(this RequestRegisterBagJson request)
    {
        return new Bag
        {
            Model = request.Model,
            Description = request.Description,
            Price = request.Price,
            Color = request.Color,
            UrlImage = request.UrlImage,
            PaymentType = (Domain.Enums.PaymentType)request.PaymentType,
        };
    }
    

    public static ResponseRegisteredBagJson EntityToResponse(this Bag bag)
    {
        return new ResponseRegisteredBagJson
        {
            Model = bag.Model,
            Color = bag.Color,
            Price = bag.Price,
            PaymentType = (Communication.Enums.PaymentType)bag.PaymentType,
        };
    }
}
