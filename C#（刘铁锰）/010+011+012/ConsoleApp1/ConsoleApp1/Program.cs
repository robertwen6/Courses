﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person();
            person1.Name = "XiaoMing";
            person2.Name = "XiaoHong";
            List<Person> nation = new List<Person>();
            //nation = Person.GetMarry(person1, person2);
            nation = person1 + person2;
            foreach (var p in nation)
            {
                Console.WriteLine(p.Name);
            }
        }
    }

    class Person
    {
        public string Name;

        //public static List<Person> GetMarry(Person p1, Person p2)
        //{
        //    List<Person> people = new List<Person>();
        //    people.Add(p1);
        //    people.Add(p2);
        //    for (int i = 0; i < 11; i++)
        //    {
        //        Person child = new Person();
        //        child.Name = p1.Name + " & " + p2.Name + "'s child";
        //        people.Add(child);
        //    }
        //    return people;
        //}

        public static List<Person> operator +(Person p1, Person p2)
        {
            List<Person> people = new List<Person>();
            people.Add(p1);
            people.Add(p2);
            for (int i = 0; i < 11; i++)
            {
                Person child = new Person();
                child.Name = p1.Name + " & " + p2.Name + "'s child";
                people.Add(child);
            }
            return people;
        }
    }
}
