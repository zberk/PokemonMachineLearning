using System.IO;

namespace PokemonDataLoader
{
    /// <summary>
    /// The following code was obtained from https://github.com/bladefist/JsonUtils
    /// under the GNU General Public License v2.0 (GLP-2.0). This software is
    /// provided 'as is' and has no warranty.
    /// 
    /// No significant changes have been made to the software.
    /// </summary>
    public interface ICodeWriter
    {
        string FileExtension { get; }
        string DisplayName { get; }
        string GetTypeName(JsonType type, IJsonClassGeneratorConfig config);
        void WriteClass(IJsonClassGeneratorConfig config, TextWriter sw, JsonType type);
        void WriteFileStart(IJsonClassGeneratorConfig config, TextWriter sw);
        void WriteFileEnd(IJsonClassGeneratorConfig config, TextWriter sw);
        void WriteNamespaceStart(IJsonClassGeneratorConfig config, TextWriter sw, bool root);
        void WriteNamespaceEnd(IJsonClassGeneratorConfig config, TextWriter sw, bool root);
    }    
}
