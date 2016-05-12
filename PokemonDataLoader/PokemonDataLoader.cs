using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDataLoader
{
    class PokemonDataLoader
    {
        static void Main(string[] args)
        {
            // Step 1) Grab all the pokeapi json and save it locally.
            // TODO: Thread this out so we can finish faster. 
            //URLUtilities.LoadResources();

            // Step 2) Convert the JSON into a database
            DBUtilities.Generate();
        }
    }
}
