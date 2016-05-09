namespace PokemonDataLoader
{
    /// <summary>
    /// The following code was obtained from https://github.com/bladefist/JsonUtils
    /// under the GNU General Public License v2.0 (GLP-2.0). This software is
    /// provided 'as is' and has no warranty.
    /// 
    /// No significant changes have been made to the software.
    /// </summary>
    public interface IJsonClassGeneratorConfig
    {
        string Namespace { get; set; }
        string SecondaryNamespace { get; set; }
        bool UseProperties { get; set; }
        bool InternalVisibility { get; set; }
        bool ExplicitDeserialization { get; set; }
        bool NoHelperClass { get; set; }
        string MainClass { get; set; }
        bool UsePascalCase { get; set; }
        bool UseNestedClasses { get; set; }
        bool ApplyObfuscationAttributes { get; set; }
        bool SingleFile { get; set; }
        ICodeWriter CodeWriter { get; set; }
        bool HasSecondaryClasses { get; }
        bool AlwaysUseNullableValues { get; set; }
        bool UseNamespaces { get; }
        bool ExamplesInDocumentation { get; set; }
        string PropertyAttribute { get; set; }
    }
}