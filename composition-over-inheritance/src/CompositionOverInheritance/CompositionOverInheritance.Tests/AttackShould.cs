namespace CompositionOverInheritance.Tests;

public class AttackShould
{
    [Fact(DisplayName = "do 30 damage for a biting monster")]
    public void Test1()
    {
        Monster biter = new BitingMonster();
        Assert.Equal(30, biter.Attack());
    }

    [Fact(DisplayName = "do 45 damage for a kicking monster")]
    public void Test2()
    {
        Monster biter = new KickingMonster();
        Assert.Equal(45, biter.Attack());
    }
}
