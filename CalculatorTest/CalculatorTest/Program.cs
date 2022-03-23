// See https://aka.ms/new-console-template for more information

//Fact lets your IDE know that this is a test. Then click the light bulb under Fact and click use "Xunit".
//Xunit also displays "using Xunit


 void TestSum()
{
    var calc = new Calculator();

    var sum = calc.CalcSum(15, 20);

    Assert.Equal(35, sum);
}

