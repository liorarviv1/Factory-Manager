using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationFactory.Models
{
    public class ShiftBL
    {
        private FactoryDBEntities db = new FactoryDBEntities();

        public List<Shift> GetAllDataShifts()
        {
            return db.Shift.ToList();
        }
        public Shift GetDataShiftsId(int id)
        {
            return db.Shift.Where(x => x.ID == id).First();
        }
        public int AddShift(Shift shift)
        {
            db.Shift.Add(shift);
            db.SaveChanges();
            return shift.ID;
        }
        //public void updateshift(int id, shift emp)
        //{
        //    employee e = db.employee.where(x => x.id == id).first();
        //    e.firstname = emp.firstname;
        //    e.lastname = emp.lastname;
        //    e.startworkyear = emp.startworkyear;
        //    e.departmentid = emp.departmentid;
        //    db.savechanges();
        //}

        //public void DeleteShift(int id)
        //{
        //    Shift s = db.Shift.Where(x => x.ID == id).First();
        //    db.Shift.Remove(s);
        //    db.SaveChanges();
        //}
    }
}