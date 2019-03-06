using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace TDDDemoApp
{
    public class TextAnalyzer
    {
        public int CountWords(string text)
        {
            // throw new NotImplementedException();
            
            // [DataRow("testdata", 1)]
            return 1;

            // [DataRow("test data", 2)]
            // return text.Contains(" ") ? 2 : 1;

            // [DataRow("This is a test sentence.", 5)]
            // return text.Split(' ').Length;

            // [DataRow(null, 0)]
            // return text?.Split(' ').Length ?? 0;

            // [DataRow("", 0)]
            // return text == "" ? 0 : text?.Split(' ').Length ?? 0;

            // [DataRow(" ", 0)]
            // return string.IsNullOrWhiteSpace(text) ? 0 : text.Split(' ').Length;

            // [DataRow("This is a test sentence.  This string has double-spacing between sentences.", 11)]
            // return string.IsNullOrWhiteSpace(text) ? 0 : text.Replace("  ", " ").Split(' ').Length;

            // [DataRow("This   is a   really  oddly    formatted       sentence.", 7)]
            // if (string.IsNullOrWhiteSpace(text)) 
            // {
            //     return 0;
            // }
            // while (text.Contains("  "))
            // {
            //     text = text.Replace("  ", " ");
            // }
            // return text.Split(' ').Length;

            // [DataRow(" This sentence has leading and trailing spaces. ", 7)]
            // if (string.IsNullOrWhiteSpace(text)) 
            // {
            //     return 0;
            // }
            // while (text.Contains("  "))
            // {
            //     text = text.Replace("  ", " ");
            // }
            // return text.Trim().Split(' ').Length;

            //Refactored
            // var re = new Regex(@"[^ ]+");
            // return re.Matches(text ?? "").Count;

            //Another Refactor
            // return GetWords(text).Length;
        }

        public int CountSentences(string text)
        {
            // throw new NotImplementedException();
            return 1;
            // return text.Count(c => c == '.');
            // return text.Count(c => c == '.' || c == '?');

            // const string terminators = ".?!";
            // return text.Count(c => terminators.Contains(c));

            // var re = new Regex(@"\w[\.\?\!]");
            // return re.Matches(text ?? "").Count;
        }

        public string[] GetWords(string text)
        {
            //throw new NotImplementedException();

            // [DataRow("testdata", "testdata")]
            return new [] { text };
            
            // [DataRow("test data", "test,data")]
            //return text.Split(' ');

            // [DataRow("This is a test sentence.", "This,is,a,test,sentence")]
            //return text.Replace(".", "").Split(' ');
            
            // [DataRow(null, null)]
            //return text == null ? new string [0] : text.Replace(".", "").Split(' ');

            // [DataRow("", null)]
            // [DataRow(" ", null)]
            //return string.IsNullOrWhiteSpace(text) ? new string[0] : text.Replace(".", "").Split(' ');

            // [DataRow("This is a test sentence.  This string has double-spacing between sentences.", "This,is,a,test,sentence,This,string,has,double-spacing,between,sentences")]
            //return string.IsNullOrWhiteSpace(text) ? new string[0] : text.Replace("  ", " ").Replace(".", "").Split(' ');

            // [DataRow("This   is a   really  oddly    formatted       sentence.", "This,is,a,really,oddly,formatted,sentence")]
            // if (string.IsNullOrWhiteSpace(text))
            // {
            //     return new string [0];
            // }
            // while (text.Contains("  ")) 
            // {
            //     text = text.Replace("  ", " ");
            // }
            // return text.Replace(".", "").Split(' ');

            // [DataRow(" This sentence has leading and trailing spaces. ", "This,sentence,has,leading,and,trailing,spaces")]
            // if (string.IsNullOrWhiteSpace(text))
            // {
            //     return new string [0];
            // }
            // while (text.Contains("  ")) 
            // {
            //     text = text.Replace("  ", " ");
            // }
            // return text.Trim().Replace(".", "").Split(' ');

            // refactored
            // var re = new Regex(@"[\w\-]+");
            // return re.Matches(text ?? "").Select(m => m.Value).ToArray();
        }
    }
}