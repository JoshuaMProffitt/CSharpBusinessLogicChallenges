using _01_Challenge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Challenge_Console
{
    public class ProgramUI
    {
        private KomodoCafeRespository _challengeOne = new KomodoCafeRespository();
        public void Run()
        {
            SeedCafeList();
            RunMenu();
        }
        private void RunMenu()
        {
            bool ContToRunMenu = true;
            while (ContToRunMenu)
            {
                Console.Clear();

                Console.WriteLine("Enter the number of the option:\n" +
                    "1. Create a menu item\n" +
                    "2. Delete a menu item\n" +
                    "3. List all menu items\n" +
                    "4. Exit");

                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        CreateMenuItem();
                        break;
                    case "2":
                        DeleteMenuItem();
                        break;
                    case "3":
                        ShowAllMenuItems();
                        break;
                    case "4":
                        ContToRunMenu = false;
                        break;
                }
            }
        }
        private void CreateMenuItem()
        {
            //intialize
            KomodoCafe cafe = new KomodoCafe();
            //get meal number
            Console.Write("Enter the menu item starting at 4: ");
            cafe.MealNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter the name of the menu item you wish to add: ");
            cafe.MealName = Console.ReadLine();
            Console.Write("Enter a description for your menu item: ");
            cafe.Description = Console.ReadLine();
            Console.Write("Enter a price for your menu item: ");
            cafe.Price = double.Parse(Console.ReadLine());
            //add to list
            _challengeOne.AddCafeToList(cafe);


        }

        private void DeleteMenuItem()
        {
            Console.WriteLine("Enter the number of the menu item you would like to delete:");
            int oldNumber = int.Parse(Console.ReadLine());
            KomodoCafe CurrentNumber = _challengeOne.GetKomodoByCafe(oldNumber);
            Console.WriteLine($"{CurrentNumber.MealName} will be removed");
            _challengeOne.RemoveContentFromList(CurrentNumber);

        }
        private void ShowAllMenuItems()
        {
            List<KomodoCafe> listOfCafe = _challengeOne.GetKomodoCafeList();
            foreach (KomodoCafe cafe in listOfCafe)
            {
                Console.WriteLine($"{cafe.MealNumber}:" +
                        $" {cafe.MealName}\n" +
                        $"{cafe.Description}\n" +
                        $"Price: {cafe.Price} dollars \n");
            }
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
        private void SeedCafeList()
        {
            KomodoCafe BurgerMeal = new KomodoCafe(1, "Burger Meal", KomodoCafe.Ingredients.BurgerFriesDrink, "This meal contains a burger, fries and a drink.", 8.00);
            KomodoCafe HotDogMeal = new KomodoCafe(2, "HotDog Meal", KomodoCafe.Ingredients.HotDogFriesDrink, "This meal contains a hot dog, fries and a drink.", 6.00);
            KomodoCafe Nachos = new KomodoCafe(3, "Nachos", KomodoCafe.Ingredients.Nachos, "This meal is just nachos, lots of nachos.", 5.00);

            _challengeOne.AddCafeToList(BurgerMeal);
            _challengeOne.AddCafeToList(HotDogMeal);
            _challengeOne.AddCafeToList(Nachos);
        }
    }
}
