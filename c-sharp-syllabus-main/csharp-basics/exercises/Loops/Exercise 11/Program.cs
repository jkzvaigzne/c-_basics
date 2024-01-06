using System;

class ReverseCase
{
    static void Main()
    {
        Console.WriteLine(reverse("Happy Birthday")); 
        Console.WriteLine(reverse("MANY THANKS")); 
        Console.WriteLine(reverse("sPoNtAnEoUs"));

        Console.Read();
    }

    static string reverse(string text)
    {
        char[] res = new char[text.Length];


        for (int i = 0; i < text.Length; i++)
        {
            char c = text[i];
            res[i] = char.IsLower(c) ? char.ToUpper(c) : char.IsUpper(c) ? char.ToLower(c) : c;
        }

        return new string(res);
    }
}
