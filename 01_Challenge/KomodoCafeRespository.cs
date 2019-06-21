using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Challenge
{
    public class KomodoCafeRespository
    {
        private List<KomodoCafe> _ListOfCafe = new List<KomodoCafe>();
        //add
        public void AddCafeToList(KomodoCafe cafe)
        {
            _ListOfCafe.Add(cafe);
        }
        public List<KomodoCafe> GetKomodoCafeList()
        {
            return _ListOfCafe;
        }
        //get
        public KomodoCafe GetKomodoByCafe(int MealNumber)
        {
            foreach (KomodoCafe komodo in _ListOfCafe)
            { 
                if (komodo.MealNumber == MealNumber)
                {
                    return komodo;
                }
            }
            return null;
        }
        //update
        public void UpdateExistingContent(int originalCafe, KomodoCafe newCafe)
        {
            //find the thing
            KomodoCafe oldCafe = GetKomodoByCafe(originalCafe);
            //apply changes to the thing
            oldCafe.MealNumber = newCafe.MealNumber;
            oldCafe.Cafe = newCafe.Cafe;
            oldCafe.OfIngredients = newCafe.OfIngredients;
            oldCafe.MealName = newCafe.MealName;
            oldCafe.Description = newCafe.Description;
            oldCafe.Price = newCafe.Price;
        }
        //remove
        public bool RemoveContentFromList(KomodoCafe cafe)
        {
            int intialCount = _ListOfCafe.Count;
            _ListOfCafe.Remove(cafe);

            if(intialCount > _ListOfCafe.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}