using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

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
            CreateClasses();
            // LoadDB();

            Console.WriteLine("Press any key ...");
            Console.ReadKey();
        }
    
        /// <summary>
        /// Generates the create table SQL coed.
        /// </summary>
        /// <param name="json">JSON of object</param>
        /// <param name="className">Name of desired table name</param>
        /// <returns>SQL script</returns>
        private static string GenerateSQL(string json, string className)
        {
            ICodeWriter writer = new SQLCodeWriter();
            var gen = CreateGenerator(json, writer, className);
            using (var sw = new StringWriter())
            {
                gen.OutputStream = sw;
                gen.GenerateClasses();
                sw.Flush();
                return sw.ToString();
            }
        }

        /// <summary>
        /// Generates the C# code and writes it to Generated.cs (check into source control).
        /// </summary>
        private static void CreateClasses()
        {
            string[] folders = Directory.GetDirectories(PATH);
            foreach (string folder in folders)
            {
                Console.Write("\rGenerating classes for: {0}               ", Path.GetFileName(folder));
                string file = Directory.GetFiles(folder).First();

                // If we thread out here, things would work.
                // However, our status would be less tidy.
                using (FileStream fs = new FileStream(file, FileMode.Open))
                using (StreamReader sr = new StreamReader(fs))
                {
                    string json = sr.ReadToEnd();
                    string className = FixClassName(folder);
                    string gen = GenerateClasses(json, className);
                    ManageClasses(gen);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Class Generation Complete");

            // Write the class to a file.
            using (FileStream fs = new FileStream("./../../Generated/Generated.cs", FileMode.Create))
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.WriteLine("using Newtonsoft.Json;");
                sw.WriteLine("using System.Collections.Generic;");
                sw.WriteLine();
                sw.WriteLine("namespace PokemonDataLoader.Generated");
                sw.WriteLine("{");

                foreach (KeyValuePair<string, string> kvp in classMap)
                {
                    sw.WriteLine("\t{0}{1}", PUBLIC_CLASS, kvp.Value);
                }

                sw.WriteLine("}");
            }

            Console.WriteLine("Generated.cs written");
        }
        
        /// <summary>
        /// Generates the C# code for a class.
        /// </summary>
        /// <param name="json">JSON to generate from/</param>
        /// <param name="className">Name of desired class</param>
        /// <returns>Generated C# code (not final output)</returns>
        private static string GenerateClasses(string json, string className)
        {
            ICodeWriter writer = new CSharpCodeWriter();
            var gen = CreateGenerator(json, writer, className);
            using (var sw = new StringWriter())
            {
                gen.OutputStream = sw;
                gen.GenerateClasses();
                sw.Flush();
                return sw.ToString();
            }
        }

        /// <summary>
        /// Returns a new class generator with supplied defaults.
        /// </summary>
        /// <param name="json">JSON of class to generate</param>
        /// <param name="writer">Type of writer to use (SQL or C#)</param>
        /// <param name="className">Name of class to be written</param>
        /// <returns>New class generator</returns>
        private static JsonClassGenerator CreateGenerator(string json, ICodeWriter writer, string className)
        {
            return new JsonClassGenerator
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
                TargetFolder = null //Maybe change this?
            };
        }

        /// <summary>
        /// Generates all the SQL code and saves it to a file (tables.sql)
        /// </summary>
        private static void CreateDBTables()
        {
            string[] folders = Directory.GetDirectories(PATH);
            foreach (string folder in folders)
            {
                Console.Write("\rGenerating sql for: {0}               ", Path.GetFileName(folder));
                string file = Directory.GetFiles(folder).First();
               
                // If we thread out here, things would work.
                // However, our status would be less tidy.
                using (FileStream fs = new FileStream(file, FileMode.Open))
                using (StreamReader sr = new StreamReader(fs))
                {
                    string json = sr.ReadToEnd();
                    string className = FixClassName(folder);
                    string sql = GenerateSQL(json, className);
                    ManageSQL(sql);
                }                
            }

            // Save SQL off for use later, if desired
            using (FileStream fs = new FileStream(string.Format("{0}/tables.sql", Environment.CurrentDirectory), FileMode.Create))
            using (StreamWriter sw = new StreamWriter(fs))
            {
                foreach (string sql in sqlList)
                {
                    // Don't forget to add back the create table
                    sw.WriteLine(CREATE_TABLE + sql);
                    sw.WriteLine();
                }
            }

            Console.WriteLine();
            Console.WriteLine("SQL Generation Complete");
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
        /// Adds C# code to the dictionary, or merges with an existing entry.
        /// </summary>
        /// <param name="generated">Code that has been generated</param>
        private static void ManageClasses(string generated)
        {
            IEnumerable<string> classes = 
                generated.Split(new string[] { PUBLIC_CLASS }, StringSplitOptions.RemoveEmptyEntries)
                         .Where(c => !string.IsNullOrWhiteSpace(c));

            foreach (string c in classes)
            {
                string className = c.Substring(0, c.IndexOf("\r\n"));
                if (classMap.ContainsKey(className))
                {
                    classMap[className] = ClassHelper.Merge(classMap[className], c.Trim());
                }
                else
                {
                    classMap.Add(className, c.Trim());
                }
            }
        }

        private static void LoadDB()
        {

        }
    }
}
