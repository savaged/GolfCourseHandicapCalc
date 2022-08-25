namespace CourseHandicapCalc.Lib;

public static class CalcService
{
    public static int Calculate(double individualHandicapIndex, double courseRating, int slopeRating, int par)
    {
        return (int)Math.Round(individualHandicapIndex * ((double)slopeRating / 113 + (courseRating - par)), 0);
    }
    
}