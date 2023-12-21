namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] classesList =
            {
            "English III",
            "Precalculus",
            "Music Theory",
            "Biotechnology",
            "Principles of Technology I",
            "Latin II",
            "AP US History",
            "Business Computer Information Systems"
            };

            string[] teachersList =
            {
            "Ms. Lapan",
            "Mrs. Gideon",
            "Mr. Davis",
            "Ms. Palmer",
            "Ms. Garcia",
            "Mrs. Barnett",
            "Ms. Johannessen",
            "Mr. James"
            };


            Console.WriteLine("+------------------------------------------------------------+");
            Console.WriteLine("| ID | Class                        | Teacher             |");
            Console.WriteLine("+------------------------------------------------------------+");

            Console.WriteLine($"| 1  | {classesList[0],-26} | {teachersList[0], -15} |");
            Console.WriteLine($"| 2  | {classesList[1], -26} | {teachersList[1], -15} |");
            Console.WriteLine($"| 3  | {classesList[2], -26} | {teachersList[2], -15} |");
            Console.WriteLine($"| 4  | {classesList[3], -26} | {teachersList[3], -15} |");
            Console.WriteLine($"| 5  | {classesList[4], -26} | {teachersList[4], -15} |");
            Console.WriteLine($"| 6  | {classesList[5], -26} | {teachersList[5], -15} |");
            Console.WriteLine($"| 7  | {classesList[6], -26} | {teachersList[6], -15} |");
            Console.WriteLine($"| 8  | {classesList[7], -26} | {teachersList[7], -15} |");

            Console.WriteLine("+------------------------------------------------------------+");
            Console.ReadLine();
        }
    }
}
