using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using HackVratsa.Models.Matriculation;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

namespace HackVratsa
{
    public static class MaturaParser
    {
        public static Matriculation GenerateMatura(string path)
        {
            var questionsRegex = @"^(?<number>[1-2]?[0-9]|30)\. (?<question>(.+?))(?=А\) |\d{1,2}\. )";
            
            var parsedText = ParsePdf(path);
            var questions = Regex.Matches(parsedText, questionsRegex, RegexOptions.Multiline | RegexOptions.Singleline);
            
            var parsedQuestions = new Dictionary<int, string>();
            var parsedAnswers = new Dictionary<int, string>();

            for (int i = 0; i < 30; i++)
            {
                parsedQuestions[int.Parse(questions[i].Groups["number"].Value)] = questions[i].Groups["question"].Value.Trim();
            }

            return null;
        }

        private static string ParsePdf(string path)
        {
            if (File.Exists(path))
            {
                var result = new StringBuilder();
                using (var reader = new PdfReader(path))
                {
                    for (int page = 1; page <= reader.NumberOfPages; page++)
                    {
                        ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                        var currentText = PdfTextExtractor.GetTextFromPage(reader, page, strategy).Trim();

                        currentText = currentText.Replace("\n", "\r\n");

                        result.AppendLine(currentText);
                    }
                }

                return result.ToString();
            }

            throw new FileNotFoundException("Matura not found!");
        }
    }
}
