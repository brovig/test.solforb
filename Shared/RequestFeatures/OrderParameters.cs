namespace Shared.RequestFeatures;
public class OrderParameters : RequestParameters
{
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public OrderParameters()
    {
        EndDate = DateTime.Now;
        StartDate = DateTime.MinValue;
    }

    public List<int> OrderIds { get; set; } = new();
    public List<string> OrderNumbers { get; set; } = new();
    public List<int> ProviderIds { get; set; } = new();

    public List<string> OrderItemNames { get; set; } = new();
    public List<string> OrderItemUnits { get; set; } = new();

    public List<string> ProviderNames { get; set; } = new();

    public bool ValidDateRange => EndDate >= StartDate;
}