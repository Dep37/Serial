using System;
using System.Text.Json;
using System.Collections.Generic;

namespace serial 
{

  public class Event
    {
        public string code { get; set; }
        public string step { get; set; }
        public int timestamp { get; set; }
        public Payment payment { get; set; }
        public List<string> names { get; set; }
        public bool? cheater { get; set; }
        public List<Payment> payments { get; set; }
    }

    public class Payment
    {
        public string currency { get; set; }
        public double value { get; set; }
    }

    public class Payment2
    {
        public string currency { get; set; }
        public int value { get; set; }
    }

    public class Root
    {
        public List<Event> events { get; set; }
    }
}