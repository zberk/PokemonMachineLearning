using System.IO;

namespace PokemonDataLoader
{
    public class DBUtilities
    {
        public static void GenerateDBSchema()
        {

        }
    
        private static string GenerateClass(string json, string className)
        {
            ICodeWriter writer = new SQLCodeWriter();
            var gen = new JsonClassGenerator
            {
                Example = json,
                InternalVisibility = false,
                CodeWriter = writer,
                ExplicitDeserialization = false,
                Namespace = null,
                NoHelperClass = false,
                SecondaryNamespace = null,
                UseProperties = true,
                MainClass = className,
                UsePascalCase = true,
                PropertyAttribute = "None",
                UseNestedClasses = false,
                ApplyObfuscationAttributes = false,
                SingleFile = true,
                ExamplesInDocumentation = false,
                TargetFolder = null, //Maybe change this?
            };

            using (var sw = new StringWriter())
            {
                gen.OutputStream = sw;
                gen.GenerateClasses();
                sw.Flush();
                return sw.ToString();
            }
        }
    }
}
