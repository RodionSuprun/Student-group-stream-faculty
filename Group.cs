using System;
using System.Collections.Generic;

namespace OOP
{
    public class Group
    {   
        
        private string _name;
        private int _course;
        private List<Student> _students;
        private string _cathedra;
        
    

        public Group(string name, int course, List<Student> students, string cathedra)
        {
            _name = name;
            _course = course;
            _students = students;
            _cathedra = cathedra;
        }

        public Group(string name)
        {
            _name = name;
            _students = new List<Student>();
        }

        public Group()
        {
           
        }

       
        public void PrintStudents()
        {
            foreach (var item in _students)
            {
                item.PrintStudent();
            }
        }

        public void AddStudent(Student newstudent)
        {
            _students.Add(newstudent);
        }

        public void DeleteStudentByID(int _ID)
        {
            _students.RemoveAt(_ID);
        }
        
        public int AverageGPA() {
            int sumGPA = 0;
            for(int i = 0; i < _students.Count; i++) 
            {
                sumGPA += _students[i].GetGPA;
            } 
            return sumGPA / _students.Count;
        }

        public void PrintGroup()
        {
            Console.WriteLine(_name);
        }

        public int AmountOfMan() 
        {
            int sum = 0;
            foreach (var item in _students)
            {
               if( item.GetGender == true)
               {
                   sum++;
               }
            }

            return sum;
        }

        public int AmountOfWoman() 
        {
            return _students.Count - AmountOfMan() ;
        }



        public void DeleteThird(Student obj)
        {   
            for(int i = 0; i < _students.Count; i++) 
            {
                if( _students[i].GetCourse == 3)
                {
                    _students.Remove(obj);
                }
            } 
            
        }



        

    }
}