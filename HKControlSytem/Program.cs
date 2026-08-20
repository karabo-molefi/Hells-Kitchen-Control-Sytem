using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HKControlSytem
{
    internal class Program
    {
        enum MainMenu
        {
            RegisterContestant = 1,
            ViewContestants,
            CreatServicee,
            ManageDishes,
            RecordIncident,
            ViewKitchenInfo,
            StartSimulation,
            Exit
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine($"========================================\n" +
                $"HELL'S KITCHEN CONTROL\n" +
                $"========================================\n" +
                $"1. Register Contestant\n" +
                $"2. View Contestants\n" +
                $"3. Create Service\r\n" +
                $"4. Manage Dishes\r\n" +
                $"5. Record Kitchen Incident\r\n" +
                $"6. View Kitchen Information\r\n" +
                $"7. Start Service Simulation\r\n" +
                $"8. Exit\"\r\n" +
                $"\nSelect an option:");

                int choice = 0;
                try
                {
                    choice = int.Parse(Console.ReadLine());

                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input, please try again!");
                }

                MainMenu menuOption = (MainMenu)choice;

                switch (menuOption)
                {
                    case MainMenu.RegisterContestant:
                        break;
                    case MainMenu.ViewContestants:
                        break;
                    case MainMenu.CreatServicee:
                        break;
                    case MainMenu.ManageDishes:
                        break;
                    case MainMenu.RecordIncident:
                        break;
                    case MainMenu.ViewKitchenInfo:
                        break;
                    case MainMenu.StartSimulation:
                        break;
                    case MainMenu.Exit:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid input, please try again!.");
                        break;

                }
            }
            





        }
    }
}
