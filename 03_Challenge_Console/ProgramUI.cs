using _03_Challenge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Challenge_Console
{
    public class ProgramUI
    {
        private KomodoBadgeRespository _challengeThree = new KomodoBadgeRespository();
        public void Run()
        {
            SeedBadgeQueue();
            RunMenu();
        }
        private void RunMenu()
        {
            bool ContinueToRunMenu = true;
            while (ContinueToRunMenu)
            {
                Console.Clear();

                Console.WriteLine("Hello secutiry admin, what would you like to do?\nType number of option you want:\n" +
                    "1. Add a badge\n" +
                    "2. Edit a badge\n" +
                    "3. List all badges\n" +
                    "4. Exit\n");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        AddBadge();
                        break;
                    case "2":
                        EditBadge();
                        break;
                    case "3":
                        ListBadge();
                        break;
                    case "4":
                        ContinueToRunMenu = false;
                        break;
                        //create a dictionary of badges
                        //the key for the dictionary will be the badgeID.
                        //The value for the dictionary will be the list of door names.
                }
            }
        }
        private void AddBadge()
        {
            //intialize
            KomodoBadge badge = new KomodoBadge(0, new List<string>());
            //get meal number
            Console.Write("Enter the badge starting at 3: ");
            badge.BadgeID = int.Parse(Console.ReadLine());
            Console.Write("Enter a Door you wish to add: ");
            badge.DoorAccess.Add(Console.ReadLine());
            //add
            _challengeThree.AddBadgeToList(badge);
        }
        private void EditBadge()
        {
            Console.Write("What badge do you wish to update?: ");
            int userBadgeInput = int.Parse(Console.ReadLine());
            KomodoBadge badge = _challengeThree.GetKomodoBadge(userBadgeInput);
            foreach (string door in badge.DoorAccess)
            {
                Console.WriteLine("{0,-10}{1,-10}", badge.BadgeID, door);
            }
            Console.WriteLine("Enter the number of the option:\n" +
                "1. Add door\n" +
                "2. Remove Door\n");
            string RandoInput = Console.ReadLine();
            switch (RandoInput)
            {
                case "1":
                    AddDoor();
                    break;
                case "2":
                    RemoveDoor();
                    break;
            }
            void AddDoor()
            {
                Console.WriteLine($"Which door would you like to add?");
                string addDoor = Console.ReadLine().ToUpper();
                badge.DoorAccess.Add(addDoor);
                Console.WriteLine($"Door {addDoor} was added to Badge {badge.BadgeID}");
                ////intialize
                //KomodoBadge oldBadge = new KomodoBadge(0, new List<string>());
                ////add door
                //Console.Write("What badge do you wish to add doors to: ");
                //oldBadge.BadgeID = int.Parse(Console.ReadLine());
                //Console.Write("Enter the door you wish to add: ");
                //oldBadge.DoorAccess.Add(Console.ReadLine());
                ////update
                //_challengeThree.UpdateBadge(oldBadge.BadgeID, oldBadge);
            }
            void RemoveDoor()
            {
                Console.WriteLine($"What door would you like to remove?");
                string removeDoor = Console.ReadLine().ToUpper();
                badge.DoorAccess.Remove(removeDoor);
                Console.WriteLine($"Door {removeDoor} was removed from Badge {badge.BadgeID}");
                ////intialize
                //KomodoBadge oldBadge = new KomodoBadge(0, new List<string>());
                ////remove door
                //Console.Write("What badge do you wish to remove doors from: ");
                //oldBadge.BadgeID = int.Parse(Console.ReadLine());
                //Console.Write("Enter the door you wish to delete: ");
                //oldBadge.DoorAccess.Remove(Console.ReadLine());
                ////update
                //_challengeThree.UpdateBadge(oldBadge.BadgeID, oldBadge);
            }
        }
        private void ListBadge()
        {
            Dictionary<int, List<string>> NewBadge = _challengeThree.GetBadge();
            Console.Write("");
            foreach (KeyValuePair<int, List<string>> badge in NewBadge)
            {
                Console.WriteLine($"BadgeID: {badge.Key}");
                foreach (string door in badge.Value)
                {
                    Console.Write($"Door: {door}\n");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("Press any key to return to the main menu.");
            Console.ReadKey();
        }
        private void SeedBadgeQueue()
        {
            KomodoBadge BadgeOne = new KomodoBadge(1, new List<string> { "D1" });
            KomodoBadge BadgeTwo = new KomodoBadge(2, new List<string> { "D2" });


            _challengeThree.AddBadgeToList(BadgeOne);
            _challengeThree.AddBadgeToList(BadgeTwo);
        }
    }
}

