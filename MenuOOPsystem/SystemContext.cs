using MenuOOPsystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MenuOOPsystem
{
    public class SystemContext
    {
        public List<Employee> employees {  get; set; }
        public List<Department> departments { get; set; }

    }
}
