namespace Exercise12
{
    public interface ITestPaper
    {
        string Subject { get; }
        string PassMark { get; }
        string[] MarkScheme { get; }
    }

    public class TestPaper : ITestPaper
    {
        public string Subject { get; }
        public string[] MarkScheme { get; }
        public string PassMark { get; }

        public TestPaper(string subject, string[] markScheme, string passMark) =>
            (Subject, MarkScheme, PassMark) = (subject, markScheme, passMark);
    }
}
