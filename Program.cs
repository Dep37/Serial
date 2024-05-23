using System;
using System.Text.Json;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

   

    namespace serial
    {
        
        public class Program
        {

            public static void Main()
            {
                
            string user = "example.json";
            string jsonString = File.ReadAllText(user);
            var options = new JsonSerializerOptions
                 {
                    WriteIndented = true
                 };
            Event? events = JsonSerializer.Deserialize<Event>(jsonString);

            var context = new ValidationContext(events!);
            var results = new List<ValidationResult>();
            if (!Validator.TryValidateObject(events!, context, results, true))
                {
                    Console.WriteLine("Ошибка по валидации");
                    foreach (var error in results)
                        {
                            Console.WriteLine(error.ErrorMessage);
                        }
                }
            else
                Console.WriteLine("Нет ошибки по валидации");

            for (int i = 0; i < events!.LenghtEv(); i++)
                {
                    Console.WriteLine(events.indexEv(i).GetType());
                }

            for (int i = 0; i < events.LenghtEv(); i++)
                {
                   Console.WriteLine($"Code: {events.typeEv(i)} timestamp: {events.indexEv(i).timestamp}");
                    switch(events.typeEv(i).ToString())
                    {
                     case "serial.Tr":
                         Console.WriteLine($"Code: Tr, Step: ");
                         break;
                     case  "serial.Ch":
                         Console.WriteLine($"Code: Ch, Cheater: ");
                         break;
                     case "serial.Ev":
                         Console.WriteLine($"Code: Ev, Names: ");
                         break;
                     case "serial.Pr":
                         Console.WriteLine($"Code: Pr, Payment: ");
                         break;
                     case "serial.Vp":
                         Console.WriteLine($"Code: Vp; Payments: ");
                         break;
                    }
                }

              using (FileStream fs = new FileStream("user.json", FileMode.OpenOrCreate))
                {
                    JsonSerializer.SerializeAsync(fs, events, options);
                }      
                
            }
         }
     }
    