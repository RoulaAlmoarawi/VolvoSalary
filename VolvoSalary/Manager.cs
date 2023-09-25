using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace VolvoSalary
{
    internal class Manager : Employee

    {
        //Fields 
        private List<Employee> _employeesManaged;
        private bool _isNightShift;

        public Manager (string name, string position, string socialsecurity, int yearsEmployed, bool nightShift)
        {
            Name= name;
            Position= position;
            SocialSecurity = socialsecurity;
            YearsEmployed = yearsEmployed;
            _isNightShift = nightShift;
            _employeesManaged = new List<Employee>();
        }
        //Properties for fields.

        public List<Employee> EmployeesManaged
        {
            get { return _employeesManaged; }
            set { _employeesManaged = value; }
        }
        public bool IsNightShift
        {
            get { return _isNightShift; }
            set { _isNightShift = value; }
        }

        //Method for adding employee to a manager 
        public void AddEmployee(Employee employee)
        {
            _employeesManaged.Add(employee);
        }






        public override int CalculateSalary()
        {

            int employeeCountBounus = 1000;

            int baseSalary = SalaryHelper.BaseSalary(YearsEmployed);
            int nightShiftBounus = SalaryHelper.NightShiftBounus(IsNightShift);
            int personalCount = employeeCountBounus * _employeesManaged.Count();
            int totalsalary = baseSalary + nightShiftBounus + personalCount;
            return totalsalary;
        }
    }
}
