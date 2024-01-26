using System.Globalization;

namespace LabSharp14;

public class SecondTaskHandler
{
    public void Handle(List<Aerocompany> aerocompanies)
    {
        Console.WriteLine("Введите пункт назначения для фильтрации");
        var destination = Console.ReadLine();
        var filteredOne = aerocompanies.Where(x => string.Equals(x.Destination, destination, StringComparison.CurrentCultureIgnoreCase))
            .ToArray();
        Console.WriteLine($"Полёты с пунктом назначения {destination}:");
        foreach (var company in filteredOne)
        {
            Console.WriteLine(company.ToString());
        }
        
        Console.Write("Введите день недели: ");
        var dowInput = Console.ReadLine()!;
        var secondQuery = aerocompanies.Where(x => DateTimeFormatInfo.CurrentInfo.GetDayName(x.FlightDayOfWeek) == dowInput).Count();
        Console.WriteLine($"Полётов, вылетающих в день недели '{dowInput}': {secondQuery}");
        
        Console.WriteLine();
    }
}