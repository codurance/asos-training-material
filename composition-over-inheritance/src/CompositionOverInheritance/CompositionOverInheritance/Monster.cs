namespace CompositionOverInheritance;

public abstract class Monster
{
    private readonly int kickingDamage;
    private readonly int bitingDamage;

    protected Monster(int kickingDamage, int bitingDamage)
    {
        this.kickingDamage = kickingDamage;
        this.bitingDamage = bitingDamage;
    }

    public int Attack() => kickingDamage + bitingDamage;
}
