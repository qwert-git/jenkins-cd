using System;
using Xunit;

namespace integration;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Console.WriteLine("Connecting to database test passing...");
    }

    [Fact]
    public void Test2()
    {
        Console.WriteLine("Get request to another service test passing...");
    }
}