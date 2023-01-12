namespace CompositionOverInheritance.Tests;

public class AttackShould
{
    [Fact(DisplayName = "do 10 damage for a biting monster")]
    public void Test1()
    {
        var biter = new BitingMonster(30);
        Assert.Equal(30, biter.Attack());
    }
}
