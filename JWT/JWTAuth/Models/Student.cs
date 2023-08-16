using System;
using System.Collections.Generic;

namespace JWTAuth.Models;

public partial class Student
{
    public int RollNo { get; set; }

    public string StudentName { get; set; }

    public string Address { get; set; }

    public long Phone { get; set; }
}
