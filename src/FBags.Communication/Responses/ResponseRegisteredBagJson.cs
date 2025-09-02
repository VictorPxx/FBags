using FBags.Communication.Enums;

namespace FBags.Communication.Responses;
public class ResponseRegisteredBagJson
{
    public long Id { get; set; }
    public string Model { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string Color { get; set; } = string.Empty;
    public PaymentType PaymentType { get; set; }
}
