using System;
using System.Collections.Generic;

namespace lab_6
{
    class Student
    {
        public string Name { get; set; }
        public int Ects { get; set; }

        public override bool Equals(object obj)
        {
            Console.WriteLine("Students Equels");
            return obj is Student student &&
                   Name == student.Name &&
                   Ects == student.Ects;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ICollection<string> names = new List<string>();
            names.Add("Ewa");
            names.Add("Karol");
            names.Add("Adam");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine(names.Contains("Adam"));

            //
            Console.WriteLine();

            ICollection<Student> students = new List<Student>();
            students.Add(new Student { Name = "Ewa", Ects = 4});
            students.Add(new Student { Name = "Karol", Ects = 8 });
            students.Add(new Student { Name = "Adam", Ects = 1 });
            students.Remove(new Student { Name = "Karol", Ects = 8 });
            foreach (Student student in students)
            {
                Console.WriteLine(student.Name + ", " + student.Ects);
            }
            Console.WriteLine(students.Contains(new Student { Name = "Karol", Ects = 8 }));
            List<Student> list = (List<Student>)students;
            Console.WriteLine(list[0]);
            list.Insert(1, new Student { Name = "Robert", Ects = 12 });
            foreach (Student student in list)
            {
                Console.WriteLine(student.Name + ", " + student.Ects);
            }
            int index = list.IndexOf(new Student { Name = "Adam", Ects = 1 });
            Console.WriteLine("Karol ma pozycje " + index);
            list.RemoveAt(index);
            Console.WriteLine("-----------------------------------------SET------------------------------------");
            ISet<string> set = new HashSet<string>();

            set.Add("Ewa");
            set.Add("Karol");
            set.Add("Adam");
            
           
            foreach(string name in set)
            {
                Console.WriteLine(name);
                
            }
            ISet<Student> studentGroup = new HashSet<Student>();
            studentGroup.Add(new Student { Name = "Ewa", Ects = 12 });
            studentGroup.Add(new Student { Name = "Karol", Ects = 13 });
            studentGroup.Add(new Student { Name = "Adam", Ects = 15 });
            foreach(Student name in studentGroup)
            {
                Console.WriteLine(name.Name + " " + name.Ects);
            }
            studentGroup.Contains(new Student { Name = "Ewa", Ects = 12 });
            Dictionary<Student, string> phoneBook = new Dictionary<Student, string>();
            phoneBook[list[0]] = "22323232323";
            phoneBook[list[1]] = "22323232353";
            phoneBook[new Student() { Name = "Pipka", Ects = 22 } ] = "22323562323";
            Console.WriteLine(phoneBook.Keys);
            if (phoneBook.ContainsKey(new Student { Name = "Ewa", Ects = 12 }))
            {
                Console.WriteLine("Jest telefon");
            }
            else
            {
                Console.WriteLine("Nie ma telefonu");
            }
            foreach(var item in phoneBook)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
            string[] arr = { "adam", "ewa", "karol", "ewa", "ania", "karol", "adam", "adam", "ewa"};
            Dictionary<string, int> counters = new Dictionary<string, int>();
            foreach(string name in arr)
            {
                if (counters.ContainsKey(name))
                {
                    counters[name] += 1;
                }
                else
                {
                    counters.Add(name, 1);
                }

            }
            foreach(var item in counters)
            {
                Console.WriteLine(item.Key + "wystepuje" + item.Value);
            }
        }
    }
}
