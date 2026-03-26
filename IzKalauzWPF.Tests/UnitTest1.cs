using NUnit.Framework;
using Izkalauz_WPF.Models;
using System.Collections.Generic;
using System.Runtime.Versioning; // <--- EZ KELL A FEJLÉCBE!

namespace IzKalauzWPF.Tests
{
    [TestFixture]
    [SupportedOSPlatform("windows")] // <--- IDE RAKD AZ OSZTÁLY FÖLÉ!
    public class RecipeModelTests
    {
        [Test]
        public void UjRecept_AlapertelmezettLista_NemNull()
        {
            var recept = new Recipe();
            var hozzavalok = recept.Ingredients;
            Assert.That(hozzavalok, Is.Not.Null);
        }

        [Test]
        public void ReceptAdatok_HelyesenMentodnek()
        {
            var recept = new Recipe
            {
                Name = "Teszt Pörkölt",
                Category = "Ebéd"
            };

            Assert.That(recept.Name, Is.EqualTo("Teszt Pörkölt"));
            Assert.That(recept.Category, Is.EqualTo("Ebéd"));
        }
    }
}