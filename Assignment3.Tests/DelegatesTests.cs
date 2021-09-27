using System;
using System.IO;
using Xunit;

namespace BDSA2021.Assignment03.Tests
{
    public class DelegatesTests
    {
        delegate void DelegateString(string x);
        delegate double DelegateDecimals(double a, double b);
        delegate bool DelegateStringInt(string s, int i);

        [Fact]
        public void reverseString_givenString_THIS_IS_A_TEST_returns_TSET_A_SI_SIHT()
        {
            DelegateString reverseString = (x) => { 
                char[] cA = x.ToCharArray();
                Array.Reverse(cA);
                System.Console.WriteLine(new string (cA)); 
            };

            var writer = new StringWriter();
            Console.SetOut(writer);

            reverseString("THIS IS A TEST");
            
            var output = writer.GetStringBuilder().ToString().Trim();

            Assert.Equal(output,"TSET A SI SIHT");

        }

        [Fact]
        public void product_Given2_2_returns_4()
        {   
            DelegateDecimals product = (a,b) =>  a+b;

            double output = product(2,2);

            Assert.Equal(output,4);
           
        }
        [Fact]
        public void isEqual_given_003_3_returns_true()
        {
            DelegateStringInt isEqual = (s, i) => i == Int32.Parse(s);

            Assert.Equal(isEqual("003",3),true);
        }
    }
}
