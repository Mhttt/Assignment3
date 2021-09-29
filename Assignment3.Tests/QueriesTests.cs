using System;
using Xunit;

using Xunit;
using System.Linq;
using System.Collections.Generic;

namespace BDSA2021.Assignment03.Tests
{
    public class QueriesTests
    {
        [Fact]
        public void getWizardsFromAuthor_Given_Rowling_Returns_HarryPotter_Voldemort_Dobby_HermioneGranger_RonWeasley_GinnyWeasley_FredWeasley_GeorgeWeasley()
        {
            var wizards = Wizard.Wizards.Value;

            string[] output = Queries.getWizardsFromAuthor("Rowling",wizards).ToArray();

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
        public void getHarryPotterWizards_returns_allHarryPotterWizardsAsTuples()
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
        public void getWizardNames_returns_AllWizardsNames_reverseOrder_groupedByCreator()
        {
            var wizards = Wizard.Wizards.Value;
            var output = Queries.getWizardNames(wizards);

            Assert.Equal(output, new string[]{"Merlin","Sauron","Gandalf","Voldemort","Ron Weasley","Hermione Granger","Harry Potter","Ginny Weasley","George Weasley","Fred Weasley","Dobby","Melisandre","Darth Vader","Darth Maul"}); 
        }
    }
}
