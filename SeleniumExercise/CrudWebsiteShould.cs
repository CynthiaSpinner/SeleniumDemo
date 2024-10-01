using SeleniumExercise.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumExercise
{
    public class CrudWebsiteShould
    {
        [Test]

        public void GoToHomePage()
        {
            //Arrange
            HomePage homePage = new HomePage();

            //Act
            string actual = homePage.GoToHomePage();

            //Assert
            Assert.AreEqual("Home Page - InClassDemo", actual);
        }
    }
}
