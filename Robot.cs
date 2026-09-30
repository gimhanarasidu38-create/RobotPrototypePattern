public abstract class Robot
{
    public string ModelName { get; set; }
    public int BatteryCapacity { get; set; }
    public string SoftwareVersion { get; set; }

    public abstract Robot Clone();

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Model Name: {ModelName}");
        Console.WriteLine($"Battery Capacity: {BatteryCapacity} hours");
        Console.WriteLine($"Software Version: {SoftwareVersion}");
    }
}
