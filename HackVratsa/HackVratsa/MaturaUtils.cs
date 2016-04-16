using System.Collections.Generic;
using System.Data;
using HackVratsa.Models.Questions;

namespace HackVratsa
{
    public static class MaturaUtils
    {
        // todo: move into another class?
        private const string MaturasPath = @"\Maturas\";
        
        public static readonly Question QuestionOne = new Question("Барака Обама", "Кой е президената на САЩ?", 1, 1, new List<string>() {"Барак Обама", "Доналд Тръмп", "Бил Геитс", "Аз"});

        public static readonly Question QuestoinTwo = new Question("неправилно", "Кое е неправилно?", 2, 1, new List<string>() {"неправилнооо", "правйлно", "гресно", "да"});

    }
}
