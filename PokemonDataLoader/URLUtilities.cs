using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading;

namespace PokemonDataLoader
{
    /// <summary>
    /// Utility class responsible for interaction with PokeAPI
    /// </summary>
    public static class URLUtilities
    {
        /// <summary>
        /// URL of the PokeAPI calls
        /// </summary>
        public const string URL = "http://pokeapi.co/api/v2/";
        /// <summary>
        /// String used to retrieve the number of records for a resource type
        /// </summary>
        public const string LIMIT = "?limit=";

        /// <summary>
        /// Master list of resources to query.
        /// </summary>
        private static readonly List<string> resourceList = new List<string>
        {
            // Berries
            "berry",
            "berry-firmness",
            "berry-flavor",
            // Contests
            "contest-type",
            "contest-effect",
            "super-contest-effect",
            // Encounters
            "encounter-method",
            "encounter-condition",
            "encounter-condition-value",
            // Evolution
            "evolution-chain",
            "evolution-trigger",
            // Games
            "generation",
            "pokedex",
            "version",
            "version-group",
            // Items
            "item",
            "item-attribute",
            "item-category",
            "item-fling-effect",
            "item-pocket",
            // Moves
            "move",
            "move-ailment",
            "move-battle-style",
            "move-category",
            "move-damage-class",
            "move-learn-method",
            "move-target",
            // Locations
            "location",
            "location-area",
            "pal-park-area",
            "region",
            // Pokemon
            "ability",
            "characteristic",
            "egg-group",
            "gender",
            "growth-rate",
            "nature",
            "pokeathlon-stat",
            "pokemon",
            "pokemon-color",
            "pokemon-form",
            "pokemon-habitat",
            "pokemon-shape",
            "pokemon-species",
            "stat",
            "type",
            // Utility
            "language"
        };

        /// <summary>
        /// Dictionary mapping the resource type and its last record number
        /// </summary>
        private static readonly Dictionary<string, int> resourceMaxes = new Dictionary<string, int>();

        /// <summary>
        /// Makes the call to the PokeAPI site and saves the json locally.
        /// </summary>
        public static void LoadResources()
        {
            LoadMaxValues();

            Console.WriteLine("Beginning JSON retrieval");
            foreach (KeyValuePair<string, int> kvp in resourceMaxes)
            {
                Console.WriteLine();
                for (int i = 1; i <= kvp.Value; i++)
                {
                    Console.Write("\rLoading {0} data: {1} of {2}", kvp.Key, i, kvp.Value);
                    string json = GetDataFromID(kvp.Key, i);
                    SaveJson(json, kvp.Key, i);
                }
            }

            Console.WriteLine("\nData load complete");
            Console.ReadKey();
        }
        
        /// <summary>
        /// Calls PokeAPI to find the number of records for each record type.
        /// </summary>
        private static void LoadMaxValues()
        {
            foreach (string endpoint in resourceList)
            {
                Console.Write("\rLoading Max Values: {0}             ", endpoint);
                // Limit the amount of data we are pulling back
                string json = GetDataFromName(endpoint, string.Format("{0}1", LIMIT));
                var jObj = (JObject)JsonConvert.DeserializeObject(json);
                int count = jObj["count"].Value<int>();
                if (count > 0)
                {
                    resourceMaxes.Add(endpoint, count);
                }
            }
            Console.Write("\rLoading complete                        ");
            Console.WriteLine();
        }        

        /// <summary>
        /// Utility method for calling the PokeAPI service. Use sparingly.
        /// </summary>
        /// <param name="resourceEndpoint">Type of resource to load</param>
        /// <param name="resourceId">Id of resource to load</param>
        /// <returns>JSON of resource, or empty if the id is invalid</returns>
        public static string GetDataFromID(string resourceEndpoint, int resourceId)
        {
            string newUrl = string.Format("{0}{1}/{2}", URL, resourceEndpoint, resourceId);
            return GetData(newUrl);
        }

        /// <summary>
        /// Utility method for calling the PokeAPI service. Use sparingly.
        /// </summary>
        /// <param name="resourceEndpoint">Type of resource to load</param>
        /// <param name="resourceName">Name of the resource</param>
        /// <returns>JSON of resource, or empty if the id is invalid</returns>
        public static string GetDataFromName(string resourceEndpoint, string resourceName)
        {
            string newUrl = string.Format("{0}{1}/{2}", URL, resourceEndpoint, resourceName);
            return GetData(newUrl);
        }

        /// <summary>
        /// Utility method for calling the PokeAPI service. Use sparingly.
        /// </summary>
        /// <param name="url">URL to be queried</param>
        /// <returns>JSON, or empty string if url is null/empty or request fails</returns>
        public static string GetData(string url)
        {
            if (string.IsNullOrWhiteSpace(url))
                return string.Empty;

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync(url).Result;

            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsStringAsync().Result;
            }
            else
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// Saves a JSON string locally.
        /// </summary>
        /// <param name="json">JSON to be saved</param>
        /// <param name="folder">Name of the resource type to save under</param>
        /// <param name="id">Id of the resource</param>
        private static void SaveJson(string json, string folder, int id)
        {
            string path = string.Format(@"{0}\pokeapi\{1}", Environment.CurrentDirectory, folder);
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            using (FileStream fs = new FileStream(string.Format(@"{0}\{1}.json", path, id), FileMode.OpenOrCreate))
            using (StreamWriter sw = new StreamWriter(fs))
            using (JsonTextWriter jw = new JsonTextWriter(sw))
            {
                dynamic jsonObj = JsonConvert.DeserializeObject(json);
                jw.Formatting = Formatting.Indented;
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(jw, jsonObj);
            }
        }

        public static void SaveTest()
        {
            string json = GetDataFromID("ability", 1);
            SaveJson(json, "ability", 1);
        }
    }
}
