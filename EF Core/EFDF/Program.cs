﻿using Microsoft.EntityFrameworkCore.Design.Internal;
using EFDF;

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
        }
    }
}