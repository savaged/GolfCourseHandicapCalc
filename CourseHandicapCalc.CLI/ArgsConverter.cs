namespace CourseHandicapCalc.CLI;

public static class ArgsConverter
{
    public static double ToDouble(string? arg)
    {
        return double.TryParse(arg, out var value) ? value : 0;
    }

    public static int ToInt(string? arg)
    {
        return (int)ToDouble(arg);
    }
}