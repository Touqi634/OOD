using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShelterManager
{
    [Serializable]
    public class Cat : Animal
    {
        private string extraInfo;
        public Cat(DateTime DateFound, string locationFound, string description, string RFID, string extraInfo)
            : base(DateFound, locationFound, description, RFID)
        {
            this.extraInfo = extraInfo;
        }
        public override double Adopt(Owner newOwner)
        {
            if (this.IsAdoptable())
            {
                base.setOwner(newOwner);
                base.inShelter = false;
                return 25.00;                
            }
            return -1;
        }

        public override double Claim(Owner newOwner)
        {
            if (this.IsClaimable(newOwner))
            {
                this.setOwner(newOwner);
                base.inShelter = false;
                return 15.00;
                
            }
            return -1;
        }

        public string GetExtraInfo()
        {
            return this.extraInfo;
        }

        public override string ToString()
        {
            string retString = String.Format("Cat, {0}, ", this.extraInfo);
            retString += base.ToString();
            return retString;
        }
    }
}
