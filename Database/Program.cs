using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    class Program
    {
        public static List<Doctor> ListOfDoctor = new List<Doctor>();
        public static List<Patient> ListOfPatients = new List<Patient>();
        static void Main(string[] args)
        {
            // ------------------- DATABASE OF DOCTORS ---------------------------------
            //--------------------------------------------------------------------------
            Doctor Psycholog = new Doctor();
            Psycholog.sFirstName = "Ania";
            Psycholog.sLastName = "Gumkowska";
            Psycholog.iAge = 45;
            Psycholog.sPosition = "psycholog";
            Psycholog.sUnit = "Oddzial psychologii";
            Psycholog.sPersonIdentifier = "8937485937";
            ListOfDoctor.Add(Psycholog);
            //--------------------------------------------------------------------------
            Doctor Psycholog2 = new Doctor();
            Psycholog2.sFirstName = "Ania";
            Psycholog2.sLastName = "Pitonka";
            Psycholog2.iAge = 42;
            Psycholog2.sPosition = "psycholog";
            Psycholog2.sUnit = "Oddzial psychologii";
            Psycholog2.sPersonIdentifier = "463875856957";
            ListOfDoctor.Add(Psycholog2);
            //--------------------------------------------------------------------------
            Doctor Neurolog = new Doctor();
            Neurolog.sFirstName = "Jadwiga";
            Neurolog.sLastName = "Kowalczyk";
            Neurolog.iAge = 64;
            Neurolog.sPosition = "neurolog";
            Neurolog.sUnit = "Oddzial neurologii";
            Neurolog.sPersonIdentifier = "98374598434";
            ListOfDoctor.Add(Neurolog);
            //--------------------------------------------------------------------------
            Doctor LekarzRodzinny = new Doctor();
            LekarzRodzinny.sFirstName = "Hieronim";
            LekarzRodzinny.sLastName = "Musialek";
            LekarzRodzinny.iAge = 59;
            LekarzRodzinny.sPosition = "lekarz rodzinny";
            LekarzRodzinny.sUnit = "Oddzial lekarzy rodzinnych";
            LekarzRodzinny.sPersonIdentifier = "39847893434";
            ListOfDoctor.Add(LekarzRodzinny);
            //--------------------------------------------------------------------------
            //--------------------------- DATABASE OF PATIENTS -------------------------
            Patient pacjent1 = new Patient();
            pacjent1.sFirstName = "Lena";
            pacjent1.sLastName = "Kminska";
            pacjent1.iAge = 14;
            pacjent1.sDisorder = "Dysmozgia";
            pacjent1.iStatusOfDisorder = 4;
            pacjent1.sPersonIdentifier = "84376734";
            ListOfPatients.Add(pacjent1);
            //--------------------------------------------------------------------------
            Patient pacjent2 = new Patient();
            pacjent2.sFirstName = "Milena";
            pacjent2.sLastName = "Rogowska";
            pacjent2.iAge = 25;
            pacjent2.sDisorder = "Nadczynnosc tarczycy";
            pacjent2.iStatusOfDisorder = 2;
            pacjent2.sPersonIdentifier = "832756938456";
            ListOfPatients.Add(pacjent2);
            //Psycholog.DescriptionOfPerson();
            

            Menu.Choice();
            

            Console.ReadKey();

        }
    }
}
