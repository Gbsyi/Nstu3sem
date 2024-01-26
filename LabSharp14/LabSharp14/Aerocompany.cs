namespace LabSharp14;

public class Aerocompany
{
    /// <summary>
    /// Пункт назначения
    /// </summary>
    public string Destination { get; set; }
    
    /// <summary>
    /// Номер рейса
    /// </summary>
    public int FlightNo { get; set; }
    
    /// <summary>
    /// Время вылета
    /// </summary>
    public DateTime FlightDate { get; set; }
    
    /// <summary>
    /// День недели вылета
    /// </summary>
    public DayOfWeek FlightDayOfWeek => FlightDate.DayOfWeek;

    public Aerocompany(string destination, int flightNo, DateTime flightDate)
    {
        Destination = destination;
        FlightNo = flightNo;
        FlightDate = flightDate;
    }


    public override string ToString()
    {
        return $"Полёт №{FlightNo} до {Destination}. Время вылета {FlightDate:dd.mm.yyyy HH:mm:ss zz, dddd}";
    }
}