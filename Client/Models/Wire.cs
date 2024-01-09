namespace WireCalc.Client.Models;

public class Wire
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double ActiveResistance { get; set; }
    public double InductivityResistance { get; set; }
}