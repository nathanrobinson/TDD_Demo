using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDDemoApp;

namespace TDDDemoAppTests
{
    [TestClass]
    public class TextAnalyzerTests
    {
        [DataRow("testdata", 1)]
        // [DataRow("test data", 2)]
        // [DataRow("This is a test sentence.", 5)]
        // [DataRow(null, 0)]
        // [DataRow("", 0)]
        // [DataRow(" ", 0)]
        // [DataRow("This is a test sentence.  This string has double-spacing between sentences.", 11)]
        // [DataRow("This   is a   really  oddly    formatted       sentence.", 7)]
        // [DataRow(" This sentence has leading and trailing spaces. ", 7)]

        [TestCategory("TextAnalyzer")]
        [TestCategory("Word")]
        [DataTestMethod]
        public void When_passed_a_string_should_count_number_of_words(string text, int expected)
        {
            var analyzer = new TextAnalyzer();
            var result = analyzer.CountWords(text);
            result.Should().Be(expected);
        }

        [DataRow("This is a sentence.", 1)]
        // [DataRow("This is a sentence. So is this.", 2)]
        // [DataRow("This is a sentence. But is this, too?", 2)]
        // [DataRow("One sentence. Two sentences? Three sentences. Four!", 4)]
        // [DataRow("testdata", 0)]
        // [DataRow("test data", 0)]
        // [DataRow("This   is a   really  oddly    formatted       sentence.", 1)]
        // [DataRow(" This non-sentence has leading and trailing spaces ", 0)]
        // [DataRow(".", 0)]
        // [DataRow("This could be a sentence...", 1)]
        // [DataRow("...", 0)]
        // [DataRow("WTF?!?!?!?!?", 1)]

        [TestCategory("TextAnalyzer")]
        [TestCategory("Sentence")]
        [DataTestMethod]
        public void When_passed_a_paragraph_should_count_number_of_sentences(string text, int expected)
        {
            var analyzer = new TextAnalyzer();
            var result = analyzer.CountSentences(text);
            result.Should().Be(expected);
        }

        [DataRow("testdata", "testdata")]
        // [DataRow("test data", "test,data")]
        // [DataRow("This is a test sentence.", "This,is,a,test,sentence")]
        // [DataRow(null, null)]
        // [DataRow("", null)]
        // [DataRow(" ", null)]
        // [DataRow("This is a test sentence.  This string has double-spacing between sentences.", "This,is,a,test,sentence,This,string,has,double-spacing,between,sentences")]
        // [DataRow("This   is a   really  oddly    formatted       sentence.", "This,is,a,really,oddly,formatted,sentence")]
        // [DataRow(" This sentence has leading and trailing spaces. ", "This,sentence,has,leading,and,trailing,spaces")]

        [TestCategory("TextAnalyzer")]
        [TestCategory("Word")]
        [DataTestMethod]
        public void When_passed_a_string_should_return_an_array_of_words(string text, string expectedJoined)
        {
            var expected = expectedJoined == null ? new string [0] : expectedJoined.Split(',');
            var analyzer = new TextAnalyzer();
            var result = analyzer.GetWords(text);
            result.Should().Equal(expected).And.HaveSameCount(expected);
        }
    }
}
