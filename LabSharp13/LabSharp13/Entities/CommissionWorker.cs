namespace LabSharp13.Entities;

public class CommissionWorker : Worker
{
    public decimal SoldPrice { get; set; }
    public decimal BaseSalaryPerDay { get; set; }
    public decimal Comission { get; set; }

    public CommissionWorker(string name, decimal baseSalaryPerDay, decimal comission, Sex sex)
        : base(name, sex)
    {
        BaseSalaryPerDay = baseSalaryPerDay;
        Comission = comission;
    }

    public void Sell(int soldPrice)
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

    public override object Clone()
    {
        return new CommissionWorker(Name, BaseSalaryPerDay, Comission, Sex)
        {
            SoldPrice = SoldPrice,
            BaseSalaryPerDay = BaseSalaryPerDay
        };
    }

    public override string ToString()
    {
        return $"[Работник с комиссионной оплатой: {Name}. Оклад {BaseSalaryPerDay} руб. Комиссия с продаж {Comission}. Продано товаров на сумму {SoldPrice} руб.]";
    }
}