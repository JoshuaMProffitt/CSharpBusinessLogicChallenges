using System;
using System.Collections.Generic;
using _03_Challenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Challenge_Tests
{
    [TestClass]
    public class _03_Tests
    {
        private KomodoBadgeRespository _BadgeRepo;
        private KomodoBadge _Badge;

        [TestMethod]
        public void Arrange()
        {
            _BadgeRepo = new KomodoBadgeRespository();
            _Badge = new KomodoBadge(1, new List<string> { "D1" });

        }
        public void KomodoBadgeUpdateTest()
        {
            _BadgeRepo.AddBadgeToList(_Badge);
            KomodoBadge newBadge = new KomodoBadge(5, new List<string> { "D1" });
            _BadgeRepo.UpdateBadge(8, newBadge);
            KomodoBadge UpdateBadge = _BadgeRepo.GetKomodoBadge(5);
            Assert.AreEqual(UpdateBadge.BadgeID, newBadge.BadgeID);
        }
        public void AddBadgeToListTest()
        {
            _BadgeRepo.AddBadgeToList(_Badge);

            int expected = 1;
            int actual = _BadgeRepo.GetBadge().Count;
            Assert.AreEqual(expected, actual);
        }
        public void GetBadgeTest()
        {
            KomodoBadgeRespository komodoBadge = new KomodoBadgeRespository();
            KomodoBadge komodo = new KomodoBadge(1, new List<string> { "D1" });
            komodoBadge.AddBadgeToList(komodo);
            KomodoBadge actual = _BadgeRepo.GetKomodoBadge(8);
            Assert.AreEqual(komodo, actual);
        }
    }
}
