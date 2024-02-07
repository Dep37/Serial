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
                 string user = "example.json";
                 string jsonString = File.ReadAllText(user);
                 var options = new JsonSerializerOptions
                 {
                    WriteIndented = true
                 };
                 Event? events = JsonSerializer.Deserialize<Event>(jsonString);

              // for (int i = 0; i < events.Length; i++)
                   //Console.WriteLine($"Code: {events?[i].code} timestamp: {events?[i].timestamp}");
                  //names: {events?.events[i].ev.names} cheater: {events?.events[i].ch.cheater} payments: {events?.events[i].vp.payments}");
              using (FileStream fs = new FileStream("user.json", FileMode.OpenOrCreate))
                {
                    JsonSerializer.SerializeAsync(fs, events, options);
                }      
                
            }
         }
     }
    