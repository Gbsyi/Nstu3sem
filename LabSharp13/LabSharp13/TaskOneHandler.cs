using System.Collections;

namespace LabSharp13;

public static class TaskOneHandler
{
    public static void Handle()
    {
        var list = new ArrayList();
        var rand = new Random();
        for (var i = 0; i < 5; i++)
        {
            list.Add(rand.Next(0, 100));
        }
        
        list.Add("Hello");
        
        PrintList(list);

        AppUtils.WriteDivider();
        Console.WriteLine("Введите индекс для удаления");
        if (!int.TryParse(Console.ReadLine(), out var index))
        {
            Console.WriteLine("Неверный формат индекса. Используется значение по умолчанию: 0");
        }
        Console.WriteLine($"Удаление элемента по индексу {index}");
        list.RemoveAt(index);
        PrintList(list);
        
        AppUtils.WriteDivider();
        Console.WriteLine("Введите значение для поиска");
        var value = Console.ReadLine();
        Console.WriteLine($"Поиск элемента со значением {value}");

        string? searchValue = null;
        foreach (var item in list)
        {
            if (item.ToString() == value)
            {
                searchValue = item.ToString();
            }
        }

        if (searchValue is null)
        {
            Console.WriteLine("Элемент не найден");
        }
        else
        {
            Console.WriteLine($"Элемент найден: {searchValue}");
        }
        
        
    }
    
    private static void PrintList(ArrayList list)
    {
        Console.WriteLine($"{Environment.NewLine}Длина списка: {list.Count}. Элементы списка:");
        for (var index = 0; index < list.Count; index++)
        {
            var item = list[index];
            Console.WriteLine($"{index}: {item}");
        }

        Console.Write(Environment.NewLine);
    } 
}