using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolvoSalary
{
    internal class Developer : Employee
    {

        public enum DeveloperRole
        {
            Junior,
            Medior,
            Senior,
        }

        //Fields for developer
        private List<string> _techStack;
        private DeveloperRole _role;
        private int _completedPproject;

        public Developer(string name,string position,  string socialsecurity, int yearsEmployed, DeveloperRole role, List <string > technologies)
        {
            Name = name;    
            Position = position;
            SocialSecurity = socialsecurity;
            YearsEmployed = yearsEmployed;
            _role = role;
            _techStack= technologies;
            _completedPproject = 0;

        }
        public List<string> TechStack
        {
            get { return _techStack; }
            set { _techStack = value; }
        }
        public DeveloperRole Role
        {
            get { return _role; }
            set { _role = value; }
        }

        public int CompletedPproject
        {
            get { return _completedPproject; }
            set { _completedPproject = value; }
        }
        public void FinishedProject()
        {
            _completedPproject++;

        }








        public override int CalculateSalary()
        {
            int baseSalary = 0;
            int bounusPerProject = 1000;
            
            switch (_role)
            {
                case DeveloperRole.Junior:
                    baseSalary = 32000;
                    break;
                case DeveloperRole.Medior:
                    baseSalary = 40000;
                    break;
                case DeveloperRole.Senior:
                    baseSalary = 55000;
                        break;

            }


            int toltal = baseSalary + (_completedPproject * bounusPerProject);
            return toltal;





            return 0;
        }
    }
}
