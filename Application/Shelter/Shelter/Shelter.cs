using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShelterManager
{
    [Serializable]
    public class Shelter
    {
        private List<Animal> animals;
        private List<Owner> owners;
        private string address;
        private string email;
        private string name;
        private string phoneNumber;

        public Shelter(string name, string address, string email, string phoneNumber)
        {
            this.address = address;
            this.email = email;
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.animals = new List<Animal>();
            this.owners = new List<Owner>();
        }

        public bool AddAnimal(Animal newAnimal)
        {
            foreach (Animal a in this.animals)
            {
                if (a.GetRFID() == newAnimal.GetRFID())
                {
                    return false;
                }
            }
            this.animals.Add(newAnimal);
            return true;
        }

        public bool AddOwner(Owner owner)
        {
            foreach (Owner o in this.owners)
            {
                if (o.GetID() == owner.GetID())
                {
                    return false;
                }
            }
            this.owners.Add(owner);
            return true;
        }

        public List<Animal> ListAdoptable()
        {
            List<Animal> retList = new List<Animal>();

            foreach (Animal a in this.animals)
            {
                if (a.IsAdoptable())
                {
                    retList.Add(a);
                }
            }

            return retList;
        }

        public List<Animal> ListClaimable(Owner checkOwner)
        {
            List<Animal> retList = new List<Animal>();
            foreach (Animal a in this.animals)
            {
                if (a.IsClaimable(checkOwner))
                {
                    retList.Add(a);
                }
            }
            return retList;
        }

        public List<Animal> ListAnimals()
        {
            return this.animals;
        }

        public List<Animal> ListAnimalsInShelter()
        {
            List<Animal> retList = new List<Animal>();

            foreach (Animal a in this.animals)
            {
                if (a.InShelter)
                {
                    retList.Add(a);
                }
            }
            return retList;
        }

        public List<Owner> ListOwner()
        {
            return this.owners;
        }

        public Animal GetByRFID(string rfid)
        {
            foreach (Animal a in this.animals)
            {
                if (a.GetRFID() == rfid)
                    return a;
            }
            return null;
        }


        public bool CheckIn(string rfid)
        {
            Animal a = this.GetByRFID(rfid);
            if (a != null)
            {
                return a.checkIn();
            }
            return false;
            
        }
        public string getName()
        {
            return this.name;
        }


        public string GetShelterDetails()
        {
            string retString;
            retString = String.Format("Shelter {0} Details: Email - {1} Phone - {2} Address {3}", this.name, this.email, this.phoneNumber, this.address);
            return retString;
        }

    }
}
