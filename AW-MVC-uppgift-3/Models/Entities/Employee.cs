using System;
using System.Collections.Generic;

namespace AW_MVC_uppgift_3.Models.Entities;

public partial class Employee
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Email { get; set; }
}
