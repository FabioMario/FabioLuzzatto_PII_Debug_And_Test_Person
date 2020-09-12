using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            // Insertá tu código de inicialización aquí
        }

        [Test]
        public void WithValidName() // Cambiá el nombre para indicar qué estás probando
        {
            string validName = "Fabio";
            Person uno = new Person(validName, "");
            Assert.AreEqual(validName, uno.Name);
        }

        [Test]
        public void WithInvalidName()
        {
            string invalidName = "";
            Person uno = new Person(invalidName, "");
            Assert.AreEqual(null, uno.Name);
        }

        [Test]
        public void WithValidId() 
        {
            string validId = "4.849.254-2";
            Person uno = new Person("",validId);
            Assert.AreEqual(validId, uno.ID);
        }

        [Test]
        public void WithInvalidId()
        {
            string invalidId = "32213123123123123";
            Person uno = new Person("", invalidId);
            Assert.AreEqual(null, uno.ID);
        }
    }
}