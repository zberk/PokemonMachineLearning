using System.Collections.Generic;

namespace PokemonMachineLearning
{
    #region Core Statuses

    /// <summary>
    /// Basic interface that all statuses must inherit from.
    /// </summary>
    public interface IStatus
    {
        void OnTurnStart();
        void OnTurnEnd();
        void OnAttack();
        void OnDefend();
        void OnSwitch();
        void OnEnter();
        void OnBattleEnd();
        void ClearStatus();
    }

    /// <summary>
    /// Statuses which persist after the battle
    /// </summary>
    public interface INonVolatileStatus : IStatus
    {
        Statuses.PermanentStatus Status { get; }
    }

    /// <summary>
    /// Statuses which do not persist between battles
    /// </summary>
    public interface IVolatileStatus : IStatus
    {
        Statuses.TemporaryStatus Status { get; }
    }

    /// <summary>
    /// Statuses that are generally helpful.
    /// </summary>
    public interface IBattleStatus : IStatus
    {
        Statuses.BattleStatus Status { get; }
    }

    #endregion

    #region Common Interfaces

    /// <summary>
    /// Interface used for statuses that effect HP over time.
    /// </summary>
    public interface IOverTime
    {
        double HPRate { get; set; }
        bool IsAppliedAtEnd { get; }
    }

    /// <summary>
    /// Interface for statuses that can recover on their own.
    /// </summary>
    public interface IRecoverable
    {
        double RecoverRate { get; }
        void Recover();
    }

    /// <summary>
    /// Interface for statuses that are limited to a turn range.
    /// </summary>
    public interface ITurnBased
    {
        int MinTurns { get; set; }
        int MaxTurns { get; set; }
    }

    /// <summary>
    /// Interface for statuses that may override an immunity 
    /// or may be prevented by an immunity.
    /// </summary>
    public interface IImmunity
    {
        List<Types> ImmuneTypes { get; }
        List<Types> OverriddenImmuneTypes { get; }
        List<IStatus> ImmuneStatuses { get; }
    }

    /// <summary>
    /// Interface for statuses that will cause inaction.
    /// </summary>
    public interface IWaiting
    {
        bool CannotAct { get; }
    }

    /// <summary>
    /// Interface for statuses which may be able to override inaction.
    /// </summary>
    public interface ISkipWaiting : IWaiting
    {
        bool OverrideApplies();
        void AdditonalEffect();
    }

    public static class HealthRates
    {
        public const double ONE_SIXTEENTH = 1 / 16;
        public const double ONE_EIGTH = 1 / 8;
        public const double ONE_SIXTH = 1 / 6;
        public const double ONE_QUARTER = 1 / 4;
    }

    #endregion

}
