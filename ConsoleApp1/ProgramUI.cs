using _02_Challenge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Challenge_Console
{
    public class ProgramUI
    {
        private KomodoInsuranceRespository _challengeTwo = new KomodoInsuranceRespository();
        public void Run()
        {
            SeedInsuranceQueue();
            RunMenu();
        }
        private void RunMenu()
        {
            bool ContinueToRunMenu = true;
            while (ContinueToRunMenu)
            {
                Console.Clear();

                Console.WriteLine("Enter the number of the option:\n" +
                    "1. See all claims\n" +
                    "2. Take care of next claim\n" +
                    "3. Enter a new claim\n" +
                    "4. Exit\n");

                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        SeeAllClaims();
                        break;
                    case "2":
                        TakeCareClaim();
                        break;
                    case "3":
                        EnterNewClaim();
                        break;
                    case "4":
                        ContinueToRunMenu = false;
                        break;
                }
            }
        }
        private void SeeAllClaims()
        {
            Queue<KomodoInsurance> _ListOfInsurance = _challengeTwo.GetKomodoInsurance();
            foreach (KomodoInsurance Insurance in _ListOfInsurance)
            {
                Console.WriteLine($"ClaimID: {Insurance.ClaimID}," +
                    $" ClaimType: {Insurance.OfClaimType}," +
                    $" Description: {Insurance.Description}\n" +
                    $"Amount: ${Insurance.ClaimAmount}," +
                    $" Date of incident: {Insurance.DateOfIncident}," +
                    $" Date of claim: {Insurance.DateOfClaim}," +
                    $" Valid? {Insurance.IsValid}\n");
            }
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();
        }
        private void TakeCareClaim()
        {
            Queue<KomodoInsurance> komodoClaim = _challengeTwo.GetKomodoInsurance();
            Console.WriteLine("Here is your next claim:\n" +
                    $"ClaimID: {komodoClaim.Peek().ClaimID}," +
                    $" ClaimType: {komodoClaim.Peek().OfClaimType}," +
                    $" Description: {komodoClaim.Peek().Description}\n" +
                    $"Amount: ${komodoClaim.Peek().ClaimAmount}," +
                    $" Date of incident: {komodoClaim.Peek().DateOfIncident}," +
                    $" Date of claim: {komodoClaim.Peek().DateOfClaim}," +
                    $" Valid? {komodoClaim.Peek().IsValid}\n");

            Console.Write("Do you want to deal with this claim?\nyes or no: ");
            string response = Console.ReadLine();
            if (response == "yes")
            {
                komodoClaim.Dequeue();
            }
            else
            {
                Console.WriteLine("Press any key to continue.");
                Console.ReadLine();
            }
        }
        private void EnterNewClaim()
        {
            //intialize
            KomodoInsurance Insurance = new KomodoInsurance();
            //GetClaim
            Console.Write("Enter new Claim starting at 5: ");
            Insurance.ClaimID = int.Parse(Console.ReadLine());
            Console.Write("Enter the type of claim you wish to add (1 = Car, Home, Robbery): ");
            Insurance.OfClaimType = (KomodoInsurance.ClaimType)int.Parse(Console.ReadLine());
            Console.Write("Describe the incident you were in: ");
            Insurance.Description = Console.ReadLine();
            Console.Write("Write the amount your claim is for: ");
            Insurance.ClaimAmount = int.Parse(Console.ReadLine());
            Console.Write("Write the date of the Incident:\nyyyy, mm, dd: ");
            Insurance.DateOfIncident = DateTime.Parse(Console.ReadLine());
            Console.Write("Write the date of the claim:\nyyyy, mm, dd: ");
            Insurance.DateOfClaim = DateTime.Parse(Console.ReadLine());
            Console.Write("Is this claim valid?\ntrue/false: ");
            Insurance.IsValid = bool.Parse(Console.ReadLine());
            //add to list
            _challengeTwo.AddInsuranceToList(Insurance);
        }

        private void SeedInsuranceQueue()
        {
            KomodoInsurance CarCrash = new KomodoInsurance(1, KomodoInsurance.ClaimType.Car, "Broken window and mirror.", 2000, new DateTime(2019, 05, 08), new DateTime(2019, 06, 02), true);
            KomodoInsurance HomeFire = new KomodoInsurance(2, KomodoInsurance.ClaimType.Home, "The Home Burnt Down.", 300000, new DateTime(2019, 06, 03), new DateTime(2019, 06, 05), true);
            KomodoInsurance HomeRobbery = new KomodoInsurance(3, KomodoInsurance.ClaimType.Robbery, "They stole some stuff.", 2650, new DateTime(2019, 06, 07), new DateTime(2019, 06, 08), true);
            KomodoInsurance SoupRobbery = new KomodoInsurance(4, KomodoInsurance.ClaimType.Robbery, "The Robber Stole all my soup.", 4, new DateTime(2019, 06, 18), new DateTime(2019, 06, 18), true);

            _challengeTwo.AddInsuranceToList(CarCrash);
            _challengeTwo.AddInsuranceToList(HomeFire);
            _challengeTwo.AddInsuranceToList(HomeRobbery);
            _challengeTwo.AddInsuranceToList(SoupRobbery);


        }
    }
}
