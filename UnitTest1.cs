using Xunit;
using MyPowerLib;

namespace MyPowerLibTest
{

public class UnitTest1
{
    [Fact]
	public void TestPowerOf2() {
	
		double a = 2; double b = 2;// arrange
		double expected = 4;
	
		double actual = MyPowerLib.Power.MyPowerOf2(a, b); // act
 
		Assert.Equal(expected, actual); // assert
	}	
	[Fact]
    public void TestPowerOf3() {
    
		double a = 3; double b = 2; double b = 2;// arrange
		double expected = 81;
	
		double actual = MyPowerLib.Power.MyPowerOf3(a, MyPowerLib.PowerPower(b, c)); // act

		Assert.Equal(expected, actual); // assert
	} 
}
}