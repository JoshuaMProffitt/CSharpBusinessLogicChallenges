using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Challenge
{
    public class KomodoInsurance
    {
        public enum ClaimType
        {
            Car = 1, Home, Robbery
        }
        public int ClaimID { get; set; }
        public ClaimType OfClaimType { get; set; }
        public string Description { get; set; }
        public int ClaimAmount { get; set; }
        public DateTime DateOfIncident { get; set; }
        public DateTime DateOfClaim { get; set; }
        public bool IsValid  { get; set; }
        public KomodoInsurance() { }
        public KomodoInsurance(int claimID, ClaimType ofClaimType, string description, int claimAmount, DateTime dateOfIncident, DateTime dateOfClaim, bool isValid)
        {
            ClaimID = claimID;
            OfClaimType = ofClaimType;
            Description = description;
            ClaimAmount = claimAmount;
            DateOfIncident = dateOfIncident;
            DateOfClaim = dateOfClaim;
            IsValid = isValid;
        }
    }
}
