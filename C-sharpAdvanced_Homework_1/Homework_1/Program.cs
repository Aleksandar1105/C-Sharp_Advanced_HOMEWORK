//Create a Dog class with :

//● Name, Age, Color
//● Let the user input these parameters from a console application
//● Create a new Dog object from the inputs and write it as a json in
//a new file on the file system
//● Create a method that reads and prints in the console all the dogs
//from the json file

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

Console.WriteLine("Enter dog name:");
string name = Console.ReadLine();
Console.WriteLine("Enter dog age:");
int age = int.Parse(Console.ReadLine());
Console.WriteLine("Enter dog color:");
string color = Console.ReadLine();


Dog dog = new Dog(name, age, color);

string jsonDog = JsonConvert.SerializeObject(dog);

ReaderWriter.WriteFile(filePath, jsonDog);


Dog.PrintAllDogs(filePath);

