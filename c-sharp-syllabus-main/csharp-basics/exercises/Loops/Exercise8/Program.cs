using System;

class AsciiFigure
{
    const int Size = 7;

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

            while (j++ < 2 * (size - i - 1)) Console.Write(slashes);
            j = 0;

            while (j++ < 3 * i * 2) Console.Write(stars);
            j = 0;

            while (j++ < 2 * (size - i - 1)) Console.Write(backslashes);

            Console.WriteLine();
            i++;
        }
    }

}