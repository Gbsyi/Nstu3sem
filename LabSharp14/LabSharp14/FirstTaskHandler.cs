
namespace LabSharp14;

public class FirstTaskHandler
{
    private readonly string[] months =
        ["January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"];

    public void Handle(int n)
    {
        
        var summerOrWinterMonths = GetSummerOrWinterMonths(months);
        Console.WriteLine("Летние и зимние месяцы: " + string.Join(", ", summerOrWinterMonths));
        
        AppUtils.WriteDivider();
        var nLengthMonths = GetNLengthMonths(months, n);
        Console.WriteLine($"Месяцы с длиной строки {n}: " + string.Join(", ", nLengthMonths));
        
        AppUtils.WriteDivider();
        var monthsAlphabetically = GetMonthsAlphabetically(months);
        Console.WriteLine("Месяцы в алфавитном порядке: " + string.Join(", ", monthsAlphabetically));
        
        AppUtils.WriteDivider();
        var monthsWithUAndLongerThanFourLetters = GetMonthsCountWithUAndLongerThanFourLetters(months);
        Console.WriteLine($"Месяцев с буквой 'u' и длиной строки больше 4: {monthsWithUAndLongerThanFourLetters}");
    }
    private string[] GetSummerOrWinterMonths(string[] months)
    {
        return months
            .Where(x => x is "June" or "July" or "August" or "December" or "January" or "February")
            .ToArray();
    }

    private string[] GetNLengthMonths(string[] months, int stringLength)
    {
        return months.Where(x => x.Length == stringLength).ToArray();
    }

    private string[] GetMonthsAlphabetically(string[] months)
    {
        return months.OrderBy(x => x).ToArray();
    }

    private int GetMonthsCountWithUAndLongerThanFourLetters(string[] months)
    {
        return months
            .Where(x => x.Contains("u", StringComparison.InvariantCultureIgnoreCase) && x.Length >= 4)
            .Count();
    }
}