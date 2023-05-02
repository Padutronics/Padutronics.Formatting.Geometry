namespace Padutronics.Formatting.Geometry;

public sealed class PointFormatOptions
{
    public string ClosingCap { get; set; } = "]";

    public string ComponentDelimiter { get; set; } = ",";

    public string ComponentNameAndValueDelimiter { get; set; } = "=";

    public bool InsertSpaceAfterComponentDelimiter { get; set; } = true;

    public bool InsertSpaceAfterComponentNameAndValueDelimiter { get; set; }

    public bool InsertSpaceBeforeComponentDelimiter { get; set; }

    public bool InsertSpaceBeforeComponentNameAndValueDelimiter { get; set; }

    public bool InsertSpaceWithinCaps { get; set; }

    public string OpeningCap { get; set; } = "[";

    public bool ShowComponentName { get; set; } = true;
}