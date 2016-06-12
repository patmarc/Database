using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    class Patient : Person, Functions
    {
        public string sDisorder { get; set; }
        public int iStatusOfDisorder { get; set; }
        private int bStatus = (int)eWho.Patient;
        

        

        public void DescriptionOfPerson()
        {
            if (bStatus == 0)
                Console.WriteLine(" This is a patient"
                    + Environment.NewLine + "_______________________________________");

            string TempName;
            string TempFurtherInformation;
            TempName = " Patient: " + this.sLastName + " " + this.sFirstName;
            TempFurtherInformation = "Disorder : " + this.sDisorder + Environment.NewLine + "Status of disorder :" + this.iStatusOfDisorder;

            Console.WriteLine(TempName);
            Console.WriteLine(TempFurtherInformation);
        }
        public static void Add ()
        {
            Patient NewPatient = new Patient();
            Console.WriteLine("ADD PATIENT" + Environment.NewLine );

            Console.WriteLine("First Name: ");
            NewPatient.sFirstName = Console.ReadLine();

            Console.WriteLine("Last Name: ");
            NewPatient.sLastName = Console.ReadLine();

            Console.WriteLine("Age: ");
            NewPatient.iAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Person Identifier: ");
            NewPatient.sPersonIdentifier = Console.ReadLine();

            Console.WriteLine("Disorder: ");
            NewPatient.sDisorder = Console.ReadLine();

            Console.WriteLine("Status of disorder (1-10) : ");
            NewPatient.iStatusOfDisorder = Convert.ToInt32(Console.ReadLine());

            Program.ListOfPatients.Add(NewPatient);

        }

        public void Delete ()
        {
            Program.ListOfPatients.Remove(this);
        }

    }
}
