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
    using Models.Questions.Interfaces;
 

    public static class MaturaParser
    {
        public static Matriculation GenerateMatura(string path)
        {
            //var numberOfQuestions = 30;
            //var questionsRegex = $@"^(?<number>[1-2]?[0-9]|{numberOfQuestions})\. (?<question>(.+?))(?=А\) |\d{{1,2}}\. )";
            //var rightAnswersRegex = @"(\d{1,2}).\s*([АБВГ])\s*(\d{1,2})";

            //var parsedText = ParsePdf(path);
            //var questionsMatches = Regex.Matches(parsedText, questionsRegex, RegexOptions.Multiline | RegexOptions.Singleline);
            //var rightAnswersMatches = Regex.Matches(parsedText, rightAnswersRegex, RegexOptions.Multiline | RegexOptions.Singleline);

            //var parsedQuestions = new Dictionary<int, string>();
            //var parsedAnswers = new Dictionary<int, string>();


            //for (int i = 0; i < numberOfQuestions; i++)
            //{
            //    parsedQuestions[int.Parse(questionsMatches[i].Groups["number"].Value)] = questionsMatches[i].Groups["question"].Value.Trim();
            //}

            //foreach (var parsedQuestion in parsedQuestions)
            //{
            //    IQuestion question = new QuestionClosedAnswer();
            //}



            //IDictionary<int, IQuestion> questions = new Dictionary<int, IQuestion>();

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