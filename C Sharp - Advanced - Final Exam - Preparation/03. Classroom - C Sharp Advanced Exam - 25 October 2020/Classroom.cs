using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace ClassroomProject
{
    public class Classroom
    {
        private List<Student> students;

        public Classroom(int capacity)
        {
            this.Capacity = capacity;

            this.students = new List<Student>();
        }

        public int Capacity { get; private set; }
        public int Count => students.Count;

        public string RegisterStudent(Student student)
        {
            if (this.Count == this.Capacity)
            {
                return "No seats in the classroom";
            }

            this.students.Add(student);
            return $"Added student {student.FirstName} {student.LastName}";
        }

        public string DismissStudent(string firstName, string lastName)
        {
            Student student = this.students.FirstOrDefault
                (s => s.FirstName == firstName && s.LastName == lastName);

            if (student == null)
            {
                return $"Student not found";
            }

            this.students.Remove(student);
            return $"Dismissed student {firstName} {lastName}";
        }

        public string GetSubjectInfo(string subject)
        {
            var validStudents = this.students.Where(s => s.Subject == subject).ToList();

            if (validStudents.Count == 0)
            {
                return $"No students enrolled for the subject";
            }

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Subject: {subject}")
                .AppendLine("Students:")
                .AppendLine(string.Join(Environment.NewLine, 
                    validStudents.Select(s=>s.FirstName + " " + s.LastName)));

            return sb.ToString().TrimEnd();
        }

        public int GetStudentsCount()
        {
            return this.Count;
        }

        public Student GetStudent(string firstName, string lastName)
        {

          Student student = this.students.FirstOrDefault
                (s => s.FirstName == firstName && s.LastName == lastName);

          return student;
        }
    }
}
