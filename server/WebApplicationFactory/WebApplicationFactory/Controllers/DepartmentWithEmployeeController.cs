using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApplicationFactory.Models;


namespace WebApplicationFactory.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")] //חובה

    public class DepartmentWithEmployeeController : ApiController
    {
        private static DepartmentWithEmployeeBL departmentWithEmployeeBL = new DepartmentWithEmployeeBL();

        // GET: api/DepartmentWithEmployee
        public IEnumerable<DepartmentWithEmployee> Get()
        {
            return departmentWithEmployeeBL.GetAllDepartmentWhitEmployeeBL();
        }

        // GET: api/DepartmentWithEmployee/5
        public DepartmentWithEmployee Get(int id)
        {
            return departmentWithEmployeeBL.GetDepartmentIDWhitEmployeeManager(id);
        }

        // POST: api/DepartmentWithEmployee
        public string Post(Department dep)
        {
            int id =departmentWithEmployeeBL.AddDepartmentWhitEmployeeManager(dep);
            return "Created whit ID :" + dep.ID;
        }

        // PUT: api/DepartmentWithEmployee/5
        public string Put(int id, Department dep)
        {
            departmentWithEmployeeBL.UpdataDepartment(dep, id);
            return "Updated";
        }
        // DELETE: api/DepartmentWithEmployee/5
        public string Delete(int id)
        {
            departmentWithEmployeeBL.DeleteDepartment(id);
            return "Deleted";
        }
    }
}
