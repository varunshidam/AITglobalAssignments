using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCExample1.Models
{
    public class DeptBal
    {
        public List<Department> GetDeptList()
        {
            List<Department> dlist = new List<Department>();
            dlist.Add(new Department() {deptid=101,deptname="Marketing",location="Pune",country="INDIA" });
            dlist.Add(new Department() { deptid = 201, deptname = "HR", location = "Bangluru", country = "INDIA" });
            dlist.Add(new Department() { deptid = 301, deptname = "IT", location = "Kolkata", country = "INDIA" });
            dlist.Add(new Department() { deptid = 401, deptname = "Admin", location = "Surat", country = "INDIA" });
            return dlist;
        }
    }
}