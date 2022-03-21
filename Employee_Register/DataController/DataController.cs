using System;
using System.Collections.Generic;
using Employee_Register.Entities;
using Employee_Register.Entities.Enum;
using Employee_Register.Forms;

namespace Employee_Register
{
    public class DataController
    {
        private string Name;
        private EmployeeLevel Level;
        private double BaseSalary;
        public Department Department;
        private List<HourContract> Contracts = new List<HourContract>();

        public void GetEmployeeName(string name)
        {
            this.Name = name;
        }

        public void GetEmployeeLevel(EmployeeLevel level)
        {
            this.Level = level;
        }

        public void GetEmployeeBaseSalary(double baseSalary)
        {
            this.BaseSalary = baseSalary;
        }

        public void GetEmployeeDepartment(string department)
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

        public void CreateEmployee()
        {
            Employee employee = new Employee(Name, Level, BaseSalary, Department);
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