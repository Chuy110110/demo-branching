namespace TestProject1;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.True(true);
    }
    
    [Fact]
    public void Test2()
    {
        Assert.False(!true);
        Assert.Empty("");
        //  This was stupid
        Assert.True(!false);
    }
}
