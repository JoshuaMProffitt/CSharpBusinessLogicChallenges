using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Challenge
{
    public class KomodoBadgeRespository
    {
        //private List<KomodoBadge> _ListOfDoorAccess = new List<KomodoBadge>();
        //badgeID, doors
        private static Dictionary<int, List<string>> NewBadge = new Dictionary<int, List<string>>();

        //add
        public void AddBadgeToList(KomodoBadge Badge)
        {
            NewBadge.Add(Badge.BadgeID, Badge.DoorAccess);
        }

        public Dictionary<int, List<string>> GetBadge()
        {
            return NewBadge;
        }
        public KomodoBadge GetKomodoBadge(int BadgeID)
        {
            foreach (KeyValuePair<int, List<string>> CurrentBadge in NewBadge)
            {
                foreach (string door in CurrentBadge.Value)
                {
                    if (CurrentBadge.Key == BadgeID)
                    {
                        KomodoBadge badge = new KomodoBadge(CurrentBadge.Key, CurrentBadge.Value);
                        return badge;
                    }
                }
            }
            return null;
        }
        public void UpdateBadge(int originalBadge, KomodoBadge DifferentBadge)
        {
            //foreach (KeyValuePair<int, List<string>> CurrentBadge in NewBadge)
            //{
            //    foreach (string door in CurrentBadge.Value)
            //    {
            //        if (CurrentBadge.Key == originalBadge)
            //        {
            //            return CurrentBadge;
            //        }
            //    }
            //}

            //find
            KomodoBadge oldBadge = GetKomodoBadge(originalBadge);
            //apply
            oldBadge.BadgeID = DifferentBadge.BadgeID;
            oldBadge.DoorAccess = DifferentBadge.DoorAccess;
            //need new badge in to update
            //Dictionary<int, List<string>> NewBadge = new Dictionary<int, List<string>>();
            






            //int intialCount = NewBadge.Count;

            //if (intialCount > NewBadge.Count)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}


        }
        //public bool RemoveBadgeAccess(KomodoBadge badge)
        //{
        //   int intialCount = NewBadge.Count;
        //   NewBadge.Remove(badge);

        ////    if (intialCount > dict.Count)
        ////    {
        ////        return true;
        ////    }
        ////    else
        ////    {
        ////        return false;
        ////    }
        //}
    }
}