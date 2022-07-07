﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Loader;

namespace BabyStroller.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var folder = Path.Combine(Environment.CurrentDirectory, "Animals");
            var files = Directory.GetFiles(folder);
            var animalTypes = new List<Type>();
            foreach (var file in files)
            {
                var assembly = AssemblyLoadContext.Default.LoadFromAssemblyPath(file);
                var types = assembly.GetTypes();
                foreach (var type in types)
                {
                    if(type.GetMethod("Voice") != null)
                    {
                        animalTypes.Add(type);
                    }
                }
            }

            while (true)
            {
                for (int i = 0; i < animalTypes.Count; i++)
                {
                    Console.WriteLine($"{i+1}.{animalTypes[i].Name}");
                }
                Console.WriteLine("-------------------------");
                Console.WriteLine("Please choose animal:");
                int index = int.Parse(Console.ReadLine());
                if(index > animalTypes.Count || index < 1)
                {
                    Console.WriteLine("No such an animal. Try again!");
                    continue;
                }

                Console.WriteLine("How many times?");

                int times = int.Parse(Console.ReadLine());
                var t = animalTypes[index - 1];
                var m = t.GetMethod("Voice");
                var o = Activator.CreateInstance(t);
                m.Invoke(o, new object[] { times });
            }
        }
    }
}
