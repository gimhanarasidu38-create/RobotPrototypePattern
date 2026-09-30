public class ServiceRobot : Robot
{
    public string ServiceTask { get; set; }

    public override Robot Clone()
    {
        return (ServiceRobot)this.MemberwiseClone();
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Service Task: {ServiceTask}");
    }
}
