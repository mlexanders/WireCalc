using WireCalc.Client.Models;

namespace WireCalc.Client.Repository;

public class WireRepository
{
    public List<Wire> WiresFromAirLine => new()
    {
        new Wire
        {
            Id = 1,
            Name = "AC-50/8",
            ActiveResistance = 0.595,
            InductivityResistance = 0.4
        },

        new Wire
        {
            Id = 2,
            Name = "AC-70/11",
            ActiveResistance = 0.422,
            InductivityResistance = 0.4
        },

        new Wire
        {
            Id = 3,
            Name = "AC-96/16",
            ActiveResistance = 0.301,
            InductivityResistance = 0.4
        },

        new Wire
        {
            Id = 4,
            Name = "AC-120/19",
            ActiveResistance = 0.244,
            InductivityResistance = 0.4
        },
        
        new Wire
        {
            Id = 5,
            Name = "СИП-3х35",
            ActiveResistance = 0.3, // r
            InductivityResistance = 0.868   // x
        },
        
        new Wire
        {
            Id = 6,
            Name = "СИП-3х50",
            ActiveResistance = 0.299, // r
            InductivityResistance = 0.641   // x
        },
        
        new Wire
        {
            Id = 7,
            Name = "СИП-3х70",
            ActiveResistance = 0.291, // r
            InductivityResistance = 0.443   // x
        },

        new Wire
        {
            Id = 8,
            Name = "СИП-3х95",
            ActiveResistance = 0.284, // r
            InductivityResistance = 0.320   // x
        },
    };

    public List<Wire> WiresFromCableLine => new()
    {
        new Wire
        {
            Id = 1,
            Name = "АПвБШв-4х50",
            ActiveResistance = 0.625,
            InductivityResistance = 0.0825
        },

        new Wire
        {
            Id = 2,
            Name = "АПвБШв-4х70",
            ActiveResistance = 0.447,
            InductivityResistance = 0.082
        },

        new Wire
        {
            Id = 3,
            Name = "АПвБШв-4х95",
            ActiveResistance = 0.329,
            InductivityResistance = 0.081
        },

        new Wire
        {
            Id = 4,
            Name = "АПвБШв-4х120",
            ActiveResistance = 0.261,
            InductivityResistance = 0.08
        }
    };
}