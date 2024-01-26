using System.Text.Json.Serialization;

namespace LabSharp13.Entities;

[JsonPolymorphic(UnknownDerivedTypeHandling = JsonUnknownDerivedTypeHandling.FailSerialization)]
[JsonDerivedType(typeof(HourlyWorker), typeDiscriminator: nameof(HourlyWorker))]
[JsonDerivedType(typeof(CommissionWorker), typeDiscriminator: nameof(CommissionWorker))]
public abstract class Worker : IComparable<Worker>, ICloneable
{
    public string Name { get; set; }
    public Sex Sex { get; set; }
    public int DaysWorked { get; protected set; } = 0;
    
    protected Worker(string name, Sex sex)
    {
        Name = name;
        Sex = sex;
    }

    
    public abstract decimal Payoff();
    
    public abstract string GetInfo();

    public abstract decimal CalculateSalary();

    public int CompareTo(Worker? other)
    {
        if (other == null)
        {
            return 1;
        }
        
        return CalculateSalary().CompareTo(other.CalculateSalary()); // Сортируем по зарплате
    }

    public abstract object Clone();
    
}