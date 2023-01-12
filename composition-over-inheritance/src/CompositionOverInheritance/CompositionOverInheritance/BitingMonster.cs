namespace CompositionOverInheritance;

public class BitingMonster : IMonster
{
    private readonly int damage;

    public BitingMonster(int damage) =>
        this.damage = damage;

    public int Attack() =>
        damage;
}
