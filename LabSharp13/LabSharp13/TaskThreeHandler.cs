using System.Collections;
using LabSharp13.Entities;

namespace LabSharp13;

public static class TaskThreeHandler
{
    public static void Handle()
    {
        // A
        AppUtils.WriteDivider();
        var list = new LinkedList<Worker>();
        list.AddLast(new HourlyWorker(1, "Игорь", 12.3m, 0.2m, Sex.Male));
        list.AddLast(new CommissionWorker( "Антон", 12.3m, 0.2m, Sex.Male));
        list.AddLast(new HourlyWorker(8, "Александр", 14.0m, 0.2m, Sex.Male));
        list.AddLast(new CommissionWorker("Марина", 2100m, 0.18m, Sex.Female));
        
        PrintCollection(list);

        // B
        AppUtils.WriteDivider();
        Console.WriteLine("Введите количество элементов для удаления");
        if (!int.TryParse(Console.ReadLine(), out var count))
        {
            Console.WriteLine("Неверный формат количества элементов. Используется значение по умолчанию: 1");
        }
        Console.WriteLine($"Удаление {count} элементов");
        for (var i = 0; i < count; i++)
        {
            list.RemoveFirst();
        }
        
        // C
        AppUtils.WriteDivider();
        Console.WriteLine("Добавляем 4 элемента");
        list.AddLast(new HourlyWorker(7, "Елена", 13.5m, 0.25m, Sex.Female));
        list.AddFirst(new HourlyWorker(6, "Дмитрий", 15.2m, 0.18m, Sex.Male));
        list.AddAfter(list.First!,new HourlyWorker(8, "Анна", 14.5m, 0.22m, Sex.Female));
        list.AddBefore(list.Last!, new HourlyWorker(7, "Павел", 13.8m, 0.23m, Sex.Male));
        
        PrintCollection(list);
        
        // D
        AppUtils.WriteDivider();
        var dict = new Dictionary<int, Worker>();
        using (var listEnumerator = list.GetEnumerator())
        {
            for (int i = 0; i < list.Count; i++)
            {
                listEnumerator.MoveNext();
                dict.Add(i, listEnumerator.Current);
            }    
        }
        
        // E
        AppUtils.WriteDivider();
        PrintCollection(dict);
        
        // F
        AppUtils.WriteDivider();
        Console.WriteLine("Поиск элемента по ключу");
        Console.WriteLine("Введите ключ");
        if (!int.TryParse(Console.ReadLine(), out var key))
        {
            Console.WriteLine("Неверный формат ключа. Используется значение по умолчанию: 0");
        }
        if (dict.ContainsKey(key))
        {
            Console.WriteLine($"Элемент найден: {dict[key]}");
        }
        else
        {
            Console.WriteLine("Элемент не найден");
        }
        
    }
    
    private static void PrintCollection(IEnumerable collection)
    {
        var index = 0;
        foreach (var item in collection)
        {
            Console.WriteLine($"{index++}: {item}");
        }
    }
}