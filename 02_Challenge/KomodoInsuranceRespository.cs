using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Challenge
{
    public class KomodoInsuranceRespository
    {
        //private List<KomodoInsurance> _ListOfInsurance = new List<KomodoInsurance>();
        private Queue<KomodoInsurance> _ListOfInsurance = new Queue<KomodoInsurance>();

        //add
        public void AddInsuranceToList(KomodoInsurance Insurance)
        {
            _ListOfInsurance.Enqueue(Insurance);
        }
        public Queue<KomodoInsurance> GetKomodoInsurance()
        {
            return _ListOfInsurance;
        }
        //get
        public KomodoInsurance GetKomodoByInsurance(int ClaimID)
        {
            foreach (KomodoInsurance komodo in _ListOfInsurance)
            {
                if (komodo.ClaimID == ClaimID)
                {
                    return komodo;
                }
            }
            return null;
        }
        public void UpdateExistingInsurance(int originalInsurance, KomodoInsurance newInsurance)
        {
            //find the thing
            KomodoInsurance oldInsurance = GetKomodoByInsurance(originalInsurance);
            //apply changes to the thing 
            oldInsurance.ClaimID = newInsurance.ClaimID;
            oldInsurance.OfClaimType = newInsurance.OfClaimType;
            oldInsurance.Description = newInsurance.Description;
            oldInsurance.ClaimAmount = newInsurance.ClaimAmount;
            oldInsurance.DateOfIncident = newInsurance.DateOfIncident;
            oldInsurance.DateOfClaim = newInsurance.DateOfClaim;
            oldInsurance.IsValid = newInsurance.IsValid;
        }
        //remove
        public void RemoveInsuranceFromList(KomodoInsurance Insurance)
        {
            while (_ListOfInsurance.Count > 0)
                Console.WriteLine(_ListOfInsurance.Dequeue());
            Console.WriteLine($"Number of elements in queue = {_ListOfInsurance.Count}");
        }
    }
}