using MongoDB.Driver;
using Newtonsoft.Json;
using PokeAPI;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;

namespace PokemonDataLoader
{
    public static class DBUtilities
    {
        /// <summary>
        /// Path to all JSON files.
        /// </summary>
        private static string PATH = string.Format(@"{0}\pokeapi", Environment.CurrentDirectory);
        /// <summary>
        /// Create table constant to split on (SQL)
        /// </summary>
        private const string CREATE_TABLE = "create table ";
        /// <summary>
        /// Public class constant to split on (C#)
        /// </summary>
        private const string PUBLIC_CLASS = "public class ";
        /// <summary>
        /// List of SQL commands to be executed
        /// </summary>
        private static readonly List<string> sqlList = new List<string>();
        /// <summary>
        /// Dictionaty that maps a class name to its generated code.
        /// </summary>
        private static readonly Dictionary<string, string> classMap = new Dictionary<string, string>();

        /// <summary>
        /// Generates all the necessary files and loads the DB (if started)
        /// </summary>
        public static void Generate()
        {
            //CreateDBTables();
            LoadDB();

            Console.WriteLine("Press any key ...");
            Console.ReadKey();
        }
                         
        /// <summary>
        /// Changes a folder name to a class name.
        /// </summary>
        /// <param name="folder">Folder name</param>
        /// <returns>Class name in PascalCase</returns>
        private static string FixClassName(string folder)
        {
            string folderName = Path.GetFileName(folder);
            string[] words = folderName.Split('-');
            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            return ti.ToTitleCase(string.Join(" ", words))
                     .Replace(" ", string.Empty);
        }

        /// <summary>
        /// Adds SQL to the pending list, if it does not already exist.
        /// </summary>
        /// <param name="sql">SQL to add</param>
        private static void ManageSQL(string sql)
        {
            // Get each table so we don't keep duplicates.
            string[] tables = sql.Split(new string[] { CREATE_TABLE }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string table in tables)
            {
                if (!sqlList.Contains(table))
                    sqlList.Add(table);
            }
        }

        /// <summary>
        /// Loads data into MongoDB.
        /// See https://docs.mongodb.com/manual/tutorial/install-mongodb-on-windows/#manually-create-windows-service
        /// for running the database as a service.
        /// TODO: Include this service in the project?
        /// </summary>
        private static void LoadDB()
        {
            // Start a connection to Mongo
            MongoClient client = new MongoClient();
            // Reset database
            client.DropDatabase("PML");
            // Get a database (creates one if it doesn't exist)
            IMongoDatabase database = client.GetDatabase("PML");
            GetObjects(database);
        }

        private static void GetObjects(IMongoDatabase database)
        {
            string[] folders = Directory.GetDirectories(PATH);
            foreach (string folder in folders)
            {
                int count = 1;
                string folderName = Path.GetFileName(folder);
                string[] files = Directory.GetFiles(folder);
                foreach (string file in files)
                {
                    Console.Write("\rProcessing {0}: {1} of {2}              ", folderName, count, files.Count());
                    using (FileStream fs = new FileStream(file, FileMode.Open))
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        string json = sr.ReadToEnd();
                        // TODO Should this be async?
                        Thread t = new Thread(() => StoreObject(folderName, json, database));
                        t.Start();
                        count++;
                    }
                }
            }

            Console.WriteLine();
        }

        private static void StoreObject(string folder, string json, IMongoDatabase database)
        {
            switch (folder)
            {
                case "ability":
                    StoreObject<Ability>(folder, json, database);
                    break;
                case "berry":
                    StoreObject<Berry>(folder, json, database);
                    break;
                case "berry-firmness":
                    StoreObject<BerryFirmness>(folder, json, database);
                    break;
                case "berry-flavor":
                    StoreObject<BerryFlavor>(folder, json, database);
                    break;
                case "characteristic":
                    StoreObject<Characteristic>(folder, json, database);
                    break;
                case "contest-effect":
                    StoreObject<ContestEffect>(folder, json, database);
                    break;
                case "contest-type":
                    StoreObject<ContestType>(folder, json, database);
                    break;
                case "egg-group":
                    StoreObject<EggGroup>(folder, json, database);
                    break;
                case "encounter-condition":
                    StoreObject<EncounterCondition>(folder, json, database);
                    break;
                case "encounter-condition-value":
                    StoreObject<EncounterConditionValue>(folder, json, database);
                    break;
                case "encounter-method":
                    StoreObject<EncounterMethod>(folder, json, database);
                    break;
                case "evolution-chain":
                    StoreObject<EvolutionChain>(folder, json, database);
                    break;
                case "evolution-trigger":
                    StoreObject<EvolutionTrigger>(folder, json, database);
                    break;
                case "gender":
                    StoreObject<Gender>(folder, json, database);
                    break;
                case "generation":
                    StoreObject<Generation>(folder, json, database);
                    break;
                case "growth-rate":
                    StoreObject<GrowthRate>(folder, json, database);
                    break;
                case "item":
                    StoreObject<Item>(folder, json, database);
                    break;
                case "item-attribute":
                    StoreObject<ItemAttribute>(folder, json, database);
                    break;
                case "item-category":
                    StoreObject<ItemCategory>(folder, json, database);
                    break;
                case "item-fling-effect":
                    StoreObject<ItemFlingEffect>(folder, json, database);
                    break;
                case "item-pocket":
                    StoreObject<ItemPocket>(folder, json, database);
                    break;
                case "language":
                    StoreObject<Language>(folder, json, database);
                    break;
                case "location":
                    StoreObject<Location>(folder, json, database);
                    break;
                case "location-area":
                    StoreObject<LocationArea>(folder, json, database);
                    break;
                case "move":
                    StoreObject<Move>(folder, json, database);
                    break;
                case "move-ailment":
                    StoreObject<MoveAilment>(folder, json, database);
                    break;
                case "move-battle-style":
                    StoreObject<MoveBattleStyle>(folder, json, database);
                    break;
                case "move-category":
                    StoreObject<MoveCategory>(folder, json, database);
                    break;
                case "move-damage-class":
                    StoreObject<MoveDamageClass>(folder, json, database);
                    break;
                case "move-learn-method":
                    StoreObject<MoveLearnMethod>(folder, json, database);
                    break;
                case "move-target":
                    StoreObject<MoveTarget>(folder, json, database);
                    break;
                case "nature":
                    StoreObject<Nature>(folder, json, database);
                    break;
                case "pal-park-area":
                    StoreObject<PalParkArea>(folder, json, database);
                    break;
                case "pokeathlon-stat":
                    StoreObject<PokeathlonStat>(folder, json, database);
                    break;
                case "pokedex":
                    StoreObject<Pokedex>(folder, json, database);
                    break;
                case "pokemon":
                    StoreObject<Pokemon>(folder, json, database);
                    break;
                case "pokemon-color":
                    StoreObject<PokemonColour>(folder, json, database);
                    break;
                case "pokemon-form":
                    StoreObject<PokemonForm>(folder, json, database);
                    break;
                case "pokemon-habitat":
                    StoreObject<PokemonHabitat>(folder, json, database);
                    break;
                case "pokemon-shape":
                    StoreObject<PokemonShape>(folder, json, database);
                    break;
                case "pokemon-species":
                    StoreObject<PokemonSpecies>(folder, json, database);
                    break;
                case "region":
                    StoreObject<Region>(folder, json, database);
                    break;
                case "stat":
                    StoreObject<Stat>(folder, json, database);
                    break;
                case "super-contest-effect":
                    StoreObject<SuperContestEffect>(folder, json, database);
                    break;
                case "type":
                    StoreObject<Type>(folder, json, database);
                    break;
                case "version":
                    StoreObject<Version>(folder, json, database);
                    break;
                case "version-group":
                    StoreObject<VersionGroup>(folder, json, database);
                    break;
            }
        }

        private static void StoreObject<T>(string folder, string json, IMongoDatabase database)
        {
            IMongoCollection<T> collection = database.GetCollection<T>(folder);
            // At this point, obj will not have all its properties fully fleshed out.
            // This is because the Json only stores URL and language for its generated
            // type data members. We could try to populate those values now, but the
            // URL will be sufficient for querying the database.
            T obj = JsonConvert.DeserializeObject<T>(json);
            // Insert asynchronously so we can speed this process up!
            collection.InsertOneAsync(obj);
        }
    }
}
