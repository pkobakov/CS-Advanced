using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace VetClinic
{
    public class Clinic
    {
        private List<Pet> pets;

        public int Capacity { get; set; }

        public int Count
        {
            get
            {
                return this.pets.Count;
            }
        }

        public Clinic (int capacity) 
        {
            Capacity = capacity;
            pets = new List<Pet>();
        }

        

        public void Add(Pet pet) 
        {
            if (Capacity>pets.Count)
            {
                pets.Add(pet);
            }
        
        }

        public bool Remove(string name) 
        {
            foreach (var pet in pets)
            {
                if (pet.Name == name)
                {
                    pets.Remove(pet);

                    return true;
                }
            }
            return false;
        }

        public Pet GetPet(string name, string owner) 
        {
            foreach (var pet in pets)
            {
                if (pet.Name == name && pet.Owner == owner)
                {
                    return pet;
                }
            }

            return null;
        }

        public Pet GetOldestPet() 
        {


            var old = pets.OrderByDescending(p => p.Age).ToArray();
            var oldest = old[0];
            return oldest;
        
        }

        public string GetStatistics() 
        {

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"The clinic has the following patients: ");

            foreach (var pet in pets)
            {
                sb.AppendLine($"Pet {pet.Name} with owner: {pet.Owner}");
            }

            return sb.ToString().Trim();
        }





    }


}
