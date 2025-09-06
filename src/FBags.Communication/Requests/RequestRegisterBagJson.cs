using FBags.Communication.Enums;

namespace FBags.Communication.Requests;
public class RequestRegisterBagJson
{
    public string Model { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string Color { get; set; } = string.Empty;
    public string UrlImage { get; set; } = string.Empty;
    public PaymentType PaymentType { get; set; }

    
}
