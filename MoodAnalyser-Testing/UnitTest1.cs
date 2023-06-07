namespace MoodAnalyser_Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            moodAnalyzaer mood =new moodAnalyzaer();
            string expected ="Happy";
            string actual = " I am in happy mood";
            actual = mood.AnalyzaerMood("heppy");
            Assert.AreEqual(expected, actual);

        }
    }
}