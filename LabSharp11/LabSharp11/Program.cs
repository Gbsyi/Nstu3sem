using LabSharp11.Entities;
using LabSharp11.Simulation;
using LabSharp11.Store;
using LabSharp11.StoreWriters;

SimulationStore InitSimulationStore() {
    var company = new Company("ООО \"Рога и копыта\"");

    company.HireWorker(new HourlyWorker(8, "Вася", 2.1m, 2.0m, Sex.Male));
    company.HireWorker(new ComissionWorker("Оля", 20, 0.1m, Sex.Female));
    company.HireWorker(new HourlyWorker(8, "Олег", 1.1m, 1.0m, Sex.Male));
    company.HireWorker(new HourlyWorker(8, "Дима", 2m, 1.3m, Sex.Male));

    
    var today = new DateOnly(2021, 1, 1);
    return new SimulationStore
    {
        Company = company,
        Today = today
    };
}

// Start
var storeWriter = new JsonStoreWriter("company.json");
var store = storeWriter.Restore() ?? InitSimulationStore();

var company = store.Company;
var today = store.Today;

ICompanySimulator simulator = new CompanySimulator(new WorkerSimulator());

var workingDays = 40;
simulator.Simulate(company, today, workingDays);

store.Today = today.AddDays(workingDays);

storeWriter.Save(store);
