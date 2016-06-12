using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    class Searching
    {

        public static void SearchPD(string sNameSearch)
        {     
            //------------------------------------------- Searching for name -----------------------------------------
            foreach (var per in Program.ListOfPatients)
	        {
                if (per.sFirstName.ToUpper() == sNameSearch.ToUpper())
                {
                    per.DescriptionOfPerson();
                }
	        }
            foreach (var per in Program.ListOfDoctor)
	        {
                if (per.sFirstName.ToUpper() == sNameSearch.ToUpper())
                {
                    per.DescriptionOfPerson();
                }
	        }
            Console.WriteLine("Press any key to back");
        }
            // -------------------------------------------------------------------------------------------------------
        public static void SearchPD(string sNameSearch, string sSurnameSearch)
        {
            foreach (var per in Program.ListOfPatients)
	        {
                if (per.sFirstName.ToUpper() == sNameSearch.ToUpper())
                {
                    if (per.sLastName.ToUpper() == sSurnameSearch.ToUpper())
                        per.DescriptionOfPerson();
                }
	        }
            foreach (var per in Program.ListOfDoctor)
            {
                if (per.sFirstName.ToUpper() == sNameSearch.ToUpper())
                {
                    if (per.sLastName == sSurnameSearch)
                        per.DescriptionOfPerson();
                }
            }
        }
        
        public static void SearchSplit ()
        {
            Console.WriteLine("Search person : ");
            string sText = Console.ReadLine();
            string[] stText = sText.Split(new char[] { ' ' });
            if (stText.Count() == 1)
            {
                SearchPD(stText[0].TrimEnd(new char[] { ' ' }));
            }
            int iter = 1;
            string sNameSearch = "";
            string sSurnameSearch = "";
            foreach (string Ing in stText)
            {
                if (iter == 1)
                {
                    sNameSearch = Ing.TrimEnd(new char[] {' '});
                    //Console.WriteLine(sNameSearch);
                    iter++;
                }
                if (iter == 2)
                {
                    sSurnameSearch = Ing.TrimEnd(new char[] { ' ' });
                    //Console.WriteLine(sSurnameSearch);
                }
            }

            SearchPD(sNameSearch, sSurnameSearch);
            Console.ReadKey();
            Menu.Choice();
        }
    }
}
