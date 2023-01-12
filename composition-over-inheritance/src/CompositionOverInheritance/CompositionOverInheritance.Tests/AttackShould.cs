namespace CompositionOverInheritance.Tests;

public class AttackShould
{
    [Fact(DisplayName = "do 30 damage for a biting monster")]
    public void Test1()
    {
        IMonster biter = new BitingMonster(30);
        Assert.Equal(30, biter.Attack());
    }
}
