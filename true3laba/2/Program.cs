﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2
{
    class Person2
    {
        public int age;
        public string name;

        public Person2() { name = "Noname"; age = 1; }
        public Person2(int i) { name = "Noname"; age = i; }
        public Person2(string n, int i) { name = n; age = i; }
        public void GetInfo()
        {
            Console.WriteLine(name + age + 's');
        }
    }
 

    class Program
    {
        static void Main(string[] args)
        {
            Person2 Andrusha = new Person2(12);
            Andrusha.GetInfo();
            Console.ReadKey();

        }
    }
}
