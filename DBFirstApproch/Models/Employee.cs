using System;
using System.Collections.Generic;

namespace DBFirstApproch.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string? EmployeeName { get; set; }

    public string? Desigation { get; set; }

    public int? Salary { get; set; }
}
