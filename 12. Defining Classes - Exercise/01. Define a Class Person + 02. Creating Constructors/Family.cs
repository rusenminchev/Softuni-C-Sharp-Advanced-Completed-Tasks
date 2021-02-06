using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        private HashSet<Person> familyMembers;

        public Family()
        {
            this.familyMembers = new HashSet<Person>();
        }



        public void AddMember(Person person)
        {
            this.familyMembers.Add(person);
        }

        public Person GetOldestMember()
        {

            Person oldestPerson = this.familyMembers.OrderByDescending(x => x.Age).FirstOrDefault();
            
            return oldestPerson;
        }

        public HashSet<Person> GetAllThePeopleOver30()
        {
            return this.familyMembers.Where(x => x.Age > 30).OrderBy(x => x.Name).ToHashSet();
        }
    }
}
