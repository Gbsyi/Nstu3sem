using LabSharp11.Entities;
using LabSharp12.Utils;
using System.Xml.Linq;

namespace LabSharp11.Simulation;

public class WorkerSimulator
{
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
        var random = new Random();
        var soldPrice = random.Next(0, 100);
        comissionWorker.Sell(soldPrice);
    }

    private void SimulateHourlyWorkerDay(HourlyWorker worker)
    {
        var random = new Random();
        var workHours = random.Next(0, 10);
        worker.Work(workHours);
    }
}