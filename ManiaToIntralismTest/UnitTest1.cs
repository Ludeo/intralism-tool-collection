using ManiaToIntralism;
using NUnit.Framework;

namespace ManiaToIntralismTest
{
    public class Tests
    {
        [SetUp]
        public void Setup() { }

        /// <summary>
        ///     Tests for <see cref="HitObject.ParseManiaNote"/>>
        /// </summary>
        [Test]
        public void ParseManiaNote()
        {
            Assert.AreEqual(HitObject.ParseManiaNote("64"), "Left");
            Assert.AreEqual(HitObject.ParseManiaNote("192"), "Up");
            Assert.AreEqual(HitObject.ParseManiaNote("320"), "Down");
            Assert.AreEqual(HitObject.ParseManiaNote("448"), "Right");
            Assert.AreEqual(HitObject.ParseManiaNote("64-192"), "Left-Up");
            Assert.AreEqual(HitObject.ParseManiaNote("192-64"), "Up-Left");
            Assert.AreEqual(HitObject.ParseManiaNote("64-192-320"), "Left-Up-Down");
            Assert.AreEqual(HitObject.ParseManiaNote("320-64-192"), "Down-Left-Up");
            
            Assert.AreNotEqual(HitObject.ParseManiaNote("65-191-321-447"), "Left-Up-Down-Right");
        }

        /// <summary>
        ///     Tests for <see cref="CsvReader.GetCsvContent"/>>
        /// </summary>
        [Test]
        public void GetCsvContent()
        {
            string[][] values = CsvReader.GetCsvContent("Resources/CsvContentTest.txt");
            Assert.AreEqual(values[0][0], "1");
            Assert.AreEqual(values[0][1], "2");
            Assert.AreEqual(values[0][2], "3");
            Assert.AreEqual(values[1][0], "4");
            Assert.AreEqual(values[1][1], "5");
            Assert.AreEqual(values[1][2], "6");
            Assert.AreEqual(values[2][0], "7");
            Assert.AreEqual(values[2][1], "8");
            Assert.AreEqual(values[2][2], "9");
        }
    }
}