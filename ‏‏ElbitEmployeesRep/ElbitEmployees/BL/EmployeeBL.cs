using ElbitEmployees.Common;
using ElbitEmployees.DAL;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ElbitEmployees.BL
{
    public static class EmployeeBL
    {
        public static List<Employee> GetEmployees()
        {
            List<Employee> AllCurrentEmps = new List<Employee>();

            AllCurrentEmps = EmployeeDAL.GetEmployees();

            return AllCurrentEmps;
        }

        public static List<Employee> setNewEmployee(Employee oEmp)
        {
            List<Employee> AllCurrentEmps = GetEmployees();

            AllCurrentEmps = EmployeeDAL.setNewEmployee(oEmp);

            return AllCurrentEmps;
        }

        public static List<Employee> deleteEmployee(Employee oEmp)
        {
            List<Employee> AllCurrentEmps = GetEmployees();

            AllCurrentEmps = EmployeeDAL.deleteEmployee(oEmp);

            return AllCurrentEmps;
        }

    }
}
