using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace VolvoSalary
{
    internal static class SalaryHelper
    {
        private static int BASE_SALARY = 20000;
        private static int YEARLY_INCREMENT = 400;
        private static int NIGHT_SHIFT_BOUNUS = 5000;
        private static int TRUCK_DRIVER_BOUNUS =3000;
        private static int HOURLY_RATE = 180;

       public static int BaseSalary(int yearsEmployed)
        {
            return BASE_SALARY + (YEARLY_INCREMENT * yearsEmployed);

        }
        public static int NightShiftBounus(bool nightShift)
        {
            if (nightShift)
            {
                return NIGHT_SHIFT_BOUNUS;
            } else
            {
                return 0;
            }
        }

        public static int TruckDriverBounus(bool drivesTruck)
        {
            if (drivesTruck)
            {
                return TRUCK_DRIVER_BOUNUS;

            }
            else
            {
                return 0;
            }
            
        }
            public static int EarningsFromHours(int hoursWorked)

            {
                return HOURLY_RATE * hoursWorked;
            }


    }
}
