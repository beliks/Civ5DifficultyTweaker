using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Civ5GameSpeedTweaker
{
    public class UserInterface
    {
        public static void MainMenu()
        {
            Console.WriteLine
            (
            "Hello There :D " +
            "\nNawigacja:" +
            "\n 1 ----> Tutorial jak znaleść ścieżkę do foldera gry " +
            "\n 2 ----> Instaluj modyfikację " +
            "\n 3 ----> Odinstaluj modyfikację " +
            "\n 4 ----> Wyłącz program "
            );
           
        }
        public static string Civ5Location()
        {;
            Console.WriteLine
            (
                "Podaj ścieżkę do głównego folderu gry " +
                "\n" + @"na przykład E:\steam\steamapps\common\Sid Meier's Civilization V"
            );
            return Console.ReadLine();
        }
        public static void Tutorial()
        {
            Console.Clear();
            Console.WriteLine
            (
            "\n =====Tutorial===== " +
            "\n Jak znaleść scieżkę do głównego folderu gry " +
            "\n 1 Kliknij prawym przyciskiem myszy na grę Civ5 w aplikacji steam " +
            "\n 2 Kliknij Właściwości " +
            "\n 3 W okienku które się pokazało w lewym menu wybierz 'Pliki Lokalne' " +
            "\n 4 Kliknij przycisk 'Przeglądaj' " +
            "\n 5 W nowo otwartym folderze kliknij w puste paska adresowego " +
            "\n znajduje się on w górnej na górze folderu będzie tam napisane steamapps > common > Sid Meier's Civilization V " +
            "\n 6 skopiuj jego zawartość  " +
            "\n 7 Jeśli chcesz zainstalować moda, w konsoli wpisz '2' by przejść do instalacji," +
            "\n a jeśli chcesz go odinstalować wpisz '3' " +
            "\n 8 Gdy zostaniesz poproszony o podanie ścieżki kliknij prawym przyciskiem myszy w konsoli by wkleić scieżkę " + 
            "\n "
            );
        }
        public static void Install()
        {
            string civ5Path = UserInterface.Civ5Location();
            string[] pathList = 
            {
                civ5Path + @"\Assets\Gameplay\XML\GameInfo\CIV5GameSpeeds.xml",
                civ5Path + @"\Assets\DLC\Expansion\Gameplay\XML\GameInfo\CIV5GameSpeeds.xml",
                civ5Path + @"\Assets\DLC\Expansion2\Gameplay\XML\GameInfo\CIV5GameSpeeds.xml"
            };

            foreach(string path in pathList)
            {
                XmlDocument civ5DifficultyConfigFile = new XmlDocument();
                civ5DifficultyConfigFile.Load(path);
                civ5DifficultyConfigFile.SelectSingleNode("//ResearchPercent[text() = '100']").InnerText = "301";
                civ5DifficultyConfigFile.Save(path);
            }
            Console.WriteLine("Zainstalowano");

        }
        public static void Uninstall()
        {
            string civ5Path = UserInterface.Civ5Location();
            string[] pathList =
            {
                civ5Path + @"\Assets\Gameplay\XML\GameInfo\CIV5GameSpeeds.xml",
                civ5Path + @"\Assets\DLC\Expansion\Gameplay\XML\GameInfo\CIV5GameSpeeds.xml",
                civ5Path + @"\Assets\DLC\Expansion2\Gameplay\XML\GameInfo\CIV5GameSpeeds.xml"
            };

            foreach (string path in pathList)
            {
                XmlDocument civ5DifficultyConfigFile = new XmlDocument();
                civ5DifficultyConfigFile.Load(path);
                civ5DifficultyConfigFile.SelectSingleNode("//ResearchPercent[text() = '301']").InnerText = "100";
                civ5DifficultyConfigFile.Save(path);
            }
            Console.WriteLine("Odinstalowano GIT GUD SCRUB");
        }
    }
}
