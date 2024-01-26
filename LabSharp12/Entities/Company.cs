using LabSharp12.Utils;
using System.Text.Json.Serialization;

namespace LabSharp11.Entities;

public class Company 
{
    public string Name { get; set; }
    
    [JsonInclude] 
    private List<Worker> _workers;
    
    [JsonIgnore]
    public IReadOnlyCollection<Worker> Workers => _workers.AsReadOnly();

    public Company(string name)
    {
        Name = name;
        _workers = new List<Worker>();
    }
    
    public void HireWorker(Worker worker)
    {
        _workers.Add(worker);
    }

    public void FireWorker(Worker worker)
    {
        Log.WriteLine($"Работник {Name} уволен");
        PayoffWorker(worker);
        _workers.Remove(worker);
    }

    public void PayoffAllWorkers()
    {
        foreach (var worker in _workers)
        {
            PayoffWorker(worker);
        }
    }

    private void PayoffWorker(Worker worker)
    {
        Log.WriteLine(worker.GetInfo());
        var workerSalary = worker.Payoff();
        Log.WriteLine($"Работнику было выплачено ${workerSalary} руб.");
    }
}