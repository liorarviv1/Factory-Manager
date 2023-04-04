using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationFactory.Models
{
    public class EmpWhithShiftBL
    {
        private FactoryDBEntities db = new FactoryDBEntities();

        public List<EmpWhithShift> GetAllEmpData()
        {
            List<EmpWhithShift> empshift = new List<EmpWhithShift>();
            foreach(EmployeeShift item in db.EmployeeShift)
            {
                EmpWhithShift newEmpSh = new EmpWhithShift();
                newEmpSh.ID = item.ID;
                newEmpSh.EmployeeID = item.EmployeeID;
                newEmpSh.ShiftID = item.ShiftID;

                newEmpSh.EmployeeInfo = new List<Employee>();

                var epsh = db.Employee.Where(x => x.ID == newEmpSh.EmployeeID);
                foreach(var i in epsh)
                {
                    newEmpSh.EmployeeInfo.Add(i);
                }
                newEmpSh.ShiftInfo = new List<Shift>();
                var eshift = db.Shift.Where(x => x.ID == item.ShiftID);
                foreach(var s in eshift)
                {
                    newEmpSh.ShiftInfo.Add(s);
                }
                empshift.Add(newEmpSh);
            }
            return empshift;
        }
        public EmpWhithShift GetEmpIDWhithShift(int id)
        {
            EmpWhithShift newEmpSh = new EmpWhithShift();
            var emp = db.EmployeeShift.Where(x => x.ID == id).First();

            newEmpSh.ID = emp.ID;
            newEmpSh.EmployeeID = emp.EmployeeID;
            newEmpSh.ShiftID = emp.ShiftID;

            var epsh = db.Employee.Where(x => x.ID == newEmpSh.EmployeeID);
            newEmpSh.EmployeeInfo = new List<Employee>();

            foreach (var i in epsh)
            {
                newEmpSh.EmployeeInfo.Add(i);
            }
            newEmpSh.ShiftInfo = new List<Shift>();

            var eshift = db.Shift.Where(x => x.ID == emp.ShiftID);

            foreach(var s in eshift)
            {
                newEmpSh.ShiftInfo.Add(s);
            }
            return newEmpSh;
        }
        public void AddEmployee(Employee emp)
        {
            db.Employee.Add(emp);
            db.SaveChanges();
        }

        public void UpdateEmployee(int id, Employee emp)
        {
            Employee e = db.Employee.Where(x => x.ID == id).First();
            e.FirstName = emp.FirstName;
            e.LastName = emp.LastName;
            e.StartWorkYear = emp.StartWorkYear;
            e.DepartmentID = emp.DepartmentID;
            db.SaveChanges();
        }
        public void DeletEmp(int id)
        {
            Employee e = db.Employee.Where(x => x.ID == id).First();
            db.Employee.Remove(e);
            EmpWhithShift newempsh = new EmpWhithShift();
            var emp = db.EmployeeShift.Where(x => x.EmployeeID == id).First();
            db.EmployeeShift.Remove(emp);
            db.SaveChanges();
        }
    }
}