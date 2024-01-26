using LabSharp11.Entities;
using LabSharp12.Utils;

namespace LabSharp11.Simulation;

public class CompanySimulator
{
    private readonly WorkerSimulator _workerSimulator;

    public CompanySimulator(WorkerSimulator workerSimulator)
    {
        _workerSimulator = workerSimulator;
    }
    
    public void Simulate(Company company, DateOnly beginFrom, int workingDays)
    {
        Log.WriteLine($"Начало симуляции работы компании {company.Name} с {beginFrom} по {beginFrom.AddDays(workingDays)}");
        
        for (int i = 0; i < workingDays; i++)
        {
            var simulatedToday = beginFrom.AddDays(i);
            Log.WriteLine($"\nСимуляция работы компании {company.Name} на {simulatedToday}. День {i + 1} из {workingDays}. День недели: {simulatedToday.DayOfWeek}");
            SimulateDay(company, simulatedToday);
            if (IsPayoffDay(simulatedToday))
            {
                Log.WriteLine("\nПришло время выплатить зарплату.");
                company.PayoffAllWorkers();
            }
        }
    }
    
    private void SimulateDay(Company company, DateOnly date)
    {
        if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
        {
            Log.WriteLine("Выходной день.");
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