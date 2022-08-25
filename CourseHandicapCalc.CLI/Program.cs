using CourseHandicapCalc.CLI;
using CourseHandicapCalc.Lib;

Console.WriteLine(CalcService.Calculate(
    ArgsConverter.ToDouble(args[0]), 
    ArgsConverter.ToDouble(args[1]),
    ArgsConverter.ToInt(args[2]),
    ArgsConverter.ToInt(args[3])));