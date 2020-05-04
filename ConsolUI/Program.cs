using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuestBookLibrary.Models;

//Capture info about guests (assumption: at least one guest, unknown number of max)
//Info: Fist name, last name, message to host
//Once data entry complete, loop through each entry and print first name, last name and message to host

//Pro Tip:  Design your app with just UI content in the UI.  Put everything else in a class library.

//Homework: recreate the guest book app without reviewing existing code, so from memory.


namespace ConsoleUI
{


    class Program
    {
        private static List<GuestModel> guests = new List<GuestModel>();

        static void Main(string[] args)
        {
            GetGuestinformation();
            
            PrintGuestInformation();

            Console.ReadLine();
        }

        private static void PrintGuestInformation()
        {
            foreach (GuestModel guest in guests)
            {
                Console.WriteLine(guest.GuestInfo);
            }
        }

        private static void GetGuestinformation()
        {
            string MoreGuestsComing = "";

            do
            {
                GuestModel guest = new GuestModel();

                guest.FirstName = GetInforFromConsole("What is your first name?: ");
                guest.LastName = GetInforFromConsole("What is your last name?: ");
                guest.HostMessage = GetInforFromConsole("What is your message to the host?: ");
                MoreGuestsComing = GetInforFromConsole("Are any more geusts coming? (yes/no): ");

                guests.Add(guest);

                Console.Clear();
            } while (MoreGuestsComing.ToLower() == "yes");
        }

        private static string GetInforFromConsole(string message)
        {
            Console.WriteLine(message);
            string output = Console.ReadLine();
            return output;
        }

    }
}
