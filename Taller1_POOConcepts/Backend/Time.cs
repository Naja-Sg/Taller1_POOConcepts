namespace Backend;

public class Time
{

    //Fields

    private int _hour;

    private int _minute;

    private int _second;

    private int _millisecond;

    //Constructors

    public Time()
    {
        Hour = 0;
        Minute = 0;
        Second = 0;
        Millisecond = 0;
    }

    public Time(int hour)
    {
        Hour = hour;
    }

    public Time(int hour, int minute)
    {
        Hour = hour;
        Minute = minute;
    }

    public Time(int hour, int minute, int second)
    {
        Hour = hour;
        Minute = minute;
        Second = second;
    }

    public Time(int hour, int minute, int second, int millisecond)
    {
        Hour = hour;
        Minute = minute;
        Second = second;
        Millisecond = millisecond;
    }

    //Properties

    public int Hour 
    { 
        get => _hour; 
        set => _hour = ValidHour(value); 
    }
    public int Millisecond 
    { 
        get => _millisecond; 
        set => _millisecond = ValidMillisecond(value); 
    }
    public int Minute 
    { 
        get => _minute; 
        set => _minute = ValidMinute(value); 
    }
    public int Second 
    { 
        get => _second; 
        set => _second = ValidSecond(value); 
    }

    //Public Methods
    public override string ToString()
    {
        if (Hour  < 12 && Hour >= 0) 
        {
        return $"{Hour}:{Minute}:{Second}:{Millisecond} AM";
        }
        else
        {
            return $"{Hour}:{Minute}:{Second}:{Millisecond} PM";
        }
    }

    public int ToMinutes()
    {
        try
        {
            ValidHour(Hour);
            ValidMinute(Minute);
            ValidSecond(Second);
            ValidMillisecond(Millisecond);

            return (Hour * 60) + Minute;

        }
        catch
        {
            return 0;
        }

    }

    public int ToSeconds()
    {
        try
        {
            ValidHour(Hour);
            ValidMinute(Minute);
            ValidSecond(Second);
            ValidMillisecond(Millisecond);

            return (Hour * 3600) + (Minute*60) + Second;

        }
        catch
        {
            return 0;
        }

    }

    public int ToMilliseconds()
    {
        try
        {
            ValidHour(Hour);
            ValidMinute(Minute);
            ValidSecond(Second);
            ValidMillisecond(Millisecond);

            return (Hour * 3600000) + (Minute * 60000) + (Second*1000) + Millisecond;

        }
        catch
        {
            return 0;
        }

    }


    //Private Methods

    private int ValidHour (int hour)
    {
        if (hour >= 0 && hour <= 23)
        {
            return hour;
        }

        throw new Exception($"The hour: {hour} is not valid.");
    }

    private int ValidMinute(int minute)
    {
        if (minute >= 0 && minute <= 59)
        {
            return minute;
        }

        throw new Exception($"The minute: {minute} is not valid.");

    }

    private int ValidSecond(int second)
    {
        if (second >= 0 && second <= 59)
        {
            return second;
        }

        throw new Exception($"The minute: {second} is not valid.");

    }

    private int ValidMillisecond(int millisecond)
    {
        if (millisecond >= 0 && millisecond <= 999)
        {
            return millisecond;
        }

        throw new Exception($"The minute: {millisecond} is not valid.");

    }


}
