namespace CompositionOverInheritance.Tests;

public class AttackShould
{
    [Fact(DisplayName = "do 30 damage for a biting monster")]
    public void Test1()
    {
        IAttack bite = new Bite();
        Monster biter = new Monster(bite);
        Assert.Equal(30, biter.Attack());
    }

    [Fact(DisplayName = "do 45 damage for a kicking monster")]
    public void Test2()
    {
        IAttack kick = new Kick();
        Monster kicker = new Monster(kick);
        Assert.Equal(45, kicker.Attack());
    }

    [Fact(DisplayName = "do 75 damage for a monster that bites and kicks")]
    public void Test3()
    {
        IAttack bite = new Bite();
        IAttack kick = new Kick();
        Monster kickerAndBiter = new Monster(bite, kick);
        Assert.Equal(75, kickerAndBiter.Attack());
    }
}
