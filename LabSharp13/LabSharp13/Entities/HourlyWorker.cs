
namespace LabSharp13.Entities;

public class HourlyWorker : Worker
{
    public int StandardWorkHoursPerDay { get; set; }
    public int WorkHours { get; set; }
    public decimal SalaryPerHour { get; set; }
    public decimal OvertimeMultiplier { get; set; }

    public HourlyWorker(int standardWorkHoursPerDay, string name, decimal salaryPerHour, decimal overtimeMultiplier, Sex sex)
        : base(name, sex)
    {
        StandardWorkHoursPerDay = standardWorkHoursPerDay;
        SalaryPerHour = salaryPerHour;
        OvertimeMultiplier = overtimeMultiplier;
    }

    public void Work(int hours)
    {
        DaysWorked++;
        WorkHours += hours;
        Console.WriteLine($"Работник {Name} отработал {hours} часов.");
    }
    
    public override decimal Payoff()
    {
        var salary = CalculateSalary();
        ResetWorkHours();
        return salary;
    }

    public override string GetInfo()
    {
        return $"Работник с почасовой оплатой: {Name}. Отработано {WorkHours} часов.";
    }

    private void ResetWorkHours()
    {
        WorkHours = 0;
    }

    public override decimal CalculateSalary()
    {
        var workHours = WorkHours;
        var requiredHours = StandardWorkHoursPerDay * DaysWorked;
        if (workHours < requiredHours)
        {
            return workHours * SalaryPerHour;
        }

        var overtimeHours = workHours - (StandardWorkHoursPerDay * DaysWorked);
        return SalaryPerHour * (StandardWorkHoursPerDay * DaysWorked) + SalaryPerHour * OvertimeMultiplier * overtimeHours;
    }

    public override object Clone()
    {
        return new HourlyWorker(StandardWorkHoursPerDay, Name, SalaryPerHour, OvertimeMultiplier, Sex)
        {
            DaysWorked = DaysWorked,
            WorkHours = WorkHours
        };
    }
    
    public override string ToString()
    {
        return $"[Рабочий с почасовой оплатой: {Name}. Оклад {SalaryPerHour} руб/час. Отработано {WorkHours} часов.] ";
    }
}