using System;
using System.Collections.Generic;
using WorkerRegister.Entities;
using WorkerRegister.Entities.Enum;

namespace WorkerRegister.Entities
{
    public class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker()
        {
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            this.Name = name;
            this.Level = level;
            this.BaseSalary = baseSalary;
            this.Department = department;
        }
    }
}
