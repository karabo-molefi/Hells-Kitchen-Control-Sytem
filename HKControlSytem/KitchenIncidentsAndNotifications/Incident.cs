using HKControlSytem.Exeptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HKControlSytem.KitchenIncidentsAndNotifications
{
    internal class Incident
    {
        // 
        public string reason;
        public int severity;

        public bool disqualifies;
        //
        public void RecordIncident()
        {
            Console.WriteLine("================" +
                "Recording Incident..." +
                "================");

            Console.WriteLine("\nReason: ");

            string reason = Console.ReadLine();

            Console.WriteLine("Severity (1-10): ");

            while (true)
            {
                try
                {
                    int severity = int.Parse(Console.ReadLine());
                    if (severity < 0 || severity > 10)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    else
                    {
                        break;
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Out of range. Please try again.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input, please try again.");
                }
                Console.WriteLine("Does this disqulify the contestant? (yes or no): ");
                try
                {
                    string disqualifies = Console.ReadLine();
                    if (disqualifies.ToLower() != "yes" || disqualifies.ToLower() != "no" )
                    {
                        throw new InvalidYesNoException();
                    }
                }
                catch (InvalidYesNoException)
                {
                    Console.WriteLine("Invalid Input, please enter yes or no");
                }

                catch(FormatException)
                {
                    Console.WriteLine("Invalid input, please try again");
                }
            }





            


        }
    }
}
