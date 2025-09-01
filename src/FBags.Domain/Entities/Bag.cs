using FBags.Domain.Enums;

namespace FBags.Domain.Entities;
public class Bag
{
    public long Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public string Color { get; set; } = string.Empty;
    public string UrlImage { get; set; } = string.Empty;
    public PaymentType PaymentType { get; set; }
}
