using System.Text.Json.Serialization;

namespace LabSharp11.Entities;

[JsonPolymorphic(UnknownDerivedTypeHandling = JsonUnknownDerivedTypeHandling.FailSerialization)]
[JsonDerivedType(typeof(HourlyWorker), typeDiscriminator: nameof(HourlyWorker))]
[JsonDerivedType(typeof(ComissionWorker), typeDiscriminator: nameof(ComissionWorker))]
public abstract class Worker
{
    public string Name { get; set; }
    public Sex Sex { get; set; }

    protected Worker(string name, Sex sex)
    {
        Name = name;
        Sex = sex;
    }

    
    public abstract decimal Payoff();
    
    public abstract string GetInfo();

    public abstract decimal CalculateSalary();

}