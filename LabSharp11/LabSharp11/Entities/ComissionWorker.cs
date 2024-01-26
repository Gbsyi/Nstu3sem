namespace LabSharp11.Entities;

public class ComissionWorker : Worker
{
    public decimal SoldPrice { get; set; }

    private decimal _baseSalaryPerDay;

    public decimal BaseSalaryPerDay
    {
        get => _baseSalaryPerDay;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Оклад не может быть отрицательным", nameof(BaseSalaryPerDay));
            }
            _baseSalaryPerDay = value;
        }
    }

    private decimal _comission;
    public decimal Comission
    {
        get => _comission;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Комиссия не может быть отрицательной", nameof(Comission));
            }
            _comission = value;
        }
    }

    public int DaysWorked { get; private set; } = 0;

    public ComissionWorker(string name, decimal baseSalaryPerDay, decimal comission, Sex sex)
        : base(name, sex)
    {
        BaseSalaryPerDay = baseSalaryPerDay;
        Comission = comission;
    }

    public void Sell(decimal soldPrice)
    {
        DaysWorked++;
        SoldPrice += soldPrice;
        Console.WriteLine($"Работник {Name} продал товар на сумму {soldPrice} руб. Всего за период продано на {SoldPrice} руб.");
    }
    
    public override decimal Payoff()
    {
        var salary = CalculateSalary();
        ResetSoldPrice();
        return salary;
    }

    public override string GetInfo()
    {
        return $"Работник с комиссионной оплатой: {Name}. Продано товаров на сумму {SoldPrice} руб.";
    }

    private void ResetSoldPrice()
    {
        SoldPrice = 0;
    }
    
    public override decimal CalculateSalary()
    {
        var soldPrice = SoldPrice;
        return (BaseSalaryPerDay * DaysWorked) + soldPrice * Comission;
    }
}