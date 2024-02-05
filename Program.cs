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
                 Root? events = JsonSerializer.Deserialize<Root>(jsonString)!;

              for (int i = 0; i < events.events.Count; i++)
                  Console.WriteLine($"Code: {events?.events[i].GetType()} timestamp: {events?.events[i]}");
                  //names: {events?.events[i].ev.names} cheater: {events?.events[i].ch.cheater} payments: {events?.events[i].vp.payments}");
                    
            }
         }
     }
    