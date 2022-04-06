using System;
using System.Collections.Generic;

namespace lab_3
{
    enum Degree
    {
        A = 50,
        B = 45,
        C = 40,
        D = 35,
        E = 30,
        F = 20
    }


  class Program
    {
        static void Main(string[] args)
        {
            Degree degree = Degree.F;
            Console.WriteLine((int)degree);
            string[] vs = Enum.GetNames<Degree>();
            Console.WriteLine(string.Join(",", vs));
            Degree[] degrees = Enum.GetValues<Degree>();
            foreach(Degree d in degrees)
            {
                Console.WriteLine($"{d} {(int)d}");
            }
            Console.WriteLine("Wpisz ocene ");
            string str = Console.ReadLine();
            try
            {
                Degree studentDegree = Enum.Parse<Degree>(str);
                Console.WriteLine("Wpisales ocene" + studentDegree);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("nie");
            }




        }

    }


}