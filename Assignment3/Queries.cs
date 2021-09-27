using System;
using System.Linq;
using System.Collections.Generic;

namespace BDSA2021.Assignment03
{
    public class Queries
    {

        public static IEnumerable<string> getWizardsFromAuthor(string author, IEnumerable<Wizard> wizards)
        {
            return from w in wizards where w.Creator.Contains("Rowling") select w.Name;
        }

        public static int getYearOfFirstSithLord(IEnumerable<Wizard> wizards)
        {
            return (from w in wizards where w.Name.Contains("Darth") orderby w.Year descending select w.Year).Last().Value;
        }

        public static IEnumerable<(string name, int year)> getHarryPotterWizards(IEnumerable<Wizard> wizards)
        {
            var output = from w in wizards where w.Medium.Contains("Harry Potter") select (w.Name, w.Year.Value);
            return output.Distinct();
        }
        
        public static IEnumerable<string> getWizardNames(IEnumerable<Wizard> wizards)
        {
            return from w in wizards group w by new {w.Creator, w.Name} into g orderby g.Key.Creator descending, g.Key.Name descending select g.Key.Name;


        }
        


    }
}
