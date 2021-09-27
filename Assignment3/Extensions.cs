using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BDSA2021.Assignment03
{
    public static class Extensions
    {
        public static IEnumerable<int> Flatten(this IEnumerable<IEnumerable<int>> xs) => xs.SelectMany(x=>x);
       
        public static IEnumerable<int> Filter(this IEnumerable<int> yx) => from y in yx where y >42&& y%7==0 select y;

        public static IEnumerable<int> LeapYear(this IEnumerable<int> yx) => from y in yx where DateTime.IsLeapYear(y) select y;
                                                                            
        public static bool IsSecure(this Uri uri) => uri.Scheme == "https";

        public static int WordCount(this string s) => (Regex.Split(s,@"\P{L}+")).Count();

        //---------------------------------------------------------------------------------------------------------

      /*   public static IEnumerable<string> getWizardsFromAuthor(this IEnumerable<Wizard> w, string author, )
        {
            return w.Where(w.Creator.Contains("Rowling")).Select(w.Name);
        }

        public static int getYearOfFirstSithLord(this IEnumerable<Wizard> w)
        {
            return w.Where(w => w.Name.Contains("Darth")).OrderByDescending(w=>w.Year).Last().Value;
            
        }

        public static IEnumerable<(string name, int year)> getHarryPotterWizards(this IEnumerable<Wizard> w)
        {
            return w.Where(w => w.Medium.Contains("Harry Potter")).Select(w => new Tuple<string, int>(w.Name,w.Year.Value)).Distinct();

        } */

    }
}
