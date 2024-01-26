using LabSharp12.Utils;

namespace LabSharp11.Entities;

public class ComissionWorker : Worker
{
    public decimal SoldPrice { get; set; }
    public decimal BaseSalaryPerDay { get; set; }
    public decimal Comission { get; set; }
    public int DaysWorked { get; private set; } = 0;

    public ComissionWorker(string name, decimal baseSalaryPerDay, decimal comission, Sex sex)
        : base(name, sex)
    {
        BaseSalaryPerDay = baseSalaryPerDay;
        Comission = comission;
    }

    public void Sell(int soldPrice)
    {
        DaysWorked++;
        SoldPrice += soldPrice;
        Log.WriteLine($"Работник {Name} продал товар на сумму {soldPrice} руб. Всего за период продано на {SoldPrice} руб.");
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