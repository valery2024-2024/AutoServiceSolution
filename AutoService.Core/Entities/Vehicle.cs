namespace AutoService.Core.Entities;

public class Vehicle
{
    public int Id { get; private set; }

    public string Brand { get; private set; }

    public string Model { get; private set; }

    public int Year { get; private set; }

    public string VIN { get; private set; }
    
    // зовнішній ключ
    public int ClientId { get; private set; }
    
    // навігаційна властивість
    public Client Client { get; private set; }

    public List<ServiceRequest> ServiceRequests { get; set; } = new();

    private Vehicle() { }

    public Vehicle(string brand, string model, int year, string vin, int clientId)
    {
        Brand = brand;
        Model = model;
        Year = year;
        VIN = vin;
        ClientId = clientId;
    }
}