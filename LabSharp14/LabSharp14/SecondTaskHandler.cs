using System.Globalization;

namespace LabSharp14;

public class SecondTaskHandler
{
    public void Handle(List<Aerocompany> aerocompanies)
    {
        AppUtils.WriteDivider();
        // Список рейсов
        Console.WriteLine("Список рейсов: ");
        foreach (var company in aerocompanies)
        {
            Console.WriteLine(company.ToString());
        }
        
        // Полёты с пунктом назначения
        AppUtils.WriteDivider();
        Console.WriteLine("Введите пункт назначения для фильтрации");
        var destination = Console.ReadLine();
        var flightsByDestination = FindFlightsByDestination(aerocompanies, destination);
        Console.WriteLine($"Полёты с пунктом назначения {destination}:");
        foreach (var company in flightsByDestination)
        {
            Console.WriteLine(company.ToString());
        }
        
        // Количество полётов в день недели
        AppUtils.WriteDivider();
        Console.Write("Введите день недели: ");
        var dowInput = Console.ReadLine()!;
        var flightsCountByDayOfWeek = GetFlightsCountByDayOfWeek(aerocompanies, dowInput);
        Console.WriteLine($"Полётов, вылетающих в день недели '{dowInput}': {flightsCountByDayOfWeek}");

        // Самый ранний полёт в понедельник
        AppUtils.WriteDivider();
        var earliestFlight = GetEarliestFlightByDayOfWeek(aerocompanies, DayOfWeek.Monday);
        if (earliestFlight is not null)
        {
            Console.WriteLine($"Самый ранний полёт в понедельник: {earliestFlight}");
        }
        else
        {
            Console.WriteLine("Полётов в понедельник не найдено");
        }
        
        AppUtils.WriteDivider();
        // Рейс, который вылетает в среду или пятницу позже всех
        var latestFlight = GetLatestFlightByDaysOfWeek(aerocompanies, [DayOfWeek.Wednesday, DayOfWeek.Friday]);
        if (latestFlight is not null)
        {
            Console.WriteLine($"Рейс, который вылетает в среду или пятницу позже всех: {latestFlight}");
        }
        else
        {
            Console.WriteLine("Рейсов, которые вылетают в среду или пятницу не найдено");
        }
        
        AppUtils.WriteDivider();
        // Список рейсов, упорядоченных по времени вылета
        var flightsByDate = GetFlightsOrderedByDate(aerocompanies);
        Console.WriteLine("Список рейсов, упорядоченных по времени вылета:");
        foreach (var company in flightsByDate)
        {
            Console.WriteLine(company.ToString());
        }
    }

    private Aerocompany[] GetFlightsOrderedByDate(List<Aerocompany> aerocompanies)
    {
        return aerocompanies.OrderBy(x => x.FlightDate).ToArray();
    }

    private Aerocompany? GetLatestFlightByDaysOfWeek(List<Aerocompany> aerocompanies, DayOfWeek[] dayOfWeeks)
    {
        return aerocompanies
            .Where(x => dayOfWeeks.Contains(x.FlightDayOfWeek))
            .MaxBy(x => x.FlightDate);
    }

    private Aerocompany? GetEarliestFlightByDayOfWeek(List<Aerocompany> aerocompanies, DayOfWeek dayOfWeek)
    {
        return aerocompanies
            .Where(x => x.FlightDayOfWeek == dayOfWeek)
            .MinBy(x => x.FlightDate);
    }

    private int GetFlightsCountByDayOfWeek(List<Aerocompany> aerocompanies, string dowInput)
    {
        return aerocompanies
            .Select(x => DateTimeFormatInfo.CurrentInfo.GetDayName(x.FlightDayOfWeek))
            .Where(x => string.Equals(x, dowInput, StringComparison.CurrentCultureIgnoreCase))
            .Count();
    }

    private Aerocompany[] FindFlightsByDestination(List<Aerocompany> aerocompanies, string? destination)
    {
        return aerocompanies
            .Where(x => string.Equals(x.Destination, destination, StringComparison.CurrentCultureIgnoreCase))
            .ToArray();
    }
}