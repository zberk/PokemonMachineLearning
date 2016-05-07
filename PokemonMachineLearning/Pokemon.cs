using System.Collections.Generic;

namespace PokemonMachineLearning
{
    public abstract class Pokemon : IPokemon
    {
        public abstract string Name { get; }
        public abstract int Level { get; set; }
        public abstract int XP { get; set; }
        public abstract string ID { get; }
        public abstract List<IStatus> Statuses { get; }
        public abstract int Attack { get; set; }
        public abstract int Defense { get; set; }
        public abstract int Speed { get; set; }
        public abstract int SpecialAttack { get; set; }
        public abstract int SpecialDefense { get; set; }
        public abstract List<Move> Moves { get; }
        public abstract void OnTurnStart();
        public abstract void OnTurnEnd();
        public abstract void OnAttack();
        public abstract void OnDefend();
        public abstract void OnSwitch();
        public abstract void OnEnter();
        public virtual void OnBattleEnd()
        {
            // Clear volatile statuses
            Statuses.RemoveAll(s => !(s is IVolatileStatus));
        }
    }

    public interface IPokemon
    {
        string Name { get; }
        int Level { get; set; }
        int XP { get; set; }
        string ID { get; }
        List<IStatus> Statuses { get; }
        int Attack { get; set; }
        int Defense { get; set; }
        int Speed { get; set; }
        int SpecialAttack { get; set; }
        int SpecialDefense { get; set; }
        List<Move> Moves { get; }
        void OnTurnStart();
        void OnTurnEnd();
        void OnAttack();
        void OnDefend();
        void OnSwitch();
        void OnEnter();
        void OnBattleEnd();
    }
}
