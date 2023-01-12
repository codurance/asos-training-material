namespace CompositionOverInheritance;

public abstract class Monster
{
    private readonly int damage;

    protected Monster(int damage) =>
        this.damage = damage;

    public int Attack() => damage;
}
