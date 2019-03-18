using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43
{
    class Student
    {
        private int grade;

        public int Grade
        {
            get { return grade; }
            set {
                if(grade>= 0 && grade<=100)
                {
                    grade = value;
                } 
            }
        }


        private int age;

        public int Age
        {
            get { return age; }
            set {
                if (age >= 18 && age <= 120)
                {
                    age = value;
                }
            }
        }


        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Student(string Name, int Grade,int Age)
        {
            name = Name;
            grade = Grade;
            age = Age;
        }

        public string ToString()
        {
            return $"Name: {name} Age: {age} Grade: {grade}"; 
        }

    }
}
