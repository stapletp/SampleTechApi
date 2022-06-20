using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleTechApi.Models.Shared
{
    public class Location
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public Char State { get; set; }
        public int ZipCode { get; set; }
    }
}