using Homework_1.FileSystemHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1.Entities
{
    public class Dog
    {
        public Dog(string name, int age, string color)
        {
            Name = name;
            Age = age;
            Color = color;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }

        public static void PrintAllDogs(string filePath)
        {
            if (File.Exists(filePath))
            {
                string jsonDogs = ReaderWriter.ReadFile(filePath);
                List<Dog> dogs = JsonConvert.DeserializeObject<List<Dog>>(jsonDogs);
                foreach (Dog dog in dogs)
                {
                    Console.WriteLine($"Name: {dog.Name}, Age: {dog.Age}, Color: {dog.Color}");
                }
            }
            else
            {
                Console.WriteLine("There are not dogs in this file.");
            }
        }
    }
}
