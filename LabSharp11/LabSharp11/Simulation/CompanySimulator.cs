using LabSharp11.Entities;

namespace LabSharp11.Simulation;

public interface ICompanySimulator
{
    void Simulate(Company company, DateOnly beginFrom, int workingDays);
}

public class CompanySimulator : ICompanySimulator
{
    private readonly IWorkerSimulator _workerSimulator;
    public CompanySimulator(IWorkerSimulator workerSimulator)
    {
        _workerSimulator = workerSimulator;
    }
    
    public void Simulate(Company company, DateOnly beginFrom, int workingDays)
    {
        Console.WriteLine($"Начало симуляции работы компании {company.Name} с {beginFrom} по {beginFrom.AddDays(workingDays)}");
        
        for (int i = 0; i < workingDays; i++)
        {
            var simulatedToday = beginFrom.AddDays(i);
            Console.WriteLine($"\nСимуляция работы компании {company.Name} на {simulatedToday}. День {i + 1} из {workingDays}. День недели: {simulatedToday.DayOfWeek}");
            SimulateDay(company, simulatedToday);
            if (IsPayoffDay(simulatedToday))
            {
                Console.WriteLine("\nПришло время выплатить зарплату.");
                company.PayoffAllWorkers();
            }
        }
    }

    private void SimulateDay(Company company, DateOnly date)
    {
        if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
        {
            Console.WriteLine("Выходной день.");
            return;
        }
        foreach (var worker in company.Workers)
        {
            _workerSimulator.SimulateDay(worker, date);
        }
    }
    
    private bool IsPayoffDay(DateOnly date)
    {
        // Середина или конец месяца.
        return date.Day == 15 || date.Day == date.AddMonths(1).AddDays(-1).Day;
    }
}