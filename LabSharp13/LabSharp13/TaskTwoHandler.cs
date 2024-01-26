using System.Collections;

namespace LabSharp13;

public static class TaskTwoHandler
{
    public static void Handle()
    {
        var list = new LinkedList<bool>();
        var rand = new Random();
        for (var i = 0; i < 10; i++)
        {
            list.AddLast(rand.Next(0, 100) % 2 == 0);
        }
        
        // A
        AppUtils.WriteDivider();
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
        PrintCollection(list);
        
        // C
        AppUtils.WriteDivider();
        Console.WriteLine("Добавляем 10 элементов");
        for (var i = 0; i < 4; i++)
        {
            list.AddLast(rand.Next(0, 100) % 2 == 0);
        }
        for (var i = 0; i < 4; i++)
        {
            list.AddFirst(rand.Next(0, 100) % 2 == 0);
        }
        list.AddBefore(list.Last!, rand.Next(0, 100) % 2 == 0);
        list.AddAfter(list.First!, rand.Next(0, 100) % 2 == 0);

        PrintCollection(list);
        
        // D
        AppUtils.WriteDivider();
        var dict = new Dictionary<int, bool>();
        using (var listEnumerator = list.GetEnumerator())
        {
            for (int i = 0; i < list.Count; i++)
            {
                dict.Add(i, listEnumerator.Current);
                listEnumerator.MoveNext();
            }    
        }
        
        // E
        AppUtils.WriteDivider();
        PrintCollection(dict);
        
        // F
        AppUtils.WriteDivider();
        Console.WriteLine("Введите ключ для поиска");
        if (!int.TryParse(Console.ReadLine(), out var key))
        {
            Console.WriteLine("Неверный формат ключа. Используется значение по умолчанию: 0");
        }
        
        if (!dict.TryGetValue(key, out var value))
        {
            Console.WriteLine($"Элемент с ключом {key} не найден");
        }
        else
        {
            Console.WriteLine($"Элемент найден: [{key}, {value}]");
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