
namespace Raiding.Models;

public abstract class Fighter : BaseHero
{
    public Fighter(string name) : base(name) { }

    public override string ToString()
    {
        return base.CastAbility() + $"hit for {this.Power} damage";
    }
}
