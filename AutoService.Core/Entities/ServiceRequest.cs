using AutoService.Core.Enums;
namespace AutoService.Core.Entities;

public class ServiceRequest
{
    public int Id { get; set; }

    public string Description { get; set; } = string.Empty;

    public decimal Price { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    
    public ServiceStatus Status { get; set; } = ServiceStatus.New;

    // Foreign Key
    public int VehicleId { get; set; }

    // Navigation
    public Vehicle? Vehicle { get; set; }
}
