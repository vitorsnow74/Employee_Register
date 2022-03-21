using System;
using System.Collections.Generic;
using Employee_Register.Entities;
using Employee_Register.Entities.Enum;

namespace Employee_Register.Entities
{
    public class Employee
    {
        public string Name { get; set; }
        public EmployeeLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Employee()
        {
        }

        public Employee(string name, EmployeeLevel level, double baseSalary, Department department)
        {
            this.Name = name;
            this.Level = level;
            this.BaseSalary = baseSalary;
            this.Department = department;
        }
    }
}