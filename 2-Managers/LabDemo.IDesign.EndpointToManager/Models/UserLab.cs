namespace LabDemo.IDesign.EndpointToManager.Models;

/// <summary>
/// Minimal model for client-manager and manager-engine interactions
/// No methods, no extension methods
/// Treat as an old-style struct
/// </summary>
public class UserLab
{
    public string Name { get; set; } = string.Empty;
    public decimal Measurement { get; set; } = decimal.Zero;
    public string UnitsOfMeasure { get; set; } = string.Empty;
}
