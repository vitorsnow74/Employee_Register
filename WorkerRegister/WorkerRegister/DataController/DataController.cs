using System;
using System.Collections.Generic;
using WorkerRegister.Entities;
using WorkerRegister.Entities.Enum;
using WorkerRegister.Forms;

namespace WorkerRegister
{
    public class DataController
    {
        public bool Created = false;
        public string Name { get; set; }
        public string Level { get; set; }
        public double BaseSalary { get; set; }
        public string Department { get; set; }

        public void CreateDepartment(string dept) 
        {
            Department department = new Department(dept);
            Department = dept;
        }        

        public void CreateLevel(string level) 
        {
            //WorkerLevel workerLevel = (WorkerLevel)Enum.Parse(typeof(WorkerLevel), level);
            Level = level;
        }
    }
}
