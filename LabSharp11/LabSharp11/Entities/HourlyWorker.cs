namespace LabSharp11.Entities;

public class HourlyWorker : Worker
{
    private int _standardWorkHoursPerDay;
    public int StandardWorkHoursPerDay
    {
        get => _standardWorkHoursPerDay;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Стандартное количество рабочих часов в день не может быть отрицательным.", nameof(StandardWorkHoursPerDay));
            }
            _standardWorkHoursPerDay = value;
        }
    }

    public int WorkedHours { get; private set; }

    private decimal _salaryPerHour;
    public decimal SalaryPerHour
    {
        get => _salaryPerHour;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Оклад должен быть положительным", nameof(SalaryPerHour));
            } 
            _salaryPerHour = value;
        }
    }

    private decimal _overtimeMultiplier;
    public decimal OvertimeMultiplier
    {
        get => _overtimeMultiplier;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Коэффициент оплаты сверхурочных не может быть отрицательным.", nameof(OvertimeMultiplier));
            }
            _overtimeMultiplier = value;
        }
    }

    public int DaysWorked { get; private set; } = 0;
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
        WorkedHours += hours;
        Console.WriteLine($"Работник {Name} отработал {hours} часов.");
    }
    
    public override decimal Payoff()
    {
        var salary = CalculateSalary();
        ResetWorker();
        return salary;
    }

    public override string GetInfo()
    {
        return $"Работник с почасовой оплатой: {Name}. Отработано {WorkedHours} часов.";
    }

    private void ResetWorker()
    {
        WorkedHours = 0;
        DaysWorked = 0;
    }
    
    public override decimal CalculateSalary()
    {
        var workHours = WorkedHours;
        var requiredHours = StandardWorkHoursPerDay * DaysWorked;
        if (workHours < requiredHours)
        {
            return workHours * SalaryPerHour;
        }

        var overtimeHours = workHours - (StandardWorkHoursPerDay * DaysWorked);
        return SalaryPerHour * (StandardWorkHoursPerDay * DaysWorked) + SalaryPerHour * OvertimeMultiplier * overtimeHours;
    }
}