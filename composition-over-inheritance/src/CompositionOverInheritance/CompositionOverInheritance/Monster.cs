using CompositionOverInheritance.Tests;

namespace CompositionOverInheritance;

public class Monster
{
    private readonly IAttack[] attacks;

    public Monster(params IAttack[] attacks) =>
        this.attacks = attacks;

    public int Attack() =>
        attacks.Aggregate(0, (acc, atk) => acc + atk.Attack());
}
