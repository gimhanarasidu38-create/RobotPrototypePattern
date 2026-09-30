public class EntertainmentRobot : Robot
{
    public string EntertainmentFeature { get; set; }

    public override Robot Clone()
    {
        return (EntertainmentRobot)this.MemberwiseClone();
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Entertainment Feature: {EntertainmentFeature}");
    }
}
