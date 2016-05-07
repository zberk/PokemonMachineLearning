using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonMachineLearning
{
    public class Statuses
    {
        public enum PermanentStatus
        {
            NONE,
            BURNED,
            FROZEN,
            PARALYZED,
            POISONED,
            BAD_POISONED,
            ASLEEP
        }

        public enum TemporaryStatus
        {
            NONE,
            CONFUSION,
            CURSED,
            EMBARGO,
            ENCORE,
            FLINCH,
            HEAL_BLOCK,
            IDENTIFIED,
            INFATUATED,
            NIGHTMARE,
            PARTIAL_TRAPPED,
            PERISH_SONG,
            SEEDED,
            TAUNTED,
            TELE_LEVITATED,
            TORMENTED,
            TRAPPED
        }

        public enum BattleStatus
        {
            NONE,
            AQUA_RING,
            BRACING,
            ATTENTION,
            CURLED,
            ROUTING,
            REFLECTING,
            MAG_LEVITATED,
            MINIMIZED,
            PROTECTED,
            RECHARGING,
            INVULNERABLE,
            SUBSTITUTED,
            TAKING_AIM,
            PREPARING
        }

        public class BurnStatus : INonVolatileStatus, IOverTime, IImmunity
        {
            #region IOverTime Members

            public double HPRate
            {
                get
                {
                    return HealthRates.ONE_EIGTH;
                }
                
                set { } // Damage never changes
            }

            public bool IsAppliedAtEnd
            {
                get
                {
                    return true;
                }
            }

            #endregion

            #region IImmunity Members

            public List<IStatus> ImmuneStatuses
            {
                get
                {
                    return new List<IStatus>();
                }
            }

            public List<Types> ImmuneTypes
            {
                get
                {
                    return new List<Types>() { Types.FIRE };
                }
            }

            public List<Types> OverriddenImmuneTypes
            {
                get
                {
                    return new List<Types>();
                }
            }

            #endregion

            #region IStatus Members

            public PermanentStatus Status
            {
                get
                {
                    return PermanentStatus.BURNED;
                }
            }

            public void OnTurnStart()
            {
                throw new NotImplementedException();
            }

            public void OnTurnEnd()
            {
                throw new NotImplementedException();
            }

            public void OnAttack()
            {
                throw new NotImplementedException();
            }

            public void OnDefend()
            {
                throw new NotImplementedException();
            }

            public void OnSwitch()
            {
                throw new NotImplementedException();
            }

            public void OnEnter()
            {
                throw new NotImplementedException();
            }

            public void OnBattleEnd()
            {
                throw new NotImplementedException();
            }

            public void ClearStatus()
            {
                throw new NotImplementedException();
            }

            #endregion

        }
    }
}
