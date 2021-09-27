using Xunit;
using System.Linq;
using System.Collections.Generic;

namespace BDSA2021.Assignment03.Tests
{
    public class WizardTests
    {
        [Fact]
        public void Wizards_contains_13_wizards()
        {
            var wizards = Wizard.Wizards.Value;

            Assert.Equal(14, wizards.Count);
        }

        [Theory]
        [InlineData("Darth Vader", "Star Wars", 1977, "George Lucas")]
        [InlineData("Sauron", "The Fellowship of the Ring", 1954, "J.R.R. Tolkien")]
        public void Spot_check_wizards(string name, string medium, int year, string creator)
        {
            var wizards = Wizard.Wizards.Value;

            Assert.Contains(wizards, w =>
                w.Name == name &&
                w.Medium == medium &&
                w.Year == year &&
                w.Creator == creator
            );
        }

        [Fact]
        public void getWizardsFromAuthor_Given_Rowling_Returns_HarryPotter_Voldemort_Dobby_HermioneGranger_RonWeasley_GinnyWeasley_FredWeasley_GeorgeWeasley()
        {
            var wizards = Wizard.Wizards.Value;

            string[] output = Queries.getWizardsFromAuthor("Rowling",wizards).ToArray();

            Assert.Equal(output,new string[]{"Harry Potter", "Voldemort", "Dobby", "Hermione Granger", "Ron Weasley","Ginny Weasley","Fred Weasley","George Weasley"});
        
        }
        [Fact]
        public void Extentionmethods_Given_Rowling_Returns_HarryPotter_Voldemort_Dobby_HermioneGranger_RonWeasley_GinnyWeasley_FredWeasley_GeorgeWeasley()
        {
            var w = Wizard.Wizards.Value;
            var output = w.Where(w=>w.Creator.Contains("Rowling")).Select(w=>w.Name);
            Assert.Equal(output,new string[]{"Harry Potter", "Voldemort", "Dobby", "Hermione Granger", "Ron Weasley","Ginny Weasley","Fred Weasley","George Weasley"});
        }


        [Fact]
        public void getYearOfFirstSithLord_given_al_wizards_returns_1900()
        {
            var wizards = Wizard.Wizards.Value;
            int output = Queries.getYearOfFirstSithLord(wizards);

            Assert.Equal(output, 1900);
        }

        [Fact]
        public void TestName()
        {
            var wizards = Wizard.Wizards.Value;
            var output = Queries.getHarryPotterWizards(wizards);
            
            var expected = new List<(string, int)>
            {
                ("Harry Potter", 1997),
                ("Voldemort", 1997),
                ("Dobby", 1997),
                ("Hermione Granger", 1997),
                ("Ron Weasley", 1997),
                ("Ginny Weasley", 1997),
                ("Fred Weasley", 1997),
                ("George Weasley", 1997)
            };

            Assert.Equal(output, expected);
        }

        [Fact]
        public void TestName1()
        {
            var wizards = Wizard.Wizards.Value;
            var output = Queries.getWizardNames(wizards);

            Assert.Equal(output, new string[]{"Merlin","Sauron","Gandalf","Voldemort","Ron Weasley","Hermione Granger","Harry Potter","Ginny Weasley","George Weasley","Fred Weasley","Dobby","Melly Sandra","Darth Vader","Darth Maul"}); 
        }


    }
}

