using System;
using System.Text.Json;
using System.IO;
using System.Text;
using System.Collections.Generic;
   

    namespace serial
    {
        public class Program
        {
            public static void Main()
            {
    // using (FileStream fs = new FileStream("user.json", FileMode.OpenOrCreate))
    // {
    //     Person tom = new Person("Tom",37, new string[]{"Dad", "Mom", "GrandMom"} );
    //     JsonSerializer.SerializeAsync<Person>(fs, tom);
    //     Console.WriteLine("Data has been saved to file");
    // }

        string user = "example.json";
        string jsonString = File.ReadAllText(user);
        Event events = JsonSerializer.Deserialize<Event>(jsonString)!;
        Console.WriteLine($"Code: {events?.code} timestamp: {events?.timestamp} payment: {events?.payment}");


    // using (FileStream fs = new FileStream("user.json", FileMode.OpenOrCreate))
    // {
    //     Person? person = JsonSerializer.DeserializeAsync<Person>(fs);
    //     Console.WriteLine($"Name: {person?.Name} Age: {person?.Age}");
    // }
            }
    // public class Person
    // {
    //     public string? Name { get;}
    //     public int Age { get; set; }
    //     public string[] Parents { get; set; }

    //     public Person(string name, int age, string[] parents)
    //     {
    //         Name = name;
    //         Age = age;
    //         Parents = parents; 
    //     }
    }
        }
    