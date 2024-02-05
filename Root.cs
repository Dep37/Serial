using System;
using System.Text.Json;
using System.Collections.Generic;
using System.IO;

namespace serial 
{

    public class Root
    {
        public List<Event>? events { get; set; }
    }
}