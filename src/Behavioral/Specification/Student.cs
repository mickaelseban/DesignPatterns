namespace DesignPatterns.Behavioral.Specification
{
    using System;

    public class Student
    {
        public Student(string name, DateTime birthDate)
        {
            Name = name;
            BirthDate = birthDate;
        }

        public DateTime BirthDate { get; private set; }
        public string Name { get; private set; }
    }
}
