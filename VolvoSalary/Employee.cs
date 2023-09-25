using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolvoSalary
{
    internal abstract  class Employee
    {
        //Employee fields
        private string _name;
        private string _position;
        private string _SocialSecurity;
        private int _yearsEmployed;
        

        //Prpoperties for the fields above.
        public string Name
        {
            get { return _name; }
            set { _name = value; }

        }
        public string Position
        {
            get { return _position; }
            set { _position = value; }
        }
        public string SocialSecurity
        {
            get { return _SocialSecurity; }
            set { _SocialSecurity = value; }

        }
        public int YearsEmployed
        {
            get { return _yearsEmployed;}
            set { _yearsEmployed = value;}
        }

        public abstract int CalculateSalary();
        public void UpdateSocialSecurity(string newSSN)
        {
            SocialSecurity = newSSN;
        }



    }
   
}
