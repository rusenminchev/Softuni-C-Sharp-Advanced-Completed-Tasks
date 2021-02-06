using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {

        private string name;
        private int age;

        public Person()
        {

        }
        public Person(int age)
            : this()
        {
            this.Age = age;
        }
        public Person(string name, int age)
            : this(age)
        {
            this.Name = name;
        }



        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }

        // Така можем да задаваме какво да връща като стринг, когато трябва да печатаме колекции от клас.
        //public override string ToString()
        //{
        //    return $"{this.Name} - {this.Age}";
        //}
    }
}
