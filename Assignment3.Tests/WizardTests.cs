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
        public void Extention_Given_Rowling_Returns_HarryPotter_Voldemort_Dobby_HermioneGranger_RonWeasley_GinnyWeasley_FredWeasley_GeorgeWeasley()
        {
            var w = Wizard.Wizards.Value;
            var output = w.Where(w=>w.Creator.Contains("Rowling")).Select(w=>w.Name);
            Assert.Equal(output,new string[]{"Harry Potter", "Voldemort", "Dobby", "Hermione Granger", "Ron Weasley","Ginny Weasley","Fred Weasley","George Weasley"});
        }
        

        public void Extention_given_al_wizards_returns_1900()
        {
            var w = Wizard.Wizards.Value;
            int output = w.Where(w => w.Name.Contains("Darth")).OrderByDescending(w=>w.Year).Select(w=>w.Year).Last().Value;

            Assert.Equal(output, 1900);
        }


       
        [Fact]
        public void Extention_returns_allHarryPotterWizardsAsTuples()
        {
            
            var w = Wizard.Wizards.Value;
            var output = w.Where(w => w.Medium.Contains("Harry Potter")).Select(w => (w.Name,w.Year.Value)).Distinct();

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
        public void Extention_returns_AllWizardsNames_reverseOrder_groupedByCreator()
        {
            //from w in wizards group w by new {w.Creator, w.Name} into g orderby g.Key.Creator descending, g.Key.Name descending select g.Key.Name;
           
            var w = Wizard.Wizards.Value;
            var output = w.GroupBy(w=> new {w.Creator, w.Name}).OrderByDescending(w=>w.Key.Creator).ThenByDescending(w=>w.Key.Name).Select(w=>w.Key.Name);

            Assert.Equal(output, new string[]{"Merlin","Sauron","Gandalf","Voldemort","Ron Weasley","Hermione Granger","Harry Potter","Ginny Weasley","George Weasley","Fred Weasley","Dobby","Melisandre","Darth Vader","Darth Maul"});  
        }



    }
}

