using System.Globalization;
using LabSharp14;

var firstTaskHandler = new FirstTaskHandler();
firstTaskHandler.Handle(4);


var secondTaskHandler = new SecondTaskHandler();
// Заполнение списка рейсов
var list = new List<Aerocompany>()
{
    new("Москва", 1, new DateTime(2021, 1, 1, 12, 0, 0, DateTimeKind.Utc)),
    new("Нью-Йорк", 2, new DateTime(2021, 1, 2, 14, 30, 0, DateTimeKind.Utc)),
    new("Париж", 3, new DateTime(2021, 1, 3, 10, 45, 0, DateTimeKind.Utc)),
    new("Токио", 4, new DateTime(2021, 1, 4, 16, 20, 0, DateTimeKind.Utc)),
    new("Лондон", 5, new DateTime(2021, 1, 5, 8, 15, 0, DateTimeKind.Utc)),
    new("Берлин", 6, new DateTime(2021, 1, 6, 19, 0, 0, DateTimeKind.Utc)),
    new("Сидней", 7, new DateTime(2021, 1, 7, 21, 45, 0, DateTimeKind.Utc)),
    new("Дубай", 8, new DateTime(2021, 1, 8, 23, 30, 0, DateTimeKind.Utc)),
    new("Пекин", 9, new DateTime(2021, 1, 9, 5, 10, 0, DateTimeKind.Utc)),
    new("Торонто", 10, new DateTime(2021, 1, 10, 15, 25, 0, DateTimeKind.Utc)),
    new("Рим", 11, new DateTime(2021, 1, 11, 11, 55, 0, DateTimeKind.Utc)),
    new("Стамбул", 12, new DateTime(2021, 1, 12, 18, 40, 0, DateTimeKind.Utc)),
    new("Мумбаи", 13, new DateTime(2021, 1, 13, 3, 30, 0, DateTimeKind.Utc)),
    new("Сеул", 14, new DateTime(2021, 1, 14, 7, 20, 0, DateTimeKind.Utc)),
    new("Лос-Анджелес", 15, new DateTime(2021, 1, 15, 22, 10, 0, DateTimeKind.Utc))
};
secondTaskHandler.Handle(list);