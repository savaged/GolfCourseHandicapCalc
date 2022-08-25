using CourseHandicapCalc.CLI;
using CourseHandicapCalc.Lib;

namespace CourseHandicapCalc.Test;

public class CliTests
{
    [Fact]
    public void TestArgsConverter()
    {
        var args = new[] { "16.7", "70.1", "126", "68" };
        Assert.Equal(16.7, ArgsConverter.ToDouble(args[0]));
        Assert.Equal(70.1, ArgsConverter.ToDouble(args[1]));
        Assert.Equal(126, ArgsConverter.ToInt(args[2]));
        Assert.Equal(68, ArgsConverter.ToInt(args[3]));
    }
    
    [Fact]
    public void TestCalcService()
    {
        var args = new[] { "16.7", "70.1", "126", "68" };
        var result = CalcService.Calculate(
            ArgsConverter.ToDouble(args[0]),
            ArgsConverter.ToDouble(args[1]),
            ArgsConverter.ToInt(args[2]),
            ArgsConverter.ToInt(args[3]));
        Assert.Equal(21, result);
    }
}