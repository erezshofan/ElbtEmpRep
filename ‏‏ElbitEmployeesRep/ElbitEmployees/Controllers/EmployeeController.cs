using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElbitEmployees.BL;
using ElbitEmployees.Common;
using ElbitEmployees.DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;

namespace ElbitEmployees.Controllers
{
    [Produces("application/json")]
    [Route("api/Employee")]
    public class EmployeeController : Controller
    {

        [HttpGet("[action]")]
        public IEnumerable<Employee> GetEmployees()
        {
            List<Employee> resEmp = new List<Employee>();

            try
            {
                resEmp= EmployeeBL.GetEmployees();
            }
            catch(Exception ex)
            {
                //
            }

            return resEmp;
        }

        [HttpGet("[action]/{sNewEmp}")]
        public IEnumerable<Employee> SetEmployee(string sNewEmp)
        {
            List<Employee> resEmp = new List<Employee>();

            Employee NewEmp = JsonConvert.DeserializeObject<Employee>(sNewEmp);

            resEmp = EmployeeBL.setNewEmployee(NewEmp);

            return resEmp;
        }

        [HttpGet("[action]/{sEmp}")]
        public IEnumerable<Employee> deleteEmployee(string sEmp)
        {
            List<Employee> resEmp = new List<Employee>();

            Employee NewEmp = JsonConvert.DeserializeObject<Employee>(sEmp);

            resEmp=EmployeeBL.deleteEmployee(NewEmp);

            return resEmp;
        }

    }
}
