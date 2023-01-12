namespace CompositionOverInheritance.Tests;

public class AttackShould
{
    [Fact(DisplayName = "do 30 damage for a biting monster")]
    public void Test1()
    {
        IAttack bite = new Bite();
        var biter = new Monster(bite);
        Assert.Equal(30, biter.Attack());
    }

    [Fact(DisplayName = "do 45 damage for a kicking monster")]
    public void Test2()
    {
        IAttack kick = new Kick();
        var biter = new Monster(kick);
        Assert.Equal(45, biter.Attack());
    }

    [Fact(DisplayName = "do 75 damage for a kicking and biting monster")]
    public void Test3()
    {
        IAttack bite = new Bite();
        IAttack kick = new Kick();
        var biter = new Monster(bite, kick);
        Assert.Equal(75, biter.Attack());
    }
}
