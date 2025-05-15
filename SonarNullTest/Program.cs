public class Program
{
    public static void Main()
    {
        InspectType inspectType = new InspectType();
        bool shouldDisable = true;

        if (shouldDisable)
        {
            inspectType = null; // Simulate disable case
        }

        // This will cause NullReferenceException if inspectType is null
        Console.WriteLine(inspectType.SomeProperty);
    }
}

public class InspectType
{
    public string SomeProperty { get; set; } = "Test property inspectType";
}