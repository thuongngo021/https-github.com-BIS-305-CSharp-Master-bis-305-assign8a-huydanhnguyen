using Xunit;
using System.IO;
using System;
using System.Text;

public class TestAssign8A10_2PhotoDemo
{

    [Fact]
    public void TestCase()
    {
        //Sets the Out property to target the TextWriter object. Note that the System.IO.StringWriter is 
        //derived from TextWriter. The TextWriter class is an abstract class. Therefore, you do not 
        //instantiate it in your code.
        //The StreamWriter class derives from TextWriter and provides implementations of the members for 
        //writing to a stream. 
        var output = new StringWriter();
        Console.SetOut(output);
        
        PhotoDemo.Main();

        //use a string writer to format the expected outcome
        var expectedOutcome = new StringBuilder();
        expectedOutcome.AppendLine("Photo    8 X 10   Price: $3.99");
        expectedOutcome.AppendLine("Photo    8 X 9   Price: $9.99");
        expectedOutcome.AppendLine("MattedPhoto    white matting 10 X 12   Price: $15.99");
        expectedOutcome.AppendLine("FramedPhoto    modern, silver frame. 8 X 10   Price: $28.99");

        Assert.Equal(expectedOutcome.ToString(), output.ToString());

        //clean up
        output.Dispose();
    }
}
