using System.Globalization;
using LabSharp11.Entities;

namespace LabSharp11.Test;

public class HourlyWorkerTests
{
    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    public void CreateFails_InvalidStandardWorkHoursPerDay(int standardWorkHoursPerDay)
    {
        var exception = Assert.Throws<ArgumentException>(() =>
        {
            _ = new HourlyWorker(standardWorkHoursPerDay, "Иван", 100, 1.2m, Sex.Male);
        });
        Assert.Equal(nameof(HourlyWorker.StandardWorkHoursPerDay), exception.ParamName);
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(0)]
    public void CreateFails_InvalidSalaryPerHour(decimal salaryPerHour)
    {
        var exception = Assert.Throws<ArgumentException>(() =>
        {
            _ = new HourlyWorker(8, "Иван", salaryPerHour, 1.2m, Sex.Male);
        });
        Assert.Equal(nameof(HourlyWorker.SalaryPerHour), exception.ParamName);
    }
    
    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    public void CreateFails_InvalidOvertimeMultiplier(decimal overtimeMultiplier)
    {
        var exception = Assert.Throws<ArgumentException>(() =>
        {
            _ = new HourlyWorker(8, "Иван", 100, overtimeMultiplier, Sex.Male);
        });
        Assert.Equal(nameof(HourlyWorker.OvertimeMultiplier), exception.ParamName);
    }

    [Theory]
    [InlineData(8, "Иван", "100", "1.2", Sex.Male)]
    [InlineData(2, "Пётр", "1", "0.2", Sex.Male)]
    [InlineData(3, "Дмитрий", "1000", "1.6", Sex.Male)]
    [InlineData(10, "Анна", "123", "2", Sex.Female)]
    public void CreateSuccess(int standardWorkHoursPerDay, string name, string salaryPerHourStr, string overtimeMultiplierStr, Sex sex)
    {
        // Arrange
        var salaryPerHour = Convert.ToDecimal(salaryPerHourStr, NumberFormatInfo.InvariantInfo);
        var overtimeMultiplier = Convert.ToDecimal(overtimeMultiplierStr, NumberFormatInfo.InvariantInfo);
        
        // Act
        var worker = new HourlyWorker(standardWorkHoursPerDay, name, salaryPerHour, overtimeMultiplier, sex);
        
        // Assert
        // Проверяем, что все поля инициализировались корректно
        Assert.Equal(standardWorkHoursPerDay, worker.StandardWorkHoursPerDay);
        Assert.Equal(name, worker.Name);
        Assert.Equal(salaryPerHour, worker.SalaryPerHour);
        Assert.Equal(sex, worker.Sex);
        Assert.Equal(overtimeMultiplier, worker.OvertimeMultiplier);
        // Работник не работал, поэтому все должно быть равно 0
        Assert.Equal(0, worker.WorkedHours);
        Assert.Equal(0, worker.DaysWorked);
    }
}