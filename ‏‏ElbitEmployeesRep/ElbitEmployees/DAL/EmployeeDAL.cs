using ElbitEmployees.Common;
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

namespace ElbitEmployees.DAL
{
    public static class EmployeeDAL
    {

        // initial mock data
        // [{"SSN":"03425678","FName":"Moshe","LName":"Cohen"},{"SSN":"05463345","FName":"Dani","LName":"Levi"}]



        /// <summary>
        /// get all employees from "DB" text file
        /// </summary>
        /// <returns></returns>
        public static List<Employee> GetEmployees()
        {
            List<Employee> AllCurrentEmps = new List<Employee>();

            // get the all employees from text
            AllCurrentEmps=TextDbHelper.GetDataFromDB<Employee>();

            return AllCurrentEmps;
        }

        /// <summary>
        /// set new employee to "DB" text file
        /// </summary>
        /// <param name="oEmp"></param>
        /// <returns></returns>
        public static List<Employee> setNewEmployee(Employee oEmp)
        {
            List<Employee> AllCurrentEmps = GetEmployees();

            // if SSN is identical - UPDATE. else - INSERT
            int index=AllCurrentEmps.FindIndex(emp => emp.SSN == oEmp.SSN);
            if (index!=-1)
            {
                AllCurrentEmps[index] = oEmp;
            }
            else
            {
                AllCurrentEmps.Add(oEmp);
            }

            //update the File
            TextDbHelper.SetDataToDB(AllCurrentEmps);

            return AllCurrentEmps;
        }

        /// <summary>
        /// delete the employee
        /// </summary>
        /// <param name="oEmp"></param>
        /// <returns></returns>
        public static List<Employee> deleteEmployee(Employee oEmp)
        {
            List<Employee> AllCurrentEmps = GetEmployees();

            // delete the item by ssn
            int index = AllCurrentEmps.FindIndex(emp => emp.SSN == oEmp.SSN);
            if (index != -1)
            {
                AllCurrentEmps.RemoveAt(index);
            }

            //update the File
            TextDbHelper.SetDataToDB(AllCurrentEmps);

            return AllCurrentEmps;
        }

    }
}
