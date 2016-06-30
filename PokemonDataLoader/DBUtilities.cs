using MongoDB.Driver;
using Newtonsoft.Json;
using PokeAPI;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PokemonDataLoader
{
    public static class DBUtilities
    {
        private const int MAX_TASKS = 100;

        #region static Dictionary<Type, string> UrlOfType = new Dictionary<Type, string> { [...] };
        private static Dictionary<Type, string> UrlOfType = new Dictionary<Type, string>
        {
            { typeof(ContestEffect     ), "contest-effect"       },
            { typeof(SuperContestEffect), "super-contest-effect" },
            { typeof(Characteristic    ), "characteristic"       },

            { typeof(Berry        ), "berry"          },
            { typeof(BerryFirmness), "berry-firmness" },
            { typeof(BerryFlavor  ), "berry-flavor"   },

            { typeof(ContestType), "contest-type" },

            { typeof(EncounterMethod        ), "encounter-method"          },
            { typeof(EncounterCondition     ), "encounter-condition"       },
            { typeof(EncounterConditionValue), "encounter-condition-value" },

            { typeof(EvolutionChain  ), "evolution-chain"   },
            { typeof(EvolutionTrigger), "evolution-trigger" },

            { typeof(Generation  ), "generation"    },
            { typeof(Pokedex     ), "pokedex"       },
            { typeof(GameVersion ), "version"       },
            { typeof(VersionGroup), "version-group" },

            { typeof(Item           ), "item"              },
            { typeof(ItemAttribute  ), "item-attribute"    },
            { typeof(ItemCategory   ), "item-category"     },
            { typeof(ItemFlingEffect), "item-fling-effect" },
            { typeof(ItemPocket     ), "item-pocket"       },

            { typeof(Move           ), "move"              },
            { typeof(MoveAilment    ), "move-ailment"      },
            { typeof(MoveBattleStyle), "move-battle-style" },
            { typeof(MoveCategory   ), "move-category"     },
            { typeof(MoveDamageClass), "move-damage-class" },
            { typeof(MoveLearnMethod), "move-learn-method" },
            { typeof(MoveTarget     ), "move-target"       },

            { typeof(Location    ), "location"      },
            { typeof(LocationArea), "location-area" },
            { typeof(PalParkArea ), "pal-park-area" },
            { typeof(Region      ), "region"        },

            { typeof(Ability       ), "ability"         },
            { typeof(EggGroup      ), "egg-group"       },
            { typeof(Gender        ), "gender"          },
            { typeof(GrowthRate    ), "growth-rate"     },
            { typeof(Nature        ), "nature"          },
            { typeof(PokeathlonStat), "pokeathlon-stat" },
            { typeof(Pokemon       ), "pokemon"         },
            { typeof(PokemonColour ), "pokemon-color"   },
            { typeof(PokemonForm   ), "pokemon-form"    },
            { typeof(PokemonHabitat), "pokemon-habitat" },
            { typeof(PokemonShape  ), "pokemon-shape"   },
            { typeof(PokemonSpecies), "pokemon-species" },
            { typeof(Stat          ), "stat"            },
            { typeof(PokemonType   ), "type"            },

            { typeof(Language), "language" }
        };
        #endregion

        private static MongoClient client = new MongoClient();
        private static IMongoDatabase database;

        /// <summary>
        /// Generates all the necessary files and loads the DB (if started)
        /// </summary>
        public static void Generate()
        {
            InitDB();
            DateTime start = DateTime.Now;
            GenerateObjects();
            DateTime stop = DateTime.Now;

            Console.WriteLine(
                "Data loaded in {0:N2} minutes. Press any key to exit.",
                stop.Subtract(start).TotalMinutes);
            Console.ReadKey();
        }

        private static void InitDB()
        {
            client.DropDatabase("PML");
            // Get a database (creates one if it doesn't exist)
            database = client.GetDatabase("PML");
        }

        private static void GenerateObjects()
        {
            try
            {
                Console.WriteLine("Creating Contest Effects");
                GenerateObjects<ContestEffect>().Wait();

                Console.WriteLine("Creating Super Contest Effects");
                GenerateObjects<SuperContestEffect>().Wait();
                Console.WriteLine("Creating Characteristics");
                GenerateObjects<Characteristic>().Wait();

                Console.WriteLine("Creating Berries");
                GenerateNamedObjects<Berry>().Wait();
                Console.WriteLine("Creating Berry Firmnesses");
                GenerateNamedObjects<BerryFirmness>().Wait();
                Console.WriteLine("Creating Berry Flavors");
                GenerateNamedObjects<BerryFlavor>().Wait();

                Console.WriteLine("Creating Contest Types");
                GenerateNamedObjects<ContestType>().Wait();

                Console.WriteLine("Creating Encounter Methods");
                GenerateNamedObjects<EncounterMethod>().Wait();
                Console.WriteLine("Creating Encounter Conditions");
                GenerateNamedObjects<EncounterCondition>().Wait();
                Console.WriteLine("Creating Encounter Condition Values");
                GenerateNamedObjects<EncounterConditionValue>().Wait();

                Console.WriteLine("Creating Evolution Chains");
                GenerateObjects<EvolutionChain>().Wait();
                Console.WriteLine("Creating Evolution Triggers");
                GenerateNamedObjects<EvolutionTrigger>().Wait();

                Console.WriteLine("Creating Generations");
                GenerateNamedObjects<Generation>().Wait();
                Console.WriteLine("Creating Pokedexes");
                GenerateNamedObjects<Pokedex>().Wait();
                Console.WriteLine("Creating Game Versions");
                GenerateNamedObjects<GameVersion>().Wait();
                Console.WriteLine("Creating Version Groups");
                GenerateNamedObjects<VersionGroup>().Wait();

                Console.WriteLine("Creating Items");
                GenerateNamedObjects<Item>().Wait();
                Console.WriteLine("Creating Item Attributes");
                GenerateNamedObjects<ItemAttribute>().Wait();
                Console.WriteLine("Creating Item Categories");
                GenerateNamedObjects<ItemCategory>().Wait();
                Console.WriteLine("Creating Item Fling Effects");
                GenerateNamedObjects<ItemFlingEffect>().Wait();
                Console.WriteLine("Creating Item Pockets");
                GenerateNamedObjects<ItemPocket>().Wait();

                Console.WriteLine("Creating Moves");
                GenerateNamedObjects<Move>().Wait();
                Console.WriteLine("Creating Move Ailments");
                GenerateNamedObjects<MoveAilment>().Wait();
                Console.WriteLine("Creating Move Battle Styles");
                GenerateNamedObjects<MoveBattleStyle>().Wait();
                Console.WriteLine("Creating Move Categories");
                GenerateNamedObjects<MoveCategory>().Wait();
                Console.WriteLine("Creating Move Damage Classes");
                GenerateNamedObjects<MoveDamageClass>().Wait();
                Console.WriteLine("Creating Move Learning Methods");
                GenerateNamedObjects<MoveLearnMethod>().Wait();
                Console.WriteLine("Creating Move Targets");
                GenerateNamedObjects<MoveTarget>().Wait();

                Console.WriteLine("Creating Locations");
                GenerateNamedObjects<Location>().Wait();

                // Really big request
                Console.WriteLine("Creating Location Areas");
                GenerateNamedObjects<LocationArea>().Wait();

                Console.WriteLine("Creating Pal Park Areas");
                GenerateNamedObjects<PalParkArea>().Wait();
                Console.WriteLine("Creating Regions");
                GenerateNamedObjects<Region>().Wait();

                Console.WriteLine("Creating Abilities");
                GenerateNamedObjects<Ability>().Wait();
                Console.WriteLine("Creating Egg Groups");
                GenerateNamedObjects<EggGroup>().Wait();
                Console.WriteLine("Creating Genders");
                GenerateNamedObjects<Gender>().Wait();
                Console.WriteLine("Creating Growth Rates");
                GenerateNamedObjects<GrowthRate>().Wait();
                Console.WriteLine("Creating Natures");
                GenerateNamedObjects<Nature>().Wait();
                Console.WriteLine("Creating Pokeathlon Stats");
                GenerateNamedObjects<PokeathlonStat>().Wait();

                // Really big request
                Console.WriteLine("Creating Pokemon");
                GenerateNamedObjects<Pokemon>().Wait();

                Console.WriteLine("Creating Pokemon Colors");
                GenerateNamedObjects<PokemonColour>().Wait();
                Console.WriteLine("Creating Pokemon Forms");
                GenerateNamedObjects<PokemonForm>().Wait();
                Console.WriteLine("Creating Pokemon Habitat");
                GenerateNamedObjects<PokemonHabitat>().Wait();
                
                Console.WriteLine("Creating Pokemon Shapes");
                GenerateNamedObjects<PokemonShape>().Wait();

                // Really big request
                Console.WriteLine("Creating Pokemon Species");
                GenerateNamedObjects<PokemonSpecies>().Wait();

                Console.WriteLine("Creating Stats");
                GenerateNamedObjects<Stat>().Wait();
                Console.WriteLine("Creating Pokemon Types");
                GenerateNamedObjects<PokemonType>().Wait();

                Console.WriteLine("Creating Languages");
                GenerateNamedObjects<Language>().Wait();
            }
            catch (AggregateException e)
            {
                Console.WriteLine(e.InnerException.Message);
            }
        }

        private static async Task GenerateObjects<T>()
            where T : ApiObject
        {
            DateTime start = DateTime.Now;
            List<T> objects = new List<T>();
            List<Task<T>> tasks = new List<Task<T>>();
            ResourceList<ApiResource<T>, T> list =
                await DataFetcher.GetResourceList<ApiResource<T>, T>();
            IEnumerator<ApiResource<T>> enumerator = list.GetEnumerator();
            do
            {
                tasks.Add(enumerator.Current.GetObject());
            } while (enumerator.MoveNext());

            // Give the server some time to process all our results before we do the next batch.

            foreach (Task<T> t in tasks)
            {
                if (t.IsCanceled)
                    t.Start();
                objects.Add(await t);
            }

            if (list.Count == objects.Count)
                SaveToDB(objects);
            else
                Console.WriteLine(
                    "Aborting save. {0} of {1} records missing.",
                    list.Count - objects.Count, list.Count);

            DateTime stop = DateTime.Now;
            Console.WriteLine("{0:N2} seconds to complete {1} records for {2} datatype.",
                stop.Subtract(start).TotalSeconds, objects.Count, UrlOfType[typeof(T)]);
        }

        private static async Task GenerateNamedObjects<T>()
            where T : NamedApiObject
        {
            DateTime start = DateTime.Now;
            List<T> objects = new List<T>();
            List<Task<T>> tasks = new List<Task<T>>();
            ResourceList<NamedApiResource<T>, T> list =
                await DataFetcher.GetResourceList<NamedApiResource<T>, T>();
            IEnumerator<NamedApiResource<T>> enumerator = list.GetEnumerator();
            do
            {
                tasks.Add(enumerator.Current.GetObject());
            } while (enumerator.MoveNext());
                        
            foreach (Task<T> t in tasks)
            {
                if (t.IsCanceled)
                    t.Start();
                objects.Add(await t);
            }

            if (list.Count == objects.Count)
                SaveToDB(objects);
            else
                Console.WriteLine(
                    "Aborting save. {0} of {1} records missing.",
                    list.Count - objects.Count, list.Count);

            DateTime stop = DateTime.Now;
            Console.WriteLine("{0:N2} seconds to complete {1} records for {2} datatype.",
                stop.Subtract(start).TotalSeconds, objects.Count, UrlOfType[typeof(T)]);
        }

        private static async void SaveToDB<T>(List<T> objects)
        {
            IMongoCollection<T> collection =
                database.GetCollection<T>(UrlOfType[typeof(T)]);
            await collection.InsertManyAsync(objects);
        }
    }
}
