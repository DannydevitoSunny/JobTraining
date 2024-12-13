using Xunit.Abstractions;

namespace JobTrainingTests;

public class UnitTest1
{
    private readonly ITestOutputHelper output;
    public UnitTest1(ITestOutputHelper output){
        this.output = output;
    }


    [Fact]
    public void Test1()
    {
        output.WriteLine("Test run correctly");
        // ARRANGE
        MyProgramDTO myobj = new MyProgramDTO();
        myobj.number1 = 33;
        myobj.number2 = 42;
        decimal expected = 75;
        Utils utilsTool = new Utils();

        // EXECUTE
        var result = utilsTool.sum((decimal)myobj.number1, (decimal)myobj.number2);

        // VALIDATE
        Assert.Equal(expected, result);
    }
}