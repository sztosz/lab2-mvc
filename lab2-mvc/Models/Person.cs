using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab2_mvc.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Sex { get; set; }
        public string Job { get; set; }
        public List<String> HobbyList { get; set; }
    }
}