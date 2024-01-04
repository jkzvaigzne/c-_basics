using System;

class AsciiFigure
{
    const int Size = 3;

    static void Main()
    {
        char slashChar = '/';
        char asteriskChar = '*';
        char backslashChar = '\\';

        DrawFigure(Size, slashChar, asteriskChar, backslashChar);

        Console.Read();
    }

    static void DrawFigure(int size, char slashes, char stars, char backslashes)
    {
        int i = 0;
        while (i < size)
        {
            int j = 0;

            while (j++ < 2 * (size - i)) Console.Write(slashes);
            j = 0;

            while (j++ < 2 * i) Console.Write(stars);
            j = 0;

            while (j++ < 2 * (size - i)) Console.Write(backslashes);

            Console.WriteLine();
            i++;
        }
    }
}
