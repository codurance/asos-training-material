namespace CompositionOverInheritance;

public class BitingMonster : IMonster
{
    public BitingMonster(int damage)
    {
    }

    public int Attack()
    {
        return 30;
    }
}
