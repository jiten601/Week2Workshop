using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime birthDate = new DateTime(2003, 09, 17);
        DateTime currentDate = DateTime.Now;

        TimeSpan ageSpan = currentDate - birthDate;
        int ageYears = (int)(ageSpan.TotalDays / 365.25);

        Console.WriteLine($"Birthdate: {birthDate.ToShortDateString()}");
        Console.WriteLine($"Current Date: {currentDate.ToShortDateString()}");
        Console.WriteLine($"Age (approx): {ageYears} years");

        DateTime plusTenDays = birthDate.AddDays(10);
        Console.WriteLine($"Birthdate + 10 days: {plusTenDays.ToShortDateString()}");
    }
}
