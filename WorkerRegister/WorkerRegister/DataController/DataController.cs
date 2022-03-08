using System;
using System.Collections.Generic;
using WorkerRegister.Entities;
using WorkerRegister.Entities.Enum;
using WorkerRegister.Forms;

namespace WorkerRegister
{
    public class DataController
    {
        private string Name;
        private WorkerLevel Level;
        private double BaseSalary;
        public Department Department;
        private List<HourContract> Contracts = new List<HourContract> ();

        public void GetWorkerName(string name) 
        {
            this.Name = name;
        }

        public void GetWorkerLevel(WorkerLevel level)
        {
            this.Level = level;
        }

        public void GetWorkerBaseSalary(double baseSalary)
        {
            this.BaseSalary = baseSalary;
        }

        public void GetWorkerDepartment(string department)
        {
            this.Department = new Department(department);
        }
        
        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public void CreateWorker() 
        {
            Worker worker = new Worker(Name, Level, BaseSalary, Department);
        }

        public double Income(int month, int year, double baseSalary)
        {
            double income = baseSalary;
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    income += contract.TotalValue();
                }
            }
            return income;
        }
    }

    
}
