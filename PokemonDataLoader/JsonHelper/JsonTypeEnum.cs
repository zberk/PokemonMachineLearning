namespace PokemonDataLoader
{
    /// <summary>
    /// The following code was obtained from https://github.com/bladefist/JsonUtils
    /// under the GNU General Public License v2.0 (GLP-2.0). This software is
    /// provided 'as is' and has no warranty.
    /// 
    /// No significant changes have been made to the software.
    /// </summary>
    public enum JsonTypeEnum
    {
        Anything,
        String,
        Boolean,
        Integer,
        Long,
        Float,
        Date,
        NullableInteger,
        NullableLong,
        NullableFloat,
        NullableBoolean,
        NullableDate,
        Object,
        Array,
        Dictionary,
        NullableSomething,
        NonConstrained
    }
}
