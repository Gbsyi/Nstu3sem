using LabSharp11.Entities;

namespace LabSharp11.Simulation;

public interface IWorkerSimulator
{
    void SimulateDay(Worker worker, DateOnly date);
}

public class WorkerSimulator : IWorkerSimulator
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
        var soldAmount = random.Next(0, 100);
        comissionWorker.Sell(soldAmount);
    }

    private void SimulateHourlyWorkerDay(HourlyWorker worker)
    {
        var random = new Random();
        var workHours = random.Next(0, 10);
        worker.Work(workHours);
    }
}