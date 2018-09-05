using Microsoft.VisualStudio.TestTools.UnitTesting;
using Translator;

namespace Translator.Tests
{
  [TestClass]
  public class LeetspeakTranslatorTest
  {
    [TestMethod]
    public void Traslate_ReplaceLetterEWithThree_L33t()
    {
      LeetspeakTranslator testLeetspeak = new LeetspeakTranslator();
      Assert.AreEqual("l33t",testLeetspeak.Translating("leet"));
    }
  }
}
