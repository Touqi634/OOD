using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShelterManager
{
    [Serializable]
    public class Dog : Animal
    {
        private DateTime lastWalk;
        public Dog(DateTime DateFound, string locationFound, string description, string RFID) 
            : base(DateFound, locationFound, description, RFID)
        {
            this.lastWalk = DateTime.MinValue;
        }

        public override double Adopt(Owner newOwner)
        {
            if (this.IsAdoptable())
            {
                this.setOwner(newOwner);
                base.inShelter = false;
                return 20.00;
            }
            return -1;
        }

        public override double Claim(Owner newOwner)
        {
            if (this.IsClaimable(newOwner))
            {
                double days = (DateTime.Today - this.GetFoundDate()).TotalDays;
                double fee = (10 + 2*(days));
                this.setOwner(newOwner);
                base.inShelter = false;
                return fee;
            }
            return -1;
        }

        public DateTime WalkDog()
        {
            this.lastWalk = DateTime.Today;
            return this.GetLastWalk();
        }

        public DateTime GetLastWalk()
        {
            return this.lastWalk;
        }

        public override string ToString()
        {
            string retString = "Dog Last walked on " + this.lastWalk.ToShortDateString();
            retString += base.ToString();
            return retString;
        }
    }
}
