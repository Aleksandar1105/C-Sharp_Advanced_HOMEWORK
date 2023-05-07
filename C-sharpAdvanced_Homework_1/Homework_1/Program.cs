using Homework_1;
using Homework_1.Entities;
using Newtonsoft.Json;
using Homework_1.FileSystemHelper;

string folderPath = @"..\..\..\Dogs";
string filePath = folderPath + @"\dogsJson.json";

if (!Directory.Exists(folderPath))
{
    Directory.CreateDirectory(folderPath);
}

List<Dog> dogs = new List<Dog>();

Console.WriteLine("Enter the number of dogs to add:");
int numDogs = int.Parse(Console.ReadLine());

for (int i = 0; i < numDogs; i++)
{
    Console.WriteLine($"Enter dog {i + 1} name:");
    string name = Console.ReadLine();
    Console.WriteLine($"Enter dog {i + 1} age:");
    int age = int.Parse(Console.ReadLine());
    Console.WriteLine($"Enter dog {i + 1} color:");
    string color = Console.ReadLine();

    Dog dog = new Dog(name, age, color);
    dogs.Add(dog);
}

string jsonDog = JsonConvert.SerializeObject(dogs);

ReaderWriter.WriteFile(filePath, jsonDog);

Dog.PrintAllDogs(filePath);

