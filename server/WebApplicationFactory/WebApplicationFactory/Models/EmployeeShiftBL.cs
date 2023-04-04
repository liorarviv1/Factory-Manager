using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationFactory.Models
{
    public class EmployeeShiftBL
    {
        private FactoryDBEntities db = new FactoryDBEntities();
        public List<EmployeeShift> GetAllEmployeeShift()
        {
            return db.EmployeeShift.ToList();
        }
        public EmployeeShift GetGetAllEmployeeShiftId(int id)
        {
            return db.EmployeeShift.Where(x => x.ID == id).First();
        }
        public int AddEmployeeShift(EmployeeShift es)
        {
            db.EmployeeShift.Add(es);
            db.SaveChanges();
            return es.ID;
            

        }
        public void UpdateEmployeeShift(int id, EmployeeShift empS)
        {
            EmployeeShift es = db.EmployeeShift.Where(x => x.ID == id).First();
            es.EmployeeID = empS.EmployeeID;
            es.ShiftID = empS.ShiftID;
            db.SaveChanges();
        }
        public void DeleteEmployeeShift(int id)
        {
            EmployeeShift es = db.EmployeeShift.Where(x => x.ID == id).First();
            db.EmployeeShift.Remove(es);
            db.SaveChanges();

        }
    }
}
