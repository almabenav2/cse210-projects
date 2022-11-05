using System;
using System.Collections.Generic;

namespace SandboxProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.SetFirstName("Jonh");
            person1.SetLastName("Doe");

            Console.WriteLine(person1.GetFullName());

            ChurchMember person2 = new ChurchMember();
            person2.SetFirstName("Jane");
            person2.SetLastName("Doe");
            person2.SetCalling("Teacher of primary");

            Console.WriteLine(person2.GetFullName());
            Console.WriteLine(person2.GetFullInfo());



        }
    }
}
