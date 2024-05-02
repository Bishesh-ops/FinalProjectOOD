using System;
using System.Collections.Generic;

namespace FinalProject
{
    internal class EmployeeRepository
    {
        private List<Employee> employees;

        public EmployeeRepository()
        {
            employees = new List<Employee>
            {
                new Employee("Ismail Raji", "IT", "IsmailRaji@example.com", 15, 20),
                new Employee("Bishesh Shrestha", "HR", "bisheshshr@example.com", 30, 40),
                new Employee("Tesfamariam Mekonen", "IT", "tesfamariamwork@example.com", 18, 22),
                new Employee("Vashrith Vinodh", "IT", "vVinodh@example.com", 21, 45),
                new Employee("Leul Hailemichael", "MKT", "leulHaile@example.com", 11, 70)
            };
        }

        public List<Employee> GetAllEmployees()
        {
            return employees;
        }

        public Employee GetEmployeeById(Guid id) 
        {
            return employees.Find(e => e.Id == id);
        }

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public void RemoveEmployee(Guid id)
        {
            employees.RemoveAll(e => e.Id == id);
        }
    }
}
