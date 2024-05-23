namespace LabDemo.IDesign.Accessors;

public class UserLabEntity
{
    public long Id { get; set; } = 0;
    public DateTime DateOfLab { get; set; } = default(DateTime);
    public string Name { get; set; } = string.Empty;
    public decimal Measurement { get; set; } = decimal.Zero;
    public string UnitsOfMeasure { get; set; } = string.Empty;
}