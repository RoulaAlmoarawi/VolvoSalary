using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolvoSalary
{
    internal class Operator : Employee 
    {

        private int _hoursWorked;
        private bool _nightShift;
        private bool _drivesTruck;
        public Operator(string name, string position,string socialSecurity, int yearsEmployeed, int hoursWorked, bool nightShift,bool driversTruck)
        {
            Name= name;
            Position= position;
            SocialSecurity = socialSecurity;
            YearsEmployed= yearsEmployeed;
            _hoursWorked= hoursWorked;
            _nightShift= nightShift;
            _drivesTruck= driversTruck;
        }

        private int HoursWorked
        {
            get { return _hoursWorked; }
            set { _hoursWorked = value; }
        }
        private bool NightShift
        {
            get { return _nightShift; }
            set { _nightShift = value; }
        }
        private bool DrivesTruck
        {
            get { return _drivesTruck; }
            set { _drivesTruck = value; }
        }

        //Properties for the fields above.

        public override int CalculateSalary()
        {
            int basSalary = SalaryHelper.BaseSalary(YearsEmployed);//20 000
            int nightShiftBounus = SalaryHelper.NightShiftBounus(NightShift); //5 000
            int truckDriverBounus = SalaryHelper.TruckDriverBounus(DrivesTruck);//3 000
            int earnigFromHours = SalaryHelper.EarningsFromHours(HoursWorked);//180*x

            int totalSalary = basSalary + nightShiftBounus + truckDriverBounus + earnigFromHours;

            return totalSalary;
        }
        

    }
}
