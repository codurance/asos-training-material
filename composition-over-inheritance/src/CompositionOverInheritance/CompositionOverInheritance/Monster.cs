namespace CompositionOverInheritance;

public abstract class Monster
{
    private readonly int bitingDamage;
    private readonly int kickingDamage;

    protected Monster(int bitingDamage, int kickingDamage)
    {
        this.bitingDamage = bitingDamage;
        this.kickingDamage = kickingDamage;
    }

    public int Attack() => bitingDamage + kickingDamage;
}
