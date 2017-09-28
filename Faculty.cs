using System;
using System.Collections.Generic;

namespace OOP
{
    public class Faculty
    {
        private List<Stream> _streams;
        private string _name;
        
        
        public Faculty( List<Stream> streams, string name)
        {   
            _streams = streams;
            _name = name;
        }

        public Faculty(string name)
        {   
            _name = name;
             _streams = new List<Stream>();
        }

        public Faculty()
        {   
            
        }

       
       
       public void DeleteThird(Stream obj)
        {   
            for(int i = 0; i < _streams.Count; i++) 
            {
                streams[i].DeleteThird(obj) ;
                    
            } 
            
        }


        





        public void AddStream(Stream newstream)
        {
            _streams.Add(newstream);
        }

        public void DeleteStream(Stream obj)
        {
            _streams.Remove(obj);
        }

        public void PrintGroups()
        {
            foreach (var item in _streams)
            {
                item.PrintGroups();
               
            }
        }

        
        public void PrintAllStudents()
        {
            foreach (var item in _streams)
            {
               item.PrintStudents();
            }
        }

        

        public int FacultyAverageGPA() {
            int sumGPA = 0;
            for(int i = 0; i < _streams.Count; i++) 
            {
                sumGPA += _streams[i].StreamAverageGPA();
            } 
            return sumGPA / _streams.Count;
        }






    }
}