using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Model
{
    public class Student
    {
        [JsonProperty("odata.type")]
        public string Type { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }
    }
}
