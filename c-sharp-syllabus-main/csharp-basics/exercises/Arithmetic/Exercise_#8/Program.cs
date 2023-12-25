namespace Exercise__8
{
    internal class Program
    {
        static void CalculateSalary(double baseSallary, int workedHours, string worker)
        {
            const double minWage = 8.00;
            const int workWeekHours = 40;
            const int maxWorkHours = 60;

            double totalSallary =
                (baseSallary < minWage) ? 0 :
                (workedHours > maxWorkHours) ? 0 :
                (workedHours <= workWeekHours) ? workedHours * baseSallary :
                workWeekHours * baseSallary + (workedHours - workWeekHours) * baseSallary * 1.5;

            string errorMsg = (baseSallary < minWage) ?
                "Error:Base pay less than the min wage" :
                (workedHours > maxWorkHours) ? "Error:Work hours worked exceed the max limit." : "";

            string outputMessage = $"{worker}: {(errorMsg != "" ? errorMsg : $"Sallary: ${totalSallary:F2}")}";
            Console.WriteLine(outputMessage);
        }

        static void Main(string[] args)
        {
            CalculateSalary(6.20, 35, "Janis");
            CalculateSalary(12.00, 73, "Elizabete");
            CalculateSalary(9.30, 47, "Peteris");

            Console.Read();
        }
    }
}
