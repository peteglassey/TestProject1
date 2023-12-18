using System;
using FluentAssertions;
using Gauge.CSharp.Lib.Attribute;
using TestProject1;

namespace netcore.template;

public class CalculatorStepImplementation
{
    [Step("<1>+ <1> = <2>")]
    public void Add(double arg0 ,double arg1 ,double arg2)
    {
        new Calculator().Add(arg0, arg1).Should().Be(arg2);
    }

    [Step("<1> - <1> = <0>")]
    public void Subtract(double arg0 ,double arg1 ,double arg2)
    {
        new Calculator().Subtract(arg0, arg1).Should().Be(arg2);
    }

    [Step("<1> * <1> = <1>")]
    public void Multiply(double arg0 ,double arg1 ,double arg2)
    {
        new Calculator().Multiply(arg0, arg1).Should().Be(arg2);
    }

    [Step("<1> / <1> = <1>")]
    public void Divide(double arg0 ,double arg1 ,double arg2)
    {
        new Calculator().Divide(arg0, arg1).Should().Be(arg2);
    }

}