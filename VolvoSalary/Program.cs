namespace VolvoSalary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operator Oliver = new Operator ("Oliver Brage", "Operator","940815-9111", 10,0,true,true);
            Operator Benjamin = new Operator("Benjamin Kjellgren", "Operator", "920805-1121", 0, 0, false, true);
            Manager Vincent = new Manager("Vincent Kaveh", "Manager", "900608-2030", 3, true);
            Operator Alexander = new Operator ("Alexander Brasjö","Operator","910528-3421",5,20,false,true);
            Vincent.AddEmployee(Oliver);
            Manager Ali = new Manager("ali", "Manager", "900303-4449", 7, false);
            Ali.AddEmployee (Benjamin); 
            Ali.AddEmployee(Alexander);



           
            List<string> technologies = new List<string>
            { "C#","net", "sql","Python"};

            Developer Angela = new Developer ("Angela", "Developer", "19700202-2020", 2, Developer.DeveloperRole.Junior, technologies);
            Angela.FinishedProject();
            Angela.FinishedProject ();

            Developer Robin = new Developer("Robin Kamo", "Developer", "910604-1339", 0, Developer.DeveloperRole.Senior,technologies );
            Robin.FinishedProject ();


            Manager Robert = new Manager("Robert", "Manager", "19800909-2020", 17, false);
            Robert.AddEmployee(Angela);


            Console.WriteLine( "-------salary breakdown-------");
            Console.WriteLine( );
            Console.WriteLine( );
            Console.WriteLine( $"Name:{Oliver.Name}");
            Console.WriteLine($"position:{Oliver.Position}");
            Console.WriteLine($"salary:{Oliver.CalculateSalary ()}");
            Console.WriteLine( "-------------------");

            Console.WriteLine("-------salary breakdown-------");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Name:{Benjamin .Name}");
            Console.WriteLine($"position:{Benjamin .Position}");
            Console.WriteLine($"salary:{Benjamin .CalculateSalary()}");
            Console.WriteLine("-------------------");
            Console.WriteLine("-------salary breakdown-------");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Name:{Alexander .Name}");
            Console.WriteLine($"position:{Alexander .Position}");
            Console.WriteLine($"salary:{Alexander .CalculateSalary()}");
            Console.WriteLine("-------------------");
            Console.WriteLine("-------salary breakdown-------");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Name:{Robin.Name}");
            Console.WriteLine($"position:{Robin.Position}");
            Console.WriteLine($"salary:{Robin.CalculateSalary()}");
            Console.WriteLine("-------------------");

            Console.WriteLine("-------salary breakdown-------");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Name:{Robert.Name}");
            Console.WriteLine($"position:{Robert.Position}");
            Console.WriteLine($"salary:{Robert.CalculateSalary()}");
            Console.WriteLine("-------------------");



        }
    }
}