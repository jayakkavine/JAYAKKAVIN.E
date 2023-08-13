
using EFDF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EFCF
{
    internal class CRUDEmployee
    {
        public void AddNewDept()
        {
            // using is keyword used to use the context to the entire code
            // context is used to perform some operation on db using empluyeedbcontext - that contain table

            using (var context = new EmployeeDbContext())
            {
                var emp = new Emp()
                {
                    EmpNo = 1,
                    EmpName = "JK"
            };

                context.Emps.Add(emp);
                context.SaveChanges();
            }
        }

        public void UpdateDept()
        {
            // using is keywird used to use the context to the entire code
            // context is used to perform some operation on db using empluyeedbcontext - that contain table

            var context = new EmployeeDbContext();

            var selemp = context.Emps.FirstOrDefault(d => d.EmpNo == 1);

            selemp.EmpName= "Jayakkavin";

            context.SaveChanges();

        }

        public void DeleteDept()
        {
            // using is keywird used to use the context to the entire code
            // context is used to perform some operation on db using empluyeedbcontext - that contain table

            var context = new EmployeeDbContext();

            var selemp = context.Emps.FirstOrDefault(d => d.EmpNo == 1);

            context.Emps.Remove(selemp);

            context.SaveChanges();

        }



    }
}
