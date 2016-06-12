using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    class Menu
    {
        public static void Choice()
        {
            Console.Clear();
            Console.WriteLine("DATABASE OF HOSPITAL" + Environment.NewLine + Environment.NewLine
                + "1.Patients" + Environment.NewLine
                + "2.Doctors" + Environment.NewLine
                + "3.Search" + Environment.NewLine
                + "4.The End");
            int choice;
            choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Console.Clear();
                MenuOfPatient();
            }
            if (choice == 2)
            {
                Console.Clear();
                MenuOfDoctor();
            }
            if (choice == 3)
            {
                Console.Clear();
                Searching.SearchSplit();
            }
            if (choice == 4)
            {
                Console.Clear();
                Console.WriteLine(Environment.NewLine
                + Environment.NewLine
                + "                    Bye Bye, press any key");
                Console.ReadKey();
                Environment.Exit(0);
            }


        }
        public static void MenuOfPatient()//(int info) 
        {
            Console.WriteLine("DATABASE OF PATIENTS" + Environment.NewLine + Environment.NewLine
                 + "1. Viewing and deleting" + Environment.NewLine
                 + "2. Add patient" + Environment.NewLine
                 + "3. Delete patient" + Environment.NewLine
                 + "4. The end");

            int info;
            info = Convert.ToInt32(Console.ReadLine());
            if (info == 1)
            {
                Console.Clear();
                foreach (var person in Program.ListOfPatients)
                {
                    person.DescriptionOfPerson();
                    Console.WriteLine(Environment.NewLine);
                    Console.WriteLine("Press u to delete patient or other key to see next");
                    string key = Console.ReadKey().Key.ToString();

                    if (key.ToUpper() == "U")
                    {
                            person.Delete();
                            Console.Clear();
                            Console.WriteLine("Usunieto pacjenta");
                            break;
                    }
                }
                Console.ReadKey();
                Console.Clear();
                MenuOfPatient();
            }
            if (info == 2)
            {
                Console.Clear();
                Patient.Add();
                Console.Clear();
                MenuOfPatient();
            }
            if (info == 3)
            {
                Console.Clear();
                Console.WriteLine("Patient was deleted");
                Console.Clear();
            }
            if (info == 4)
            {
                Console.Clear();
                Choice();
            }
            MenuOfPatient();
        }

        public static void MenuOfDoctor()//(int info) 
        {
            Console.WriteLine("DATABASE OF DOCTORS" + Environment.NewLine + Environment.NewLine
                 + "1. Viewing and deleting" + Environment.NewLine
                 + "2. Add doctor" + Environment.NewLine
                 + "3. Delete doctor" + Environment.NewLine
                 + "4. The end");

            int info;
            info = Convert.ToInt32(Console.ReadLine());
            if (info == 1)
            {
                Console.Clear();
                foreach (var person in Program.ListOfDoctor)
                {
                    person.DescriptionOfPerson();
                    Console.WriteLine(Environment.NewLine);

                }
                Console.ReadKey();
                Console.Clear();
                MenuOfDoctor();
            }
            if (info == 2)
            {
                Console.Clear();
                Doctor.Add();
                Console.Clear();
                MenuOfDoctor();
            }
            if (info == 3)
            {
                Console.Clear();
                Console.WriteLine("Usiniecie Doktora masz Patki do zrobienia");

                Console.Clear();
                MenuOfDoctor();
            }
            if (info == 4)
            {
                Console.Clear();
                Choice();
            }
        }


    }
}
