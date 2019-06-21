using System;
using _01_Challenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Challenge_Tests
{
    [TestClass]
    public class _01_Tests
    {
        private KomodoCafeRespository _CafeRepo;
        private KomodoCafe _Cafe;

        [TestMethod]
        public void Arrange()
        {
            _CafeRepo = new KomodoCafeRespository();
            _Cafe = new KomodoCafe(4, "Food", KomodoCafe.Ingredients.BurgerFriesDrink, "This meal is something", 3.0);
        }
        public void KomodoCafeUpdateTest()
        {
            _CafeRepo.AddCafeToList(_Cafe);

            KomodoCafe newCafe = new KomodoCafe(4, "Food", KomodoCafe.Ingredients.BurgerFriesDrink, "This meal is something", 3.0);

            _CafeRepo.UpdateExistingContent(6, newCafe);

            KomodoCafe UpdateCafe = _CafeRepo.GetKomodoByCafe(4);

            Assert.AreEqual(UpdateCafe.Cafe, newCafe.Cafe);
        }
        public void KomodoCafeAddCafeToList()
        {
            _CafeRepo.AddCafeToList(_Cafe);

            int expected = 1;
            int actual = _CafeRepo.GetKomodoCafeList().Count;
            Assert.AreEqual(expected, actual);
        }
        public void GetKomodoByCafe()
        {
            KomodoCafeRespository komodoCafe = new KomodoCafeRespository();
            KomodoCafe komodo = new KomodoCafe(4, "Food", KomodoCafe.Ingredients.BurgerFriesDrink, "This meal is something", 3.0);
            komodoCafe.AddCafeToList(komodo);
            KomodoCafe actual = _CafeRepo.GetKomodoByCafe(8);
            Assert.AreEqual(komodo, actual);
        }
        public void RemoveFromListTest()
        {
            KomodoCafeRespository cafeRespository = new KomodoCafeRespository();
            KomodoCafe komodo = new KomodoCafe(4, "Food", KomodoCafe.Ingredients.BurgerFriesDrink, "This meal is something", 3.0);
            _CafeRepo.AddCafeToList(komodo);
            bool wasRemoved = _CafeRepo.RemoveContentFromList(komodo);
            Assert.IsTrue(wasRemoved);
        }
    }
}
