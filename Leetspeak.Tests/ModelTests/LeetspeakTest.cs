using Microsoft.VisualStudio.TestTools.UnitTesting;
using Translator;

namespace Translator.Tests
{
  [TestClass]
  public class LeetspeakTranslatorTest
  {
    [TestMethod]
    public void Traslate_ReplaceLetterEWithThree_L33()
    {
      LeetspeakTranslator testLeetspeak = new LeetspeakTranslator();
      Assert.AreEqual("l33",testLeetspeak.Translating("lEe"));
    }
    [TestMethod]
    public void Traslate_ReplaceLetterOWithZero_P03m()
    {
      LeetspeakTranslator testLeetspeak = new LeetspeakTranslator();
      Assert.AreEqual("p03m",testLeetspeak.Translating("poem"));
    }
    [TestMethod]
    public void Traslate_ReplaceLetterTWithSeven_7win()
    {
      LeetspeakTranslator testLeetspeak = new LeetspeakTranslator();
      Assert.AreEqual("7win",testLeetspeak.Translating("twin"));
    }
    [TestMethod]
    public void Traslate_ReplaceLetterIWithOne_10wa()
    {
      LeetspeakTranslator testLeetspeak = new LeetspeakTranslator();
      Assert.AreEqual("10wa",testLeetspeak.Translating("Iowa"));
    }
    [TestMethod]
    public void Traslate_CheckAllBehaviors_z173m0z()
    {
      LeetspeakTranslator testLeetspeak = new LeetspeakTranslator();
      Assert.AreEqual("S173m0z",testLeetspeak.Translating("SItemos"));
    }
    [TestMethod]
    public void Traslate_CheckAllBehaviors_finalOutput()
    {
      LeetspeakTranslator testLeetspeak = new LeetspeakTranslator();
      Assert.AreEqual("D0n'7 y0u l0v3 7h3z3 'S7ring' 3x3rciz3z? 1 d0!",testLeetspeak.Translating("Don't you love these 'String' exercises? I do!"));
    }
  }
}
