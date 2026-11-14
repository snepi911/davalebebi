using System;
using System.Collections.Generic;
using System.Text;
#nullable disable

namespace OOP1

{

    internal class Student
    {

        private int _id;
        private string _firstName;
        private string _lastName ;
        private int _age;
        private string _personalId;
        private string _email;
        private string _phoneNumber;
        private string _faculty;
        private int _course;
        private double _gpa;

        public Student(int id, string firstName, string lastName, int age, string personalId, string email, string phoneNumber, string faculty, int course, double gpa)
        {
            _id = id;
            _firstName = firstName;
            _lastName = lastName;
            _age = age;
            _personalId = personalId;
            _email = email;
            _phoneNumber = phoneNumber;
            _faculty = faculty;
            _course = course;
            _gpa = gpa;
        }

        public int Id
        {
            get { return _id; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Error: ID must be a positive number.");
                }
                else
                {
                    _id = value;
                }
            }
        }

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Trim().Length < 2)
                {
                    Console.WriteLine("Error: First name must be at least 2 characters long.");
                }
                else
                {
                    _firstName = value.Trim();
                }
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Trim().Length < 2)
                {
                    Console.WriteLine("Error: Last name must be at least 2 characters long.");
                }
                else
                {
                    _lastName = value.Trim();
                }
            }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 16 || value > 100)
                {
                    Console.WriteLine("Error: Age must be between 16 and 100.");
                }
                else
                {
                    _age = value;
                }
            }
        }

        public string PersonalId
        {
            get { return _personalId; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length != 11 || !long.TryParse(value, out _))
                {
                    Console.WriteLine("Error: Personal ID must consist of exactly 11 digits.");
                }
                else
                {
                    _personalId = value;
                }
            }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || !value.Contains("@") || !value.Contains("."))
                {
                    Console.WriteLine("Error: Invalid email format.");
                }
                else
                {
                    _email = value.Trim();
                }
            }
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Trim().Length < 9)
                {
                    Console.WriteLine("Error: Phone number must be at least 9 characters long.");
                }
                else
                {
                    _phoneNumber = value.Trim();
                }
            }
        }

        public string Faculty
        {
            get { return _faculty; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Error: Faculty name cannot be empty.");
                }
                else
                {
                    _faculty = value.Trim();
                }
            }
        }

        public int Course
        {
            get { return _course; }
            set
            {
                if (value < 1 || value > 6)
                {
                    Console.WriteLine("Error: Course must be between 1 and 6.");
                }
                else
                {
                    _course = value;
                }
            }
        }

        public double GPA
        {
            get { return _gpa; }
            set
            {
                if (value < 0.0 || value > 4.0)
                {
                    Console.WriteLine("Error: GPA must be between 0.0 and 4.0.");
                }
                else
                {
                    _gpa = value;
                }
            }
        }



        public void PrintFullInfo()
        {
            Console.WriteLine("==========================================");
            Console.WriteLine("           STUDENT INFORMATION            ");
            Console.WriteLine("==========================================");
            Console.WriteLine($"ID:           {Id}");
            Console.WriteLine($"Full Name:    {FirstName} {LastName}");
            Console.WriteLine($"Age:          {Age}");
            Console.WriteLine($"Personal ID:  {PersonalId}");
            Console.WriteLine($"Email:        {Email}");
            Console.WriteLine($"Phone:        {PhoneNumber}");
            Console.WriteLine($"Faculty:      {Faculty}");
            Console.WriteLine($"Course:       {Course}");
            Console.WriteLine($"GPA:          {GPA:F2}");
            Console.WriteLine("==========================================");
        }


    }
}
