using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationFactory.Models
{
    public class DepartmentWithEmployee
    {
        //Department
        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<int> EmployeeAmount { get; set; }
        public Nullable<int> ManagerID { get; set; }

        //Employee
        public List<Employee> EmployeesDep { get; set; }


        //public int IDEmp { get; set; }
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        //public Nullable<int> StartWorkYear { get; set; }
        //public Nullable<int> DepartmentID { get; set; }
    }
}