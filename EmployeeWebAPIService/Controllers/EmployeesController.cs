using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeeWebAPIService.Controllers
{
    public class EmployeesController : ApiController
    {
        public IEnumerable<Employee> Get()
        {
            using(DbEmployeeEntities entities=new DbEmployeeEntities())
            {
                return entities.Employees.ToList();
            }

        }
        public Employee Get(string code)
        {
            using (DbEmployeeEntities entities = new DbEmployeeEntities())
            {
                return entities.Employees.FirstOrDefault(e=>e.code==code);
            }

        }
    }
}
