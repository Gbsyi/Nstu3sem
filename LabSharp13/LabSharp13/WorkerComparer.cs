using LabSharp13.Entities;

namespace LabSharp13;

public class WorkerComparer : IComparer<Worker>
{
    public int Compare(Worker? x, Worker? y)
    {
        if (x == null || y == null)
        {
            return x == null && y == null ? 0 : x != null ? 1 : -1;
        }
        
        return x.CalculateSalary().CompareTo(y.CalculateSalary()); // Сортируем по зарплате
    }
}