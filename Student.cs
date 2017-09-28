using System;
using System.Collections.Generic;

namespace OOP
{
    public class Student
    {   
        

        private string _name;
        private string _surname;
        private string _ID;
        private Group _group;
        private int _GPA;
        private int _course;
        private bool _male;
        private bool _female;

        

        public Student(string name, string surname, int GPA, string ID, int course, bool male, bool female)
        {
            _name = name;
            _surname = surname;
            _GPA = GPA;
            _ID = ID;
            _course = course;
            _male = male;
            _female = female;
        }
        
        public Student(string name, string surname, int GPA, Group group)
        {
            _name = name;
            _surname = surname;
             _GPA = GPA;
             _group = group;
        }

        public Student()
        {
           
        }

        

        public void PrintStudent()
        {
            Console.WriteLine(_name + " " + _surname);
        }

        public string GetFullName 
        {
            get
            {
                return _name + " " + _surname;
            }
        }

        public int GetGPA
        {
            get 
            { 
                return _GPA; 
            }
        }

        public bool GetGender
        {
            get
            {
                return _male;
            }
        }

        public int GetCourse
        {
            get 
            { 
                return _course; 
            }
        }


    }
}