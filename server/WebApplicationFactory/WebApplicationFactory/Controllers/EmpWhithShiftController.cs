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

    public class EmpWhithShiftController : ApiController
    {
        private EmpWhithShiftBL empWhithShiftBL= new EmpWhithShiftBL();
        // GET: api/EmpWhithShift
        public IEnumerable<EmpWhithShift> Get()
        {
            return empWhithShiftBL.GetAllEmpData();
        }

        // GET: api/EmpWhithShift/5
        public EmpWhithShift Get(int id)
        {
            return empWhithShiftBL.GetEmpIDWhithShift(id);
           
        }

        // POST: api/EmpWhithShift
        public string Post(Employee emp)
        {
            empWhithShiftBL.AddEmployee(emp);
            return "employee adding" + emp.ID;
        }

        // PUT: api/EmpWhithShift/5
        public string Put(int id, Employee emp)
        {
            empWhithShiftBL.UpdateEmployee(id, emp);
            return "Employee updated";
        }

        // DELETE: api/EmpWhithShift/5
        public string Delete(int id)
        {
            empWhithShiftBL.DeletEmp(id);
            return "employee deleted";
        }
    }
}
