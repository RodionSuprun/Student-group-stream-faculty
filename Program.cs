using System;
using System.Collections.Generic;

namespace OOP
{   



    class Program
    {
        static void Main(string[] args)
        {   
            //Студенты
        
            Student a = new Student("Rodion" , "Suprun" , 3 , "1" , 3 , true , false);
            Student b = new Student("Nugman" , "Kuspakov" , 3 , "2" , 3 , true , false);

            Student c = new Student("Lera" , "Polupanova" , 2 , "3" , 2 , false , true);
            Student d = new Student("Simba" , "Dog" , 2 , "4" , 2 , false , true);

            Student e = new Student("Arsen" , "Karataev" , 4 , "5" , 4 , true , false);
            Student f = new Student("Max" , "Kuanyshbek" , 5 , "6" , 4 , true , false);

            Student g = new Student("Lara" , "Croft" , 3 ," 7" , 1 , false , true);
            Student h = new Student("Triss" , "Merigold", 1 ," 8" , 1 , false , true);

            Student i = new Student("Boss" , "Little", 1 ," 9 " , 1 , true , false);

            
            //Группы
            List<Student> students = new List<Student>();
            students.Add(a);
            students.Add(b);
            students.Add(i);
            Group attack = new Group("Attack");
            attack.AddStudent(a);
            attack.AddStudent(b);
            attack.AddStudent(i);
            
            Group defense = new Group("Defense");
            defense.AddStudent(c);
            defense.AddStudent(d);
            
            Group tanks = new Group("Tanks");
            tanks.AddStudent(e);
            tanks.AddStudent(f);

            Group support = new Group("Support");
            support.AddStudent(g);
            support.AddStudent(h);

            //Потоки

            Stream first = new Stream(1);
            first.AddGroup(attack);
            first.AddGroup(defense);

            Stream second = new Stream(2);
            second.AddGroup(tanks);
            second.AddGroup(support);

            //Факультет

            Faculty big = new Faculty("BIG");
            big.AddStream(first);
            big.AddStream(second);


        // a.PrintStudent();

        Console.WriteLine(" ");
        Console.WriteLine(" Студенты факультета ");
        big.PrintAllStudents();

        Console.WriteLine(" ");
        Console.WriteLine(" Студенты потока ");
        first.PrintStudents();

        Console.WriteLine(" ");
        Console.WriteLine(" Студенты группы ");
        support.PrintStudents();

        // Console.WriteLine(" ");
        // Console.WriteLine("GPA студента ");
        // Console.WriteLine(a.GetGPA);

        

        // Console.WriteLine(" ");
        // Console.WriteLine("Full name ");
        // Console.WriteLine(e.GetFullName);

        // Console.WriteLine(" ");
        // Console.WriteLine("Количество женщин в группе оборона ");
        // Console.WriteLine(defense.AmountOfWoman());

        // Console.WriteLine(" ");
        // Console.WriteLine(defense.AverageGPA());

        // Console.WriteLine(" ");
        // Console.WriteLine(second.StreamAverageGPA());

        // Console.WriteLine(" ");
        // second.PrintGroups();

        // Console.WriteLine(" ");
        // Console.WriteLine(big.FacultyAverageGPA());
        

        


        }
    }
}
