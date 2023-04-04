using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationFactory.Models
{
    public class EmpWhithShift
    {
        public int ID { get; set; }
        public int EmployeeID { get; set; }
        public int ShiftID { get; set; }

        public List<Employee> EmployeeInfo { get; set;}
        public List<Shift> ShiftInfo { get; set;}
    }
}