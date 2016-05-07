using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonMachineLearning
{
    public enum Types
    {
        NORMAL,
        FIRE,
        WATER,
        ELECTRIC,
        GRASS,
        ICE,
        FIGHTING,
        POISON,
        GROUND,
        FLYING,
        PSYCHIC,
        BUG,
        ROCK,
        GHOST,
        DRAGON,
        DARK,
        STEEL,
        FAIRY
    }

    /// <summary>
    /// Static class to be used for calculating type calculations.
    /// </summary>
    public static class TypeChart
    {
        private static Dictionary<Types, Dictionary<Types, double>> multipliers =
            new Dictionary<Types, Dictionary<Types, double>>();

        private static void Initialize()
        {
            multipliers.Add(Types.NORMAL, GetNormal());
            multipliers.Add(Types.FIRE, GetFire());
            multipliers.Add(Types.WATER, GetWater());
            multipliers.Add(Types.ELECTRIC, GetElectric());
            multipliers.Add(Types.GRASS, GetGrass());
            multipliers.Add(Types.ICE, GetIce());
            multipliers.Add(Types.FIGHTING, GetFighting());
            multipliers.Add(Types.POISON, GetPoison());
            multipliers.Add(Types.GROUND, GetGround());
            multipliers.Add(Types.FLYING, GetFlying());
            multipliers.Add(Types.PSYCHIC, GetPsychic());
            multipliers.Add(Types.BUG, GetBug());
            multipliers.Add(Types.ROCK, GetRock());
            multipliers.Add(Types.GHOST, GetGhost());
            multipliers.Add(Types.DRAGON, GetDragon());
            multipliers.Add(Types.DARK, GetDark());
            multipliers.Add(Types.STEEL, GetSteel());
            multipliers.Add(Types.FAIRY, GetFairy());
        }

        /// <summary>
        /// Gets the multiplier value for an attack.
        /// </summary>
        /// <param name="attack">The type of the attack</param>
        /// <param name="target">The types of the target</param>
        /// <returns>The final multiplier for the attack.</returns>
        public static double GetMultiplier(Types attack, List<Types> target)
        {
            if (!multipliers.Any())
            {
                Initialize();
            }

            double finalMultipler = 1;
            Dictionary<Types, double> damageMult = multipliers[attack];

            foreach (Types type in target)
            {
                finalMultipler *= damageMult[type];
            }

            return finalMultipler;
        }

        #region TYPE MULTIPLIERS

        private static Dictionary<Types, double> GetNormal()
        {
            return new Dictionary<Types, double>()
                {
                    { Types.NORMAL, 1 },
                    { Types.FIRE, 1 },
                    { Types.WATER, 1 },
                    { Types.ELECTRIC, 1 },
                    { Types.GRASS, 1 },
                    { Types.ICE, 1 },
                    { Types.FIGHTING, 1 },
                    { Types.POISON, 1 },
                    { Types.GROUND, 1 },
                    { Types.FLYING, 1 },
                    { Types.PSYCHIC, 1 },
                    { Types.BUG, 1 },
                    { Types.ROCK, 0.5 },
                    { Types.GHOST, 0 },
                    { Types.DRAGON, 1 },
                    { Types.DARK, 1 },
                    { Types.STEEL, 0.5 },
                    { Types.FAIRY, 1 },
                };
        }
        private static Dictionary<Types, double> GetFire()
        {
            return new Dictionary<Types, double>()
                {
                    { Types.NORMAL, 1 },
                    { Types.FIRE, 0.5 },
                    { Types.WATER, 0.5 },
                    { Types.ELECTRIC, 1 },
                    { Types.GRASS, 2 },
                    { Types.ICE, 2 },
                    { Types.FIGHTING, 1 },
                    { Types.POISON, 1 },
                    { Types.GROUND, 1 },
                    { Types.FLYING, 1 },
                    { Types.PSYCHIC, 1 },
                    { Types.BUG, 2 },
                    { Types.ROCK, 0.5 },
                    { Types.GHOST, 1 },
                    { Types.DRAGON, 0.5 },
                    { Types.DARK, 1 },
                    { Types.STEEL, 2 },
                    { Types.FAIRY, 1 },
                };
        }
        private static Dictionary<Types, double> GetWater()
        {
            return new Dictionary<Types, double>()
                {
                    { Types.NORMAL, 1 },
                    { Types.FIRE, 2 },
                    { Types.WATER, 0.5 },
                    { Types.ELECTRIC, 1 },
                    { Types.GRASS, 0.5 },
                    { Types.ICE, 1 },
                    { Types.FIGHTING, 1 },
                    { Types.POISON, 1 },
                    { Types.GROUND, 2 },
                    { Types.FLYING, 1 },
                    { Types.PSYCHIC, 1 },
                    { Types.BUG, 1 },
                    { Types.ROCK, 2 },
                    { Types.GHOST, 1 },
                    { Types.DRAGON, 0.5 },
                    { Types.DARK, 1 },
                    { Types.STEEL, 1 },
                    { Types.FAIRY, 1 },
                };
        }
        private static Dictionary<Types, double> GetElectric()
        {
            return new Dictionary<Types, double>()
                {
                    { Types.NORMAL, 1 },
                    { Types.FIRE, 1 },
                    { Types.WATER, 2 },
                    { Types.ELECTRIC, 0.5 },
                    { Types.GRASS, 0.5 },
                    { Types.ICE, 1 },
                    { Types.FIGHTING, 1 },
                    { Types.POISON, 1 },
                    { Types.GROUND, 0 },
                    { Types.FLYING, 2 },
                    { Types.PSYCHIC, 1 },
                    { Types.BUG, 1 },
                    { Types.ROCK, 1 },
                    { Types.GHOST, 1 },
                    { Types.DRAGON, 0.5 },
                    { Types.DARK, 1 },
                    { Types.STEEL, 1 },
                    { Types.FAIRY, 1 },
                };
        }
        private static Dictionary<Types, double> GetGrass()
        {
            return new Dictionary<Types, double>()
                {
                    { Types.NORMAL, 1 },
                    { Types.FIRE, 0.5 },
                    { Types.WATER, 2 },
                    { Types.ELECTRIC, 1 },
                    { Types.GRASS, 0/5 },
                    { Types.ICE, 1 },
                    { Types.FIGHTING, 1 },
                    { Types.POISON, 0.5 },
                    { Types.GROUND, 2 },
                    { Types.FLYING, 0.5 },
                    { Types.PSYCHIC, 1 },
                    { Types.BUG, 0.5 },
                    { Types.ROCK, 2 },
                    { Types.GHOST, 1 },
                    { Types.DRAGON, 0.5 },
                    { Types.DARK, 1 },
                    { Types.STEEL, 0.5 },
                    { Types.FAIRY, 1 },
                };
        }
        private static Dictionary<Types, double> GetIce()
        {
            return new Dictionary<Types, double>()
                {
                    { Types.NORMAL, 1 },
                    { Types.FIRE, 0.5 },
                    { Types.WATER, 0.5 },
                    { Types.ELECTRIC, 1 },
                    { Types.GRASS, 2 },
                    { Types.ICE, 0.5 },
                    { Types.FIGHTING, 1 },
                    { Types.POISON, 1 },
                    { Types.GROUND, 2 },
                    { Types.FLYING, 2 },
                    { Types.PSYCHIC, 1 },
                    { Types.BUG, 1 },
                    { Types.ROCK, 1 },
                    { Types.GHOST, 1 },
                    { Types.DRAGON, 2 },
                    { Types.DARK, 1 },
                    { Types.STEEL, 0.5 },
                    { Types.FAIRY, 1 },
                };
        }
        private static Dictionary<Types, double> GetFighting()
        {
            return new Dictionary<Types, double>()
                {
                    { Types.NORMAL, 2 },
                    { Types.FIRE, 1 },
                    { Types.WATER, 1 },
                    { Types.ELECTRIC, 1 },
                    { Types.GRASS, 1 },
                    { Types.ICE, 2 },
                    { Types.FIGHTING, 1 },
                    { Types.POISON, 0.5 },
                    { Types.GROUND, 1 },
                    { Types.FLYING, 0.5 },
                    { Types.PSYCHIC, 0.5 },
                    { Types.BUG, 0.5 },
                    { Types.ROCK, 2 },
                    { Types.GHOST, 0 },
                    { Types.DRAGON, 1 },
                    { Types.DARK, 2 },
                    { Types.STEEL, 2 },
                    { Types.FAIRY, 0.5 },
                };
        }
        private static Dictionary<Types, double> GetPoison()
        {
            return new Dictionary<Types, double>()
                {
                    { Types.NORMAL, 1 },
                    { Types.FIRE, 1 },
                    { Types.WATER, 1 },
                    { Types.ELECTRIC, 1 },
                    { Types.GRASS, 2 },
                    { Types.ICE, 1 },
                    { Types.FIGHTING, 1 },
                    { Types.POISON, 0.5 },
                    { Types.GROUND, 0.5 },
                    { Types.FLYING, 1 },
                    { Types.PSYCHIC, 1 },
                    { Types.BUG, 1 },
                    { Types.ROCK, 0.5 },
                    { Types.GHOST, 0.5 },
                    { Types.DRAGON, 1 },
                    { Types.DARK, 1 },
                    { Types.STEEL, 0 },
                    { Types.FAIRY, 2 },
                };
        }
        private static Dictionary<Types, double> GetGround()
        {
            return new Dictionary<Types, double>()
                {
                    { Types.NORMAL, 1 },
                    { Types.FIRE, 2 },
                    { Types.WATER, 1 },
                    { Types.ELECTRIC, 2 },
                    { Types.GRASS, 0.5 },
                    { Types.ICE, 1 },
                    { Types.FIGHTING, 1 },
                    { Types.POISON, 2 },
                    { Types.GROUND, 1 },
                    { Types.FLYING, 0 },
                    { Types.PSYCHIC, 1 },
                    { Types.BUG, 0.5 },
                    { Types.ROCK, 2 },
                    { Types.GHOST, 1 },
                    { Types.DRAGON, 1 },
                    { Types.DARK, 1 },
                    { Types.STEEL, 2 },
                    { Types.FAIRY, 1 },
                };
        }
        private static Dictionary<Types, double> GetFlying()
        {
            return new Dictionary<Types, double>()
                {
                    { Types.NORMAL, 1 },
                    { Types.FIRE, 1 },
                    { Types.WATER, 1 },
                    { Types.ELECTRIC, 0.5 },
                    { Types.GRASS, 2 },
                    { Types.ICE, 1 },
                    { Types.FIGHTING, 2 },
                    { Types.POISON, 1 },
                    { Types.GROUND, 1 },
                    { Types.FLYING, 1 },
                    { Types.PSYCHIC, 1 },
                    { Types.BUG, 2 },
                    { Types.ROCK, 0.5 },
                    { Types.GHOST, 1 },
                    { Types.DRAGON, 1 },
                    { Types.DARK, 1 },
                    { Types.STEEL, 0.5 },
                    { Types.FAIRY, 1 },
                };
        }
        private static Dictionary<Types, double> GetPsychic()
        {
            return new Dictionary<Types, double>()
                {
                    { Types.NORMAL, 1 },
                    { Types.FIRE, 1 },
                    { Types.WATER, 1 },
                    { Types.ELECTRIC, 1 },
                    { Types.GRASS, 1 },
                    { Types.ICE, 1 },
                    { Types.FIGHTING, 2 },
                    { Types.POISON, 2 },
                    { Types.GROUND, 1 },
                    { Types.FLYING, 1 },
                    { Types.PSYCHIC, 0.5 },
                    { Types.BUG, 1 },
                    { Types.ROCK, 1 },
                    { Types.GHOST, 1 },
                    { Types.DRAGON, 1 },
                    { Types.DARK, 0 },
                    { Types.STEEL, 0.5 },
                    { Types.FAIRY, 1 },
                };
        }
        private static Dictionary<Types, double> GetBug()
        {
            return new Dictionary<Types, double>()
                {
                    { Types.NORMAL, 1 },
                    { Types.FIRE, 0.5 },
                    { Types.WATER, 1 },
                    { Types.ELECTRIC, 1 },
                    { Types.GRASS, 2 },
                    { Types.ICE, 1 },
                    { Types.FIGHTING, 0.5 },
                    { Types.POISON, 0.5 },
                    { Types.GROUND, 1 },
                    { Types.FLYING, 0.5 },
                    { Types.PSYCHIC, 2 },
                    { Types.BUG, 1 },
                    { Types.ROCK, 1 },
                    { Types.GHOST, 0.5 },
                    { Types.DRAGON, 1 },
                    { Types.DARK, 2 },
                    { Types.STEEL, 0.5 },
                    { Types.FAIRY, 0.5 },
                };
        }
        private static Dictionary<Types, double> GetRock()
        {
            return new Dictionary<Types, double>()
                {
                    { Types.NORMAL, 1 },
                    { Types.FIRE, 2 },
                    { Types.WATER, 1 },
                    { Types.ELECTRIC, 1 },
                    { Types.GRASS, 1 },
                    { Types.ICE, 2 },
                    { Types.FIGHTING, 0.5 },
                    { Types.POISON, 1 },
                    { Types.GROUND, 0.5 },
                    { Types.FLYING, 2 },
                    { Types.PSYCHIC, 1 },
                    { Types.BUG, 2 },
                    { Types.ROCK, 1 },
                    { Types.GHOST, 1 },
                    { Types.DRAGON, 1 },
                    { Types.DARK, 1 },
                    { Types.STEEL, 0.5 },
                    { Types.FAIRY, 1 },
                };
        }
        private static Dictionary<Types, double> GetGhost()
        {
            return new Dictionary<Types, double>()
                {
                    { Types.NORMAL, 0 },
                    { Types.FIRE, 1 },
                    { Types.WATER, 1 },
                    { Types.ELECTRIC, 1 },
                    { Types.GRASS, 1 },
                    { Types.ICE, 1 },
                    { Types.FIGHTING, 1 },
                    { Types.POISON, 1 },
                    { Types.GROUND, 1 },
                    { Types.FLYING, 1 },
                    { Types.PSYCHIC, 2 },
                    { Types.BUG, 1 },
                    { Types.ROCK, 1 },
                    { Types.GHOST, 2 },
                    { Types.DRAGON, 1 },
                    { Types.DARK, 0.5 },
                    { Types.STEEL, 1 },
                    { Types.FAIRY, 1 },
                };
        }
        private static Dictionary<Types, double> GetDragon()
        {
            return new Dictionary<Types, double>()
                {
                    { Types.NORMAL, 1 },
                    { Types.FIRE, 1 },
                    { Types.WATER, 1 },
                    { Types.ELECTRIC, 1 },
                    { Types.GRASS, 1 },
                    { Types.ICE, 1 },
                    { Types.FIGHTING, 1 },
                    { Types.POISON, 1 },
                    { Types.GROUND, 1 },
                    { Types.FLYING, 1 },
                    { Types.PSYCHIC, 1 },
                    { Types.BUG, 1 },
                    { Types.ROCK, 1 },
                    { Types.GHOST, 1 },
                    { Types.DRAGON, 2 },
                    { Types.DARK, 1 },
                    { Types.STEEL, 0.5 },
                    { Types.FAIRY, 0 },
                };
        }
        private static Dictionary<Types, double> GetDark()
        {
            return new Dictionary<Types, double>()
                {
                    { Types.NORMAL, 1 },
                    { Types.FIRE, 1 },
                    { Types.WATER, 1 },
                    { Types.ELECTRIC, 1 },
                    { Types.GRASS, 1 },
                    { Types.ICE, 1 },
                    { Types.FIGHTING, 0.5 },
                    { Types.POISON, 1 },
                    { Types.GROUND, 1 },
                    { Types.FLYING, 1 },
                    { Types.PSYCHIC, 2 },
                    { Types.BUG, 1 },
                    { Types.ROCK, 1 },
                    { Types.GHOST, 2 },
                    { Types.DRAGON, 1 },
                    { Types.DARK, 0.5 },
                    { Types.STEEL, 1 },
                    { Types.FAIRY, 0.5 },
                };
        }
        private static Dictionary<Types, double> GetSteel()
        {
            return new Dictionary<Types, double>()
                {
                    { Types.NORMAL, 1 },
                    { Types.FIRE, 0.5 },
                    { Types.WATER, 0.5 },
                    { Types.ELECTRIC, 0.5 },
                    { Types.GRASS, 1 },
                    { Types.ICE, 2 },
                    { Types.FIGHTING, 1 },
                    { Types.POISON, 1 },
                    { Types.GROUND, 1 },
                    { Types.FLYING, 1 },
                    { Types.PSYCHIC, 1 },
                    { Types.BUG, 1 },
                    { Types.ROCK, 2 },
                    { Types.GHOST, 1 },
                    { Types.DRAGON, 1 },
                    { Types.DARK, 1 },
                    { Types.STEEL, 0.5 },
                    { Types.FAIRY, 2 },
                };
        }
        private static Dictionary<Types, double> GetFairy()
        {
            return new Dictionary<Types, double>()
                {
                    { Types.NORMAL, 1 },
                    { Types.FIRE, 0.5 },
                    { Types.WATER, 1 },
                    { Types.ELECTRIC, 1 },
                    { Types.GRASS, 1 },
                    { Types.ICE, 1 },
                    { Types.FIGHTING, 2 },
                    { Types.POISON, 0.5 },
                    { Types.GROUND, 1 },
                    { Types.FLYING, 1 },
                    { Types.PSYCHIC, 1 },
                    { Types.BUG, 1 },
                    { Types.ROCK, 1 },
                    { Types.GHOST, 1 },
                    { Types.DRAGON, 2 },
                    { Types.DARK, 2 },
                    { Types.STEEL, 0.5 },
                    { Types.FAIRY, 1 },
                };
        }

        #endregion
    }
}
