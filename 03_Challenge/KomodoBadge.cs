using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Challenge
{
    public class KomodoBadge
    {
        public int BadgeID { get; set; }
        public List<string> DoorAccess { get; set; }
        public KomodoBadge() { }
        public KomodoBadge(int badgeID, List<string> doorAccess)
        {
            BadgeID = badgeID;
            DoorAccess = doorAccess;
        }
    }
    //public class AccessabilityOfDoors
    //{
    //    public string DoorOne { get; set; }
    //    public string DoorTwo { get; set; }
    //    public string DoorThree { get; set; }
    //    public string DoorFour { get; set; }
    //    public string DoorFive { get; set; }
    //    public string DoorSix { get; set; }
    //    public AccessabilityOfDoors() { }
    //    public AccessabilityOfDoors(string doorOne, string doorTwo, string doorThree, string doorFour, string doorFive, string doorSix)
    //    {
    //        DoorOne = doorOne;
    //        DoorTwo = doorTwo;
    //        DoorThree = doorThree;
    //        DoorFour = doorFour;
    //        DoorFive = doorFive;
    //        DoorSix = doorSix;
    //    }
    //}
}
