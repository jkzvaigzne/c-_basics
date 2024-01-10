using System;
using System.Globalization;

public class DateTimeExtension
{
    public static string WeekdayInDutch(int year, int month, int day)
    {
        DateTime date = new DateTime(year, month, day);
        CultureInfo dutchCul = CultureInfo.GetCultureInfo("nl-NL");
        string inDutch = date.ToString("dddd", dutchCul);

        return inDutch;
    }
}
