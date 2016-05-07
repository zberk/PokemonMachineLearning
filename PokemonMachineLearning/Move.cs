using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonMachineLearning
{
    public abstract class Move
    {
        public abstract string Name { get; }
        public abstract Types Type { get; }
        public abstract int Power { get; }
        public abstract int Accuracy { get; }
        public abstract int PP { get; }
        public abstract Categories Category { get; }
        public abstract bool MakesContact { get; }
        public abstract bool AffectedByProtect { get; }
        public abstract bool AffectedByMagicCoat { get; }
        public abstract bool AffectedBySnatch { get; }
        public abstract bool AffectedByMirrorMove { get; }
        public abstract bool AffectedByKingsRock { get; }
        public abstract Statuses.PermanentStatus NonVolatileStatus { get; set; }
        public abstract Statuses.TemporaryStatus VolatileStatuses { get ; }
        public abstract Statuses.BattleStatus BattleStatuses { get; }
        public abstract void OnUse();
    }

    public enum Categories
    {
        Physical,
        Special
    }
}
