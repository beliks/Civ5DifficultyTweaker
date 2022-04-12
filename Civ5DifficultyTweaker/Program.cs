using Civ5GameSpeedTweaker;
using System.Xml;

class Program
{

    static void Main(string[] args)
    {
        string navigation = "";
        while (navigation != "4")
        {
            UserInterface.MainMenu();
            navigation = Console.ReadLine();
            switch (navigation)
            {
                case "1":
                    UserInterface.Tutorial();
                    break;
                case "2":
                    UserInterface.Install();
                    break;
                case "3":
                    UserInterface.Uninstall();
                    break;
                case "4":
                    break;
            }
        }
    }
}
