using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;
using LabSharp13.Entities;

namespace LabSharp13;

public static class TaskFourHandler
{
    public static void Handle()
    {
        AppUtils.WriteDivider();
        var observableList = new ObservableCollection<Worker>();
        observableList.CollectionChanged += (sender, args) =>
        {
            Console.WriteLine($"Коллекция изменилась. Событие: {GetEventName(args.Action)}");
            switch (args.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    Console.WriteLine($"Добавлен элемент: {args.NewItems![0]}");
                    break;
                case NotifyCollectionChangedAction.Remove:
                    Console.WriteLine($"Удален элемент: {args.OldItems![0]}");
                    break;
                case NotifyCollectionChangedAction.Replace:
                    Console.WriteLine($"Заменен элемент: {args.OldItems![0]} на {args.NewItems![0]}");
                    break;
                case NotifyCollectionChangedAction.Move:
                    Console.WriteLine($"Перемещен элемент: {args.OldItems![0]}");
                    break;
                case NotifyCollectionChangedAction.Reset:
                    Console.WriteLine("Коллекция очищена");
                    break;
                default:
                    throw new UnreachableException();
            }
            AppUtils.WriteDivider();
        };
        
        // Добавляем элементы
        observableList.Add(new HourlyWorker(8, "Александр", 14.0m, 0.2m, Sex.Male));
        observableList.Add(new CommissionWorker("Татьяна", 2000m, 0.15m, Sex.Female));
        observableList.Add(new HourlyWorker(6, "Дмитрий", 15.2m, 0.18m, Sex.Male));
        observableList.Add(new CommissionWorker("Ольга", 2200m, 0.2m, Sex.Female));
        
        // Удаляем элементы
        observableList.RemoveAt(0);
        observableList.RemoveAt(0);
        
        // Заменяем элементы
        observableList[0] = new CommissionWorker("Марина", 2100m, 0.18m, Sex.Female);
        
        // Перемещаем элементы
        observableList.Move(0, 1);
        
        // Очищаем коллекцию
        observableList.Clear();
    }
    
    public static string GetEventName(NotifyCollectionChangedAction action)
    {
        return action switch
        {
            NotifyCollectionChangedAction.Add => "Добавление",
            NotifyCollectionChangedAction.Remove => "Удаление",
            NotifyCollectionChangedAction.Replace => "Замена",
            NotifyCollectionChangedAction.Move => "Перемещение",
            NotifyCollectionChangedAction.Reset => "Сброс",
            _ => throw new ArgumentOutOfRangeException(nameof(action), action, null)
        };
    }
}