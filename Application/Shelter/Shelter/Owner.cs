using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShelterManager
{
    [Serializable]
    public class Owner
    {
        private string ID;
        private string LastName;

        public Owner(string id, string lastName)
        {
            this.ID = id;
            this.LastName = lastName;
        }

        public string GetID()
        {
            return this.ID;
        }

        public string GetName()
        {
            return this.LastName;
        }

        public override string ToString()
        {
            return String.Format("Name: {0} ID: {1}", this.LastName, this.ID);
        }
    }
}
