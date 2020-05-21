using Microsoft.VisualStudio.TestTools.UnitTesting;
using MessageUtil;

namespace MessageUtilTest
{
    [TestClass]
    public class MessageUtilTests 
    {
        [TestMethod]
        public void ConstructWorks()
        {
            string testmessage = "Test";
            MessageUtilProgram mup = new MessageUtilProgram(testmessage);

            string value = mup.Message;
            Assert.AreEqual(testmessage, value,"Message didn't set correctly");
        }
        [TestMethod]
        public void SaluteWorks()
        {
            string testmessage = "Test";
            string expected = "helloTest";
            MessageUtilProgram mup2 = new MessageUtilProgram(testmessage);

            string value = mup2.SaluteMessage(mup2.Message);
            Assert.AreEqual(expected, value, "Message didn't salute correctly");
        }
    }
}
