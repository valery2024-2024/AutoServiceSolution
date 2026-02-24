namespace AutoService.Core.Entities;

public class ServiceRequest
{
    public int Id { get; set; }

    public string Description { get; set; } = string.Empty;

    public decimal Price { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    // Foreign Key
    public int VehicleId { get; set; }

    // Navigation
    public Vehicle? Vehicle { get; set; }
}