public class IndustrialRobot : Robot
{
    public string IndustrialTask { get; set; }

    public override Robot Clone()
    {
        return (IndustrialRobot)this.MemberwiseClone();
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Industrial Task: {IndustrialTask}");
    }
}