using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElbitEmployees.Common
{
    [Serializable]
    public class Employee
    {
        public string SSN { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
    }
}

