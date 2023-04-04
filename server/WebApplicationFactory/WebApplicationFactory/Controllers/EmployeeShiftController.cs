using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApplicationFactory.Models;     //חובה


namespace WebApplicationFactory.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")] //חובה

    public class EmployeeShiftController : ApiController
    {
        private static EmployeeShiftBL employeeShiftBL = new EmployeeShiftBL();

        // GET: api/EmployeeShift
        public IEnumerable<EmployeeShift> Get()
        {
            return employeeShiftBL.GetAllEmployeeShift();
        }

        // GET: api/EmployeeShift/5
        public EmployeeShift Get(int id)
        {
            return employeeShiftBL.GetGetAllEmployeeShiftId(id);
        }

        // POST: api/EmployeeShift
        public int Post(EmployeeShift es)
        {
            return employeeShiftBL.AddEmployeeShift(es);
        }

        // PUT: api/EmployeeShift/5
        public string Put(int id, EmployeeShift es)
        {
            employeeShiftBL.UpdateEmployeeShift(id, es);
            return "Updated";
        }

        // DELETE: api/EmployeeShift/5
        public string Delete(int id)
        {
            employeeShiftBL.DeleteEmployeeShift(id);
            return "Delited";

        }
    }
}
