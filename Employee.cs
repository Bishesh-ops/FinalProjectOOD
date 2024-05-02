using System;

namespace FinalProject
{
    internal class Employee
    {
        public Guid Id { get; private set; }

        public string Name { get; set; }
        public string Department { get; set; }
        public string ContactInfo { get; set; }
        public decimal HourlyWage { get; set; }
        public int HoursWorked { get; set; }

        public Employee()
        {
            Id = Guid.NewGuid();
            Name = "";
            Department = "";
            ContactInfo = "";
        }

        public Employee(string name, string department, string contactInfo)
        {
            Id = Guid.NewGuid();
            Name = name;
            Department = department;
            ContactInfo = contactInfo;
        }
        public Employee(string name, string department, string contactInfo, decimal hourlyWage, int hoursWorked)
        {
            Id = Guid.NewGuid();
            Name = name;
            Department = department;
            ContactInfo = contactInfo;
            HourlyWage = hourlyWage;
            HoursWorked = hoursWorked;
        }
        public int GetHoursWorked()=> HoursWorked;
        public void SetHoursWorked(int hoursWorked) => HoursWorked = hoursWorked; 
        public decimal GetHourlyWage() => HourlyWage;
        public void SetHourlyWage(decimal hourlyWage) => HourlyWage = hourlyWage;

        public string GetName() => Name;

        public string GetDepartment() => Department;

        public string GetContactInfo() => ContactInfo;

        public void SetName(string name) => Name = name;

        public void SetDepartment(string department) => Department = department;

        public void SetContactInfo(string contactInfo) => ContactInfo = contactInfo;
    }
}
