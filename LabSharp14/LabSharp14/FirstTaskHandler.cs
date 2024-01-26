namespace LabSharp14;

public class FirstTaskHandler
{
    private string[] months =
        ["January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"];

    public void Handle(int n)
    {
        var summerOrWinterMonths = GetSummerOrWinterMonths(months);
        var nLengthMonths = GetNLengthMonths(months, n);
        var monthsAlphabetically = GetMonthsAlphabetically(months);
        var countOfMonths = GetCountOfMonths(months);
        var monthsWithUAndLongerThanFourLetters = GetMonthsWithUAndLongerThanFourLetters(months);
    }
    private string[] GetSummerOrWinterMonths(string[] months)
    {
        return months.Where(x => x == "June" || x == "July" || x == "August" || x == "December" || x == "January" || x == "February")
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

    private int GetCountOfMonths(string[] months)
    {
        return months.Count();
    }

    private string[] GetMonthsWithUAndLongerThanFourLetters(string[] months)
    {
        return months.Where(x => x.Contains("u", StringComparison.InvariantCultureIgnoreCase) && x.Length > 4).ToArray();
    }
}