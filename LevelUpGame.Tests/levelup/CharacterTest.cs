using NUnit.Framework;
using levelup;

namespace levelup
{
    [TestFixture]
    public class CharacterTest
    {
        static string DEFAULT_CHARACTER_NAME = "TEAM AWESOME";
        private Character? testObj;
        private GameMap? testMap;

        [SetUp]
        public void SetUp()
        {
            testObj = new Character();
            testMap = new GameMap();
        }

        [Test]
        public void IsNameAvailable()
        {
            Assert.IsNotNull(testObj.GetName());
        }

        [Test]
        public void CheckDefaultCharacterName()
        {
            Assert.AreEqual(testObj.GetName(),DEFAULT_CHARACTER_NAME);
        }

        [Test]
        public void CheckCharacterName()
        {
            Character? testObj = new Character("NOT DEFAULT");
            Assert.AreEqual(testObj.GetName(),"NOT DEFAULT");
            Assert.AreNotEqual(testObj.GetName(),DEFAULT_CHARACTER_NAME);
        }

        [Test]
        public void CheckEnterMap()
        {
            testObj.SetMap(testMap);
            Assert.AreEqual(testObj.GetMap(),testMap);
        }
    }
}