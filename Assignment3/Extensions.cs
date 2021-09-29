using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BDSA2021.Assignment03
{
    public static class Extensions
    {                                                                    
        public static bool IsSecure(this Uri uri) => uri.Scheme == "https";

        public static int WordCount(this string s) => (Regex.Split(s,@"\P{L}+")).Count();

    }
}
