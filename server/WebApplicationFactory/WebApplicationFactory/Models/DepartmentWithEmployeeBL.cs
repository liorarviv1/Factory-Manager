using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace WebApplicationFactory.Models
{
    public class DepartmentWithEmployeeBL
    {
        private FactoryDBEntities db = new FactoryDBEntities();

        public List<DepartmentWithEmployee> GetAllDepartmentWhitEmployeeBL()
        {
            List<DepartmentWithEmployee> DEmp= new List<DepartmentWithEmployee>();

            foreach (Department dep in db.Department)
            {
                DepartmentWithEmployee newDE= new DepartmentWithEmployee();

                newDE.ID= dep.ID;
                newDE.Name= dep.Name;
                newDE.EmployeeAmount= dep.EmployeeAmount;
                newDE.ManagerID= dep.ManagerID;

                newDE.EmployeesDep = new List<Employee>();

                var empsD = db.Employee.Where(x => x.DepartmentID == newDE.ID);
                foreach (var emp in empsD)
                {
                    newDE.EmployeesDep.Add(emp);
                    
                }
                DEmp.Add(newDE);
            }
            db = new FactoryDBEntities();
            return DEmp;



        }
        public DepartmentWithEmployee GetDepartmentIDWhitEmployeeManager(int id)
        {
            DepartmentWithEmployee DEmp = new DepartmentWithEmployee();
            var department = db.Department.Where(x => x.ID == id).First();

            DEmp.ID = department.ID;
            DEmp.Name = department.Name;
            DEmp.EmployeeAmount = department.EmployeeAmount;
            DEmp.ManagerID = department.ManagerID;

            var employees= db.Employee.Where(x => x.DepartmentID == id);

            DEmp.EmployeesDep = new List<Employee>();

            foreach (var emp in employees)
            {
                DEmp.EmployeesDep.Add(emp);

            }
            return DEmp;

        }
        public int AddDepartmentWhitEmployeeManager(Department dep)
        {
            db.Department.Add(dep);
            db.SaveChanges();
            return dep.ID;
        }
        public void UpdataDepartment(Department dep, int id)
        {
            Department d = db.Department.Where(x => x.ID == id).First();
            d.Name= dep.Name;
            d.EmployeeAmount= dep.EmployeeAmount;
            d.ManagerID= dep.ManagerID;


            db.SaveChanges();
        }
        public void DeleteDepartment(int id)
        {
            Department d = db.Department.Where(x => x.ID == id).First();
            db.Department.Remove(d);

            db.SaveChanges();
        }


    }
}