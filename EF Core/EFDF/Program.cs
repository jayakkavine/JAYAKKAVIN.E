using Microsoft.EntityFrameworkCore.Design.Internal;
using EFDF;
using EFCF;

namespace EFDF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CRUD crud = new CRUD();
            //crud.AddNewDept();
            //crud.UpdateDept();
            crud.DeleteDept();

            CRUDEmployee crudeployee = new CRUDEmployee();
            crudeployee.AddNewDept();


        }
    }
}