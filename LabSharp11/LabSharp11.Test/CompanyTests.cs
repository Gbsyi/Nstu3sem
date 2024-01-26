using System.Globalization;
using LabSharp11.Entities;
using LabSharp11.Simulation;
using LabSharp11.Store;

namespace LabSharp11.Test;

file class TestWorkerDaySimulator : IWorkerSimulator
{
    private decimal _soldAmount;
    private int _workedHours;

    public TestWorkerDaySimulator(decimal soldAmount, int workedHours)
    {
        _soldAmount = soldAmount;
        _workedHours = workedHours;
    }

    public void SimulateDay(Worker worker, DateOnly date)
    {
        switch (worker)
        {
            case HourlyWorker hourlyWorker:
                SimulateHourlyWorkerDay(hourlyWorker);
                break;
            case ComissionWorker comissionWorker:
                SimulateComissionWorkerDay(comissionWorker);
                break;
        }
    }

    private void SimulateComissionWorkerDay(ComissionWorker comissionWorker)
    {
        comissionWorker.Sell(_soldAmount);
    }

    private void SimulateHourlyWorkerDay(HourlyWorker hourlyWorker)
    {
        hourlyWorker.Work(_workedHours);
    }
}

public class CompanyTests
{
    [Theory]
    [InlineData(8, "100")]
    [InlineData(6, "10.0")]
    [InlineData(3, "1.0")]
    public void Test1(int workHours, string soldAmountStr)
    {
        var soldAmount = Convert.ToDecimal(soldAmountStr, NumberFormatInfo.InvariantInfo);
        
        var company = new Company("ООО \"РосАтом\"");
        var hourlyWorker = new HourlyWorker(8, "Пётр", 100, 1.2m, Sex.Male);
        var comissionWorker = new ComissionWorker( "Пётр", 100, 1.0m, Sex.Male);
        company.HireWorker(hourlyWorker);
        var simulator = new TestWorkerDaySimulator(soldAmount, workHours);
        var store = new SimulationStore
        {
            Company = company,
            Today = new DateOnly(2021, 10, 10)
        };
        
        simulator.SimulateDay(hourlyWorker, store.Today);
        simulator.SimulateDay(comissionWorker, store.Today);
        Assert.Equal(workHours, hourlyWorker.WorkedHours);
        Assert.Equal(hourlyWorker.SalaryPerHour * workHours, hourlyWorker.CalculateSalary());
        
        Assert.Equal(soldAmount, comissionWorker.SoldPrice);
        Assert.Equal(soldAmount * comissionWorker.Comission + comissionWorker.BaseSalaryPerDay, comissionWorker.CalculateSalary());
    }
}