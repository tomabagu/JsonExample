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
            Console.WriteLine();
        }

        // Path to the local JSON file
        string filePathAdmin = "admin.json";

        // Read the JSON data from the file
        string jsonResponseAdmin = File.ReadAllText(filePathAdmin);

        // Deserialize the Admin JSON into a C# object
        AdminUser admin = JsonConvert.DeserializeObject<AdminUser>(jsonResponseAdmin);

        // Display the user's information
            Console.WriteLine($"Name: {admin.Name}");
            Console.WriteLine($"Age: {admin.Age}");
            Console.WriteLine($"City: {admin.City}");
            Console.WriteLine($"Role: {admin.Role}");
            Console.WriteLine();

        // Path to the local JSON file
        string filePathUser = "regular_user.json";

        // Read the JSON data from the file
        string jsonResponseRegularUser = File.ReadAllText(filePathUser);

        // Deserialize the RegularUser JSON into a C# object
        List<RegularUser> regular_users = JsonConvert.DeserializeObject<List<RegularUser>>(jsonResponseRegularUser);

        // Display the user's information
        foreach (RegularUser regular_user in regular_users)
        {
            Console.WriteLine($"Name: {regular_user.Name}");
            Console.WriteLine($"Age: {regular_user.Age}");
            Console.WriteLine($"City: {regular_user.City}");
            Console.WriteLine($"Role: {regular_user.Role}");
            Console.WriteLine();
        }
    }
}
