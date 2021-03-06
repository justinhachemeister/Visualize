// ReSharper disable NotAccessedField.Local
public class ClassWithProperties
{
    public int Number { get; set; }
    public string String { get; set; }
    public bool Boolean { get; set; }

    public int? Nullable { get; set; }

    internal string Internal { get; set; }

    string setterOnly;
    public string SetterOnly
    {
        set => setterOnly = value;
    }

    public SimpleEnum SimpleEnum { get; set; }
}