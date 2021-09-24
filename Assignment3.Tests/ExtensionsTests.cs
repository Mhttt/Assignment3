using System;
using System.Collections.Generic;
using Xunit;

namespace BDSA2021.Assignment03.Tests
{
    public class ExtensionsTests
    {
        [Fact]
        public void Flatten_Given2DIntArray_ReturnsIntArray()
        {
            var subInput1 = new int[]{1,2,3,4,5,6};
            var subInput2 = new int[]{6,5,4,3,2,1};
            var input = new int[][]{subInput1,subInput2};
            
            var output = input.Flatten();
            Assert.Equal(new int[]{1,2,3,4,5,6,6,5,4,3,2,1},output);

        }

        [Fact]
        public void Filter_given3_4_5_6_2_8_6_49_returns49()
        {
            var input = new int[]{3,4,5,6,2,8,6,49};
            var output = input.Filter();
            Assert.Equal(new int[]{49}, output);
        }

        [Fact]
        public void Filter_given_200_33_3211_400_800_and_predicateLeapYea_returns400_800()
        {

            var input = new int[]{200, 33, 3211, 400, 800};

            var output = input.LeapYear();
            
            Assert.Equal(new int[]{400,800}, output); 
        }

        
        [Theory]
        [InlineData("https://github.com/ondfisk/BDSA2021",true)]
        [InlineData("http://github.com/ondfisk/BDSA2021",false)]
        [InlineData("https://youtube.com",true)]

        public void IsSecure_GivenThreeUris_returns_true_false_true(string u, bool expected)
        {
            Uri i = new Uri(u);
            Assert.Equal(i.IsSecure(),expected);
        }

        [Theory]
        [InlineData("iufhshf fsiufhs iusgf",3)]
        [InlineData("pokf, sfijdf...sf hhfsf",4)]
        [InlineData("ojsfijf sf  dfs s s s s,,s , , s",9)]
        public void TestName(string s, int i)
        {
            Assert.Equal(s.WordCount(),i);
        }

        
    }
}
