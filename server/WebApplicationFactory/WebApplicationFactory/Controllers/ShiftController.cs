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
    public class ShiftController : ApiController
    {
        private ShiftBL shiftBL = new ShiftBL();
        // GET: api/Shift
        public IEnumerable<Shift> Get()
        {
            return shiftBL.GetAllDataShifts();
        }

        // GET: api/Shift/5
        public Shift Get(int id)
        {
            return shiftBL.GetDataShiftsId(id);
        }

        // POST: api/Shift
        public int Post(Shift shift)
        {
            shiftBL.AddShift(shift);
            return shift.ID;

        }

        // PUT: api/Shift/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Shift/5
        public void Delete(int id)
        {
            //shiftBL.DeleteShift(id);
            //return "Shift deleted";
        }
    }
}
