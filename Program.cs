internal class Program
{
    static void Main(string[] args)
    {
        // ===== SERVICE ROBOT =====
        ServiceRobot serviceRobot = new ServiceRobot
        {
            ModelName = "SR-100",
            BatteryCapacity = 10,
            SoftwareVersion = "1.0",
            ServiceTask = "Patient Assistance"
        };

        Console.WriteLine("=== Original Service Robot ===");
        serviceRobot.DisplayInfo();

        ServiceRobot clonedServiceRobot =
            (ServiceRobot)serviceRobot.Clone();

        clonedServiceRobot.ModelName = "SR-101";
        clonedServiceRobot.BatteryCapacity = 15;
        clonedServiceRobot.SoftwareVersion = "1.1";

        Console.WriteLine("\n=== Cloned Service Robot ===");
        clonedServiceRobot.DisplayInfo();


        // ===== INDUSTRIAL ROBOT =====
        Console.WriteLine("\n-----------------------------");

        IndustrialRobot industrialRobot = new IndustrialRobot
        {
            ModelName = "IR-200",
            BatteryCapacity = 20,
            SoftwareVersion = "2.0",
            IndustrialTask = "Welding"
        };

        Console.WriteLine("\n=== Original Industrial Robot ===");
        industrialRobot.DisplayInfo();

        IndustrialRobot clonedIndustrialRobot =
            (IndustrialRobot)industrialRobot.Clone();

        clonedIndustrialRobot.ModelName = "IR-201";
        clonedIndustrialRobot.BatteryCapacity = 25;
        clonedIndustrialRobot.SoftwareVersion = "2.1";

        Console.WriteLine("\n=== Cloned Industrial Robot ===");
        clonedIndustrialRobot.DisplayInfo();


        // ===== ENTERTAINMENT ROBOT =====
        Console.WriteLine("\n-----------------------------");

        EntertainmentRobot entertainmentRobot = new EntertainmentRobot
        {
            ModelName = "ER-300",
            BatteryCapacity = 8,
            SoftwareVersion = "3.0",
            EntertainmentFeature = "Dancing"
        };

        Console.WriteLine("\n=== Original Entertainment Robot ===");
        entertainmentRobot.DisplayInfo();

        EntertainmentRobot clonedEntertainmentRobot =
            (EntertainmentRobot)entertainmentRobot.Clone();

        clonedEntertainmentRobot.ModelName = "ER-301";
        clonedEntertainmentRobot.BatteryCapacity = 12;
        clonedEntertainmentRobot.SoftwareVersion = "3.1";

        Console.WriteLine("\n=== Cloned Entertainment Robot ===");
        clonedEntertainmentRobot.DisplayInfo();

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}