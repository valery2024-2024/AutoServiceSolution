namespace AutoService.Core.Entities;

public class Client
{
    public int Id { get; private set; }

    public string Name { get; private set; }

    public string Phone { get; private set; }

    public ICollection<Vehicle> Vehicles { get; private set; } = new List<Vehicle>();

    private Client() { } // Для EF Core

    public Client(string name, string phone)
    {
        Name = name;
        Phone = phone;
    }
}