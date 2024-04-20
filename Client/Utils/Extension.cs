using WireCalc.Client.Models;

namespace WireCalc.Client.Utils;


public static class Extension
{

    public static IEnumerable<TextAndValuesEnum> GetAll(this IEnumerable<Wire> wires)
    {
        return wires.Select(v => new TextAndValuesEnum { Text = v.Name, Value = v });

    }

    public class TextAndValuesEnum
    {
        public string Text { get; set; }
        public Wire Value { get; set; }
    }
}
