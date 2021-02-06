using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace VetClinic
{
    public class Clinic
    {

        private List<Pet> data;


        public Clinic(int capacity)
        {
            this.Capacity = capacity;
            this.data = new List<Pet>();
        }

        public int Capacity { get; set; }

        public int Count
        {
            get
            {
                return this.data.Count;
            }
        }


        public void Add(Pet pet)
        {
            if (this.Capacity > this.Count)
            {
                this.data.Add(pet);
            }
        }

        public bool Remove(string name)
        {

            foreach (var pet in this.data)
            {
                if (pet.Name == name)
                {
                    this.data.Remove(pet);
                    return true;
                }
            }

            return false;
        }

        public Pet GetPet(string name, string owner)
        {
            foreach (var pet in this.data)
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

            int max = int.MinValue;

            Pet oldestPet = null;

            foreach (var pet in this.data)
            {

                if (max < pet.Age)
                {
                    max = pet.Age;
                    oldestPet = new Pet(pet.Name, pet.Age, pet.Owner);
                }
            }

            return oldestPet;
        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("The clinic has the following patients:");

            foreach (var pet in this.data)
            {
                sb.AppendLine($"Pet {pet.Name} with owner: {pet.Owner}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
