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
        }
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