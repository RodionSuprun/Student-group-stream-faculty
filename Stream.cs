using System;
using System.Collections.Generic;

namespace OOP
{
    public class Stream
    {
        private int _course;
        private List<Group> _groups;
        
        public Stream(int course, List<Group> groups)
        {
            _course = course; 
            _groups = groups;
        }

        public Stream(int course)
        {
            _course = course; 
            _groups = new List<Group>();
        }

        public Stream()
        {
            
        }

        

        public void PrintStudents()
        {
            foreach (var item in _groups)
            {
                item.PrintStudents();
            }
        }
        

        public int StreamAverageGPA() {
            int sumGPA = 0;
            for(int i = 0; i < _groups.Count; i++) 
            {
                sumGPA += _groups[i].AverageGPA();
            } 
            return sumGPA / _groups.Count;
        }

        public void AddGroup(Group newgroup)
        {
            _groups.Add(newgroup);
        }

        public void DeleteGroup(Group obj)
        {
            _groups.Remove(obj);
        }

        public void PrintGroups()
        {
            foreach (var item in _groups)
            {
                item.PrintGroup();
               
            }
        }

        public void DeleteThird(Group obj)
        {   
            for(int i = 0; i < _groups.Count; i++) 
            {
                groups[i].DeleteThird(obj) ;
                    
            } 
            
        }






    }
}