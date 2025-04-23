namespace JsonExample;
using Newtonsoft.Json;
using System;
using System.IO;

partial class Program
{
    static void Main(string[] args)
    {
        // Path to the local JSON file
        string filePath = "user.json";

        // Read the JSON data from the file
        string jsonResponse = File.ReadAllText(filePath);

        // Deserialize the JSON into a C# object
        List<User> users = JsonConvert.DeserializeObject<List<User>>(jsonResponse);

        // Display the user's information
        foreach (User user in users)
        {
            Console.WriteLine($"Name: {user.Name}");
            Console.WriteLine($"Age: {user.Age}");
            Console.WriteLine($"City: {user.City}");
        }
    }
}
