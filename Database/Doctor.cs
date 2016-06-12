using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    class Doctor : Person,Functions
    {
        public string sPosition { get; set; }
        public string sUnit { get; set; }
        private int bStatus = (int)eWho.Doctor;
       // public Date Start;
       // public Date End;




        public void DescriptionOfPerson()
        {
            if (bStatus == 1)
                Console.WriteLine(" This is a doctor"
                    + Environment.NewLine + "_______________________________________");

            string TempName;
            string TempFurtherInformation;
            TempName = " Doctor: " + this.sLastName + " " + this.sFirstName;
            TempFurtherInformation = "Position : " + this.sPosition  + Environment.NewLine + "Unit: " + this.sUnit;

            Console.WriteLine(TempName);
            Console.WriteLine(TempFurtherInformation);

        }
        public static void Add()
        {
            Doctor NewDoctor = new Doctor();
            Console.WriteLine("ADD DOCTOR" + Environment.NewLine);

            Console.WriteLine("First Name: ");
            NewDoctor.sFirstName = Console.ReadLine();

            Console.WriteLine("Last Name: ");
            NewDoctor.sLastName = Console.ReadLine();

            Console.WriteLine("Age: ");
            NewDoctor.iAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Person Identifier: ");
            NewDoctor.sPersonIdentifier = Console.ReadLine();

            Console.WriteLine("Disorder: ");
            NewDoctor.sPosition = Console.ReadLine();

            Console.WriteLine("Status of disorder (1-10) : ");
            NewDoctor.sUnit = Console.ReadLine();

        }
        public void Delete()
        {
            Program.ListOfDoctor.Remove(this);
        }




       
    }

}
