using System.Globalization;
using LabSharp11.Entities;

namespace LabSharp11.Test;

public class ComissionWorkerTests
{
    [Theory]
    [InlineData(-1)]
    [InlineData(-5)]
    [InlineData(-1000)]
    public void CreateFails_InvalidBaseSalaryPerDay(int baseSalaryPerDay)
    {
        var exception = Assert.Throws<ArgumentException>(() =>
        {
            _ = new ComissionWorker("Иван", baseSalaryPerDay, 1.2m, Sex.Male);
        });
        Assert.Equal(nameof(ComissionWorker.BaseSalaryPerDay), exception.ParamName);
    }

    [Theory]
    [InlineData(-1)]
    public void CreateFails_InvalidComission(decimal comission)
    {
        var exception = Assert.Throws<ArgumentException>(() =>
        {
            _ = new ComissionWorker("Иван", 1000, comission, Sex.Male);
        });
        Assert.Equal(nameof(ComissionWorker.Comission), exception.ParamName);
    }
    
    [Theory]
    [InlineData( "Иван", "100", "1.2", Sex.Male)]
    [InlineData( "Пётр", "1", "0.2", Sex.Male)]
    [InlineData( "Дмитрий", "1000", "1.6", Sex.Male)]
    [InlineData( "Анна", "123", "2", Sex.Female)]
    public void CreateSuccess(string name, string baseSalaryPerDayStr, string comissionStr, Sex sex)
    {
        // Arrange
        var baseSalaryPerDay = Convert.ToDecimal(baseSalaryPerDayStr, NumberFormatInfo.InvariantInfo);
        var comission = Convert.ToDecimal(comissionStr, NumberFormatInfo.InvariantInfo);
        
        // Act
        var worker = new ComissionWorker(name, baseSalaryPerDay, comission, sex);
        
        // Assert
        // Проверяем, что все поля инициализировались корректно
        Assert.Equal(name, worker.Name);
        Assert.Equal(baseSalaryPerDay, worker.BaseSalaryPerDay);
        Assert.Equal(comission, worker.Comission);
        Assert.Equal(sex, worker.Sex);
        // Работник не работал, поэтому все должно быть равно 0
        Assert.Equal(0, worker.SoldPrice);
        Assert.Equal(0, worker.DaysWorked);
    }
}