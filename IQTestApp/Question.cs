using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQTestApp
{
    public class Question
    {
        public string Text { get; set; }
        public List<string> Answers { get; set; }
        public List<string> AnswerImagePaths { get; set; }
        public int CorrectIndex { get; set; }
        public string QuestionImagePath { get; set; }
        public string Category { get; set; }

        public Question(string text, string questionImagePath, List<string> answers, List<string> answerImagePaths, int correctIndex, string category)
        {
            Text = text;
            Answers = answers;
            AnswerImagePaths = answerImagePaths;
            CorrectIndex = correctIndex;
            QuestionImagePath = questionImagePath;
            Category = category;
        }
        public Question(string text, string questionImagePath, List<string> answers, int correctIndex, string category)
        {
            Text = text;
            Answers = answers;
            AnswerImagePaths = null;
            CorrectIndex = correctIndex;
            QuestionImagePath = questionImagePath;
            Category = category;
        }
    }
}
