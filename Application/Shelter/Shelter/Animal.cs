using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShelterManager
{
    [Serializable]
    public abstract class Animal
    {
        private DateTime DateFound;
        private Owner owner;
        private string Description;
        private string LocationFound;
        private string RFID;
        protected bool inShelter;

        public Animal(DateTime DateFound, string locationFound, string description, string RFID)
        {
            this.DateFound = DateFound;
            this.LocationFound = locationFound;
            this.Description = description;
            this.RFID = RFID;
            this.owner = null;
            this.inShelter = true;
        }

        protected void setOwner(Owner newOwner)
        {
            this.owner = newOwner;
        }

        public abstract double Adopt(Owner newOwner);

        public abstract double Claim(Owner newOwner);

        public bool InShelter
        {
            get
            {
                return this.inShelter;
            }
        }

        public string GetDescription()
        {
            return this.Description;
        }
        public DateTime GetFoundDate()
        {
            return this.DateFound;
        }
        public string GetFoundLocation()
        {
            return this.LocationFound;
        }
        public string GetRFID()
        {
            return this.RFID;
        }
        public bool IsAdoptable()
        {
            double days = (DateTime.Today - this.DateFound).TotalDays;
            return (days > 20 && this.inShelter);
        }
        public bool IsClaimable(Owner CheckOwner)
        {
            return (this.owner == CheckOwner && this.inShelter);            
        }
        public Owner GetOwner()
        {
            return this.owner;
        }

        public bool checkIn()
        {
            if (this.inShelter == false)
            {
                this.inShelter = true;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            string retString = String.Format("Found on {0} at {1} Description: {2} ", this.DateFound.ToShortDateString(), this.LocationFound, this.Description);
            if (this.owner != null)
            {
                retString += String.Format(" Owner: {0}", this.owner.GetName());
            }

            if (InShelter)
            {
                retString += " Currently in sheler";
            }
            else
            {
                retString += " Currently not in the shelter";
            }

            return retString;
        }
    }
}