using System;
using _02_Challenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Challenge_Tests
{
    [TestClass]
    public class _02_Tests
    {
        private KomodoInsuranceRespository _InsuranceRepo;
        private KomodoInsurance _Insurance;
        [TestMethod]
        public void Arrange()
        {
            _InsuranceRepo = new KomodoInsuranceRespository();
            _Insurance = new KomodoInsurance(4, KomodoInsurance.ClaimType.Robbery, "The Robber Stole all my soup.", 4, new DateTime(2019, 06, 18), new DateTime(2019, 06, 18), true);
        }
        private void KomodoInsuranceUpdate()
        {
            _InsuranceRepo.AddInsuranceToList(_Insurance);

            KomodoInsurance newInsurance = new KomodoInsurance(4, KomodoInsurance.ClaimType.Robbery, "The Robber Stole all my soup.", 4, new DateTime(2019, 06, 18), new DateTime(2019, 06, 18), true);

            _InsuranceRepo.UpdateExistingInsurance(6, newInsurance);
            KomodoInsurance UpdateInsurance = _InsuranceRepo.GetKomodoByInsurance(4);
            Assert.AreEqual(UpdateInsurance.ClaimID, newInsurance.ClaimID);
        }
        private void AddInsuranceTest()
        {
            _InsuranceRepo.AddInsuranceToList(_Insurance);

            int expected = 1;
            int actual = _InsuranceRepo.GetKomodoInsurance().Count;
            Assert.AreEqual(expected, actual);

        }
        private void GetInsuranceTest()
        {
            KomodoInsuranceRespository komodoInsurance = new KomodoInsuranceRespository();
            KomodoInsurance komodo = new KomodoInsurance(4, KomodoInsurance.ClaimType.Robbery, "The Robber Stole all my soup.", 4, new DateTime(2019, 06, 18), new DateTime(2019, 06, 18), true);
            komodoInsurance.AddInsuranceToList(komodo);
            KomodoInsurance actual = _InsuranceRepo.GetKomodoByInsurance(4);

            Assert.AreEqual(komodo, actual);
        }
        //public void RemoveInsuranceTest()
        //{
        //    KomodoInsuranceRespository insuranceRespository = new KomodoInsuranceRespository();
        //    KomodoInsurance komodo = new KomodoInsurance(4, KomodoInsurance.ClaimType.Robbery, "The Robber Stole all my soup.", 4, new DateTime(2019, 06, 18), new DateTime(2019, 06, 18), true);
        //    _InsuranceRepo.AddInsuranceToList(komodo);

        //    _InsuranceRepo.RemoveInsuranceFromList(komodo);
        //    Assert.IsTrue(wasRemoved);
        //}
    }
}
