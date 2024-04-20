using WireCalc.Client.Models;

namespace WireCalc.Client.ViewModels;

public class PowerLossesViewModel
{
    public double? P { get; set; }
    public double? Q { get; set; }
    public double? V { get; set; }
    public double? L { get; set; }
    public Wire Wire { get; set; } = new();
}