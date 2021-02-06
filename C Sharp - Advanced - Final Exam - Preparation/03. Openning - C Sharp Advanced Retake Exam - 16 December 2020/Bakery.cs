using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace BakeryOpenning
{
    public class Bakery
    {

        private HashSet<Employee> data;


        public Bakery(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.data = new HashSet<Employee>();
        }
        public string Name { get; set; }
        public int Capacity { get; set; }

        public int Count
        {
            get
            {
                return this.data.Count;
            }
        }

        public void Add(Employee employee)
        {
            if (this.Count < this.Capacity)
            {
                this.data.Add(employee);
            }
        }

        public bool Remove(string name)
        {
            if (this.data.Any(x => x.Name == name))
            {
                this.data = this.data.Where(x => x.Name != name).ToHashSet();
                return true;
            }

            return false;
        }

        public Employee GetOldestEmployee()
        {
            Employee employee = this.data.OrderByDescending(x => x.Age).FirstOrDefault();
            return employee;
        }

        public Employee GetEmployee(string name)
        {
            Employee employee = this.data.FirstOrDefault(x => x.Name == name);
            return employee;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Employees working at Bakery {this.Name}");

            sb.AppendLine(String.Join(Environment.NewLine, this.data));

            return sb.ToString().TrimEnd();
        }
    }
}
