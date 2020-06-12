using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Model
{
    public class OData
    {
        [JsonProperty("odata.metadata")]
        public string Metadata { get; set; }
        public List<Student> Value { get; set; }
    }
}
