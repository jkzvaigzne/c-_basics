using System.Collections.Generic;
using System.Linq;

namespace Exercise12
{
    public interface IStudent
    {
        string[] TestsTaken { get; }
        void TakeTest(ITestPaper testPaper, string[] answers);
    }

    public class Student : IStudent
    {
        private readonly List<string> _testsTaken = new List<string>();

        public string[] TestsTaken => _testsTaken.ToArray();

        public void TakeTest(ITestPaper testPaper, string[] answers)
        {
            _testsTaken.Add(TestResult(testPaper, answers));
        }

        private string TestResult(ITestPaper testPaper, string[] studentAnswers)
        {
            decimal passMark = decimal.Parse(new string(testPaper.PassMark.Where(char.IsDigit).ToArray()));
            decimal percentage = (decimal)studentAnswers
                .Where((answer, index) => answer == testPaper.MarkScheme[index])
                .Count() / testPaper.MarkScheme.Length * 100;

            return $"{testPaper.Subject}: {(percentage >= passMark ? "Passed! " : "Failed! ")}({percentage:F2}%)";
        }
    }
}
