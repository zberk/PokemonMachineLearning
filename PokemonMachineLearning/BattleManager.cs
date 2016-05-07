using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonMachineLearning
{
    public static class BattleManager
    {
        public static void Attack(Pokemon attacker, Pokemon defender)
        {
            attacker.OnAttack();
            defender.OnDefend();
        }
    }
}
