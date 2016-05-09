using Newtonsoft.Json;
using System.Collections.Generic;

namespace PokemonDataLoader.Generated
{
	public class Generation
	{
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("url")]
		public string Url { get; set; }
		[JsonProperty("id")]
		public int Id { get; set; }
		[JsonProperty("abilities")]
		public IList<object> Abilities { get; set; }
		[JsonProperty("main_region")]
		public MainRegion MainRegion { get; set; }
		[JsonProperty("moves")]
		public IList<Move> Moves { get; set; }
		[JsonProperty("names")]
		public IList<Name> Names { get; set; }
		[JsonProperty("pokemon_species")]
		public IList<PokemonSpecy> PokemonSpecies { get; set; }
		[JsonProperty("types")]
		public IList<Type> Types { get; set; }
		[JsonProperty("version_groups")]
		public IList<VersionGroup> VersionGroups { get; set; }
	}

	public class Language
	{
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("url")]
		public string Url { get; set; }
		[JsonProperty("id")]
		public int Id { get; set; }
		[JsonProperty("official")]
		public bool Official { get; set; }
		[JsonProperty("iso639")]
		public string Iso639 { get; set; }
		[JsonProperty("iso3166")]
		public string Iso3166 { get; set; }
		[JsonProperty("names")]
		public IList<Name> Names { get; set; }
	}

	public class Name
	{
		[JsonProperty("name")]
		public string _Name { get; set; }
		[JsonProperty("language")]
		public Language Language { get; set; }
		[JsonProperty("color")]
		public string Color { get; set; }
	}

	public class EffectEntry
	{
		[JsonProperty("effect")]
		public string Effect { get; set; }
		[JsonProperty("short_effect")]
		public string ShortEffect { get; set; }
		[JsonProperty("language")]
		public Language Language { get; set; }
	}

	public class VersionGroup
	{
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("url")]
		public string Url { get; set; }
		[JsonProperty("id")]
		public int Id { get; set; }
		[JsonProperty("order")]
		public int Order { get; set; }
		[JsonProperty("generation")]
		public Generation Generation { get; set; }
		[JsonProperty("move_learn_methods")]
		public IList<MoveLearnMethod> MoveLearnMethods { get; set; }
		[JsonProperty("pokedexes")]
		public IList<Pokedex> Pokedexes { get; set; }
		[JsonProperty("regions")]
		public IList<Region> Regions { get; set; }
		[JsonProperty("versions")]
		public IList<Version> Versions { get; set; }
	}

	public class EffectChange
    {

        [JsonProperty("version_group")]
        public VersionGroup VersionGroup { get; set; }

        [JsonProperty("effect_entries")]
        public IList<EffectEntry> EffectEntries { get; set; }
    }
	public class FlavorTextEntry
	{
		[JsonProperty("flavor_text")]
		public string FlavorText { get; set; }
		[JsonProperty("language")]
		public Language Language { get; set; }
		[JsonProperty("version_group")]
		public VersionGroup VersionGroup { get; set; }
		[JsonProperty("text")]
		public string Text { get; set; }
		[JsonProperty("version")]
		public Version Version { get; set; }
	}

	public class Pokemon
	{
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("url")]
		public string Url { get; set; }
		[JsonProperty("is_hidden")]
		public bool IsHidden { get; set; }
		[JsonProperty("slot")]
		public int Slot { get; set; }
		[JsonProperty("pokemon")]
		public Pokemon _Pokemon { get; set; }
		[JsonProperty("id")]
		public int Id { get; set; }
		[JsonProperty("base_experience")]
		public int BaseExperience { get; set; }
		[JsonProperty("height")]
		public int Height { get; set; }
		[JsonProperty("is_default")]
		public bool IsDefault { get; set; }
		[JsonProperty("order")]
		public int Order { get; set; }
		[JsonProperty("weight")]
		public int Weight { get; set; }
		[JsonProperty("abilities")]
		public IList<Ability> Abilities { get; set; }
		[JsonProperty("forms")]
		public IList<Form> Forms { get; set; }
		[JsonProperty("game_indices")]
		public IList<GameIndice> GameIndices { get; set; }
		[JsonProperty("held_items")]
		public IList<object> HeldItems { get; set; }
		[JsonProperty("location_area_encounters")]
		public IList<object> LocationAreaEncounters { get; set; }
		[JsonProperty("moves")]
		public IList<Move> Moves { get; set; }
		[JsonProperty("species")]
		public Species Species { get; set; }
		[JsonProperty("sprites")]
		public Sprites Sprites { get; set; }
		[JsonProperty("stats")]
		public IList<Stat> Stats { get; set; }
		[JsonProperty("types")]
		public IList<Type> Types { get; set; }
	}

	public class Ability
	{
		[JsonProperty("id")]
		public int Id { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("is_main_series")]
		public bool IsMainSeries { get; set; }
		[JsonProperty("generation")]
		public Generation Generation { get; set; }
		[JsonProperty("names")]
		public IList<Name> Names { get; set; }
		[JsonProperty("effect_entries")]
		public IList<EffectEntry> EffectEntries { get; set; }
		[JsonProperty("effect_changes")]
		public IList<EffectChange> EffectChanges { get; set; }
		[JsonProperty("flavor_text_entries")]
		public IList<FlavorTextEntry> FlavorTextEntries { get; set; }
		[JsonProperty("pokemon")]
		public IList<Pokemon> Pokemon { get; set; }
		[JsonProperty("url")]
		public string Url { get; set; }
		[JsonProperty("is_hidden")]
		public bool IsHidden { get; set; }
		[JsonProperty("slot")]
		public int Slot { get; set; }
		[JsonProperty("ability")]
		public Ability _Ability { get; set; }
	}

	public class Firmness
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
	public class Flavor
	{
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("url")]
		public string Url { get; set; }
		[JsonProperty("potency")]
		public int Potency { get; set; }
		[JsonProperty("flavor")]
		public Flavor _Flavor { get; set; }
	}

	public class Item
	{
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("url")]
		public string Url { get; set; }
		[JsonProperty("id")]
		public int Id { get; set; }
		[JsonProperty("cost")]
		public int Cost { get; set; }
		[JsonProperty("fling_power")]
		public object FlingPower { get; set; }
		[JsonProperty("fling_effect")]
		public object FlingEffect { get; set; }
		[JsonProperty("attributes")]
		public IList<Attribute> Attributes { get; set; }
		[JsonProperty("category")]
		public Category Category { get; set; }
		[JsonProperty("effect_entries")]
		public IList<EffectEntry> EffectEntries { get; set; }
		[JsonProperty("flavor_text_entries")]
		public IList<FlavorTextEntry> FlavorTextEntries { get; set; }
		[JsonProperty("game_indices")]
		public IList<GameIndice> GameIndices { get; set; }
		[JsonProperty("names")]
		public IList<Name> Names { get; set; }
		[JsonProperty("held_by_pokemon")]
		public IList<object> HeldByPokemon { get; set; }
		[JsonProperty("sprites")]
		public Sprites Sprites { get; set; }
		[JsonProperty("baby_trigger_for")]
		public object BabyTriggerFor { get; set; }
	}

	public class NaturalGiftType
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
	public class Berry
	{
		[JsonProperty("id")]
		public int Id { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("growth_time")]
		public int GrowthTime { get; set; }
		[JsonProperty("max_harvest")]
		public int MaxHarvest { get; set; }
		[JsonProperty("natural_gift_power")]
		public int NaturalGiftPower { get; set; }
		[JsonProperty("size")]
		public int Size { get; set; }
		[JsonProperty("smoothness")]
		public int Smoothness { get; set; }
		[JsonProperty("soil_dryness")]
		public int SoilDryness { get; set; }
		[JsonProperty("firmness")]
		public Firmness Firmness { get; set; }
		[JsonProperty("flavors")]
		public IList<Flavor> Flavors { get; set; }
		[JsonProperty("item")]
		public Item Item { get; set; }
		[JsonProperty("natural_gift_type")]
		public NaturalGiftType NaturalGiftType { get; set; }
		[JsonProperty("url")]
		public string Url { get; set; }
		[JsonProperty("potency")]
		public int Potency { get; set; }
		[JsonProperty("berry")]
		public Berry _Berry { get; set; }
	}

	public class BerryFirmness
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("berries")]
        public IList<Berry> Berries { get; set; }

        [JsonProperty("names")]
        public IList<Name> Names { get; set; }
    }
	public class ContestType
	{
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("url")]
		public string Url { get; set; }
		[JsonProperty("id")]
		public int Id { get; set; }
		[JsonProperty("berry_flavor")]
		public BerryFlavor BerryFlavor { get; set; }
		[JsonProperty("names")]
		public IList<Name> Names { get; set; }
	}

	public class BerryFlavor
	{
		[JsonProperty("id")]
		public int Id { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("berries")]
		public IList<Berry> Berries { get; set; }
		[JsonProperty("contest_type")]
		public ContestType ContestType { get; set; }
		[JsonProperty("names")]
		public IList<Name> Names { get; set; }
		[JsonProperty("url")]
		public string Url { get; set; }
	}

	public class HighestStat
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
	public class Description
	{
		[JsonProperty("description")]
		public string _Description { get; set; }
		[JsonProperty("language")]
		public Language Language { get; set; }
	}

	public class Characteristic
	{
		[JsonProperty("id")]
		public int Id { get; set; }
		[JsonProperty("gene_modulo")]
		public int GeneModulo { get; set; }
		[JsonProperty("possible_values")]
		public IList<int> PossibleValues { get; set; }
		[JsonProperty("highest_stat")]
		public HighestStat HighestStat { get; set; }
		[JsonProperty("descriptions")]
		public IList<Description> Descriptions { get; set; }
		[JsonProperty("url")]
		public string Url { get; set; }
	}

	public class ContestEffect
	{
		[JsonProperty("id")]
		public int Id { get; set; }
		[JsonProperty("appeal")]
		public int Appeal { get; set; }
		[JsonProperty("jam")]
		public int Jam { get; set; }
		[JsonProperty("effect_entries")]
		public IList<EffectEntry> EffectEntries { get; set; }
		[JsonProperty("flavor_text_entries")]
		public IList<FlavorTextEntry> FlavorTextEntries { get; set; }
		[JsonProperty("url")]
		public string Url { get; set; }
	}

	public class PokemonSpecy
	{
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("url")]
		public string Url { get; set; }
	}

	public class EggGroup
	{
		[JsonProperty("id")]
		public int Id { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("names")]
		public IList<Name> Names { get; set; }
		[JsonProperty("pokemon_species")]
		public IList<PokemonSpecy> PokemonSpecies { get; set; }
		[JsonProperty("url")]
		public string Url { get; set; }
	}

	public class Value
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
	public class EncounterCondition
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("values")]
        public IList<Value> Values { get; set; }

        [JsonProperty("names")]
        public IList<Name> Names { get; set; }
    }
	public class Condition
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
	public class EncounterConditionValue
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("condition")]
        public Condition Condition { get; set; }

        [JsonProperty("names")]
        public IList<Name> Names { get; set; }
    }
	public class EncounterMethod
	{
		[JsonProperty("id")]
		public int Id { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("order")]
		public int Order { get; set; }
		[JsonProperty("names")]
		public IList<Name> Names { get; set; }
		[JsonProperty("url")]
		public string Url { get; set; }
	}

	public class Species
	{
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("url")]
		public string Url { get; set; }
	}

	public class Trigger
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
	public class EvolutionDetails
    {

        [JsonProperty("item")]
        public object Item { get; set; }

        [JsonProperty("trigger")]
        public Trigger Trigger { get; set; }

        [JsonProperty("gender")]
        public object Gender { get; set; }

        [JsonProperty("held_item")]
        public object HeldItem { get; set; }

        [JsonProperty("known_move")]
        public object KnownMove { get; set; }

        [JsonProperty("known_move_type")]
        public object KnownMoveType { get; set; }

        [JsonProperty("location")]
        public object Location { get; set; }

        [JsonProperty("min_level")]
        public int MinLevel { get; set; }

        [JsonProperty("min_happiness")]
        public object MinHappiness { get; set; }

        [JsonProperty("min_beauty")]
        public object MinBeauty { get; set; }

        [JsonProperty("min_affection")]
        public object MinAffection { get; set; }

        [JsonProperty("needs_overworld_rain")]
        public bool NeedsOverworldRain { get; set; }

        [JsonProperty("party_species")]
        public object PartySpecies { get; set; }

        [JsonProperty("party_type")]
        public object PartyType { get; set; }

        [JsonProperty("relative_physical_stats")]
        public object RelativePhysicalStats { get; set; }

        [JsonProperty("time_of_day")]
        public string TimeOfDay { get; set; }

        [JsonProperty("trade_species")]
        public object TradeSpecies { get; set; }

        [JsonProperty("turn_upside_down")]
        public bool TurnUpsideDown { get; set; }
    }
	public class EvolvesTo
	{
		[JsonProperty("is_baby")]
		public bool IsBaby { get; set; }
		[JsonProperty("species")]
		public Species Species { get; set; }
		[JsonProperty("evolution_details")]
		public EvolutionDetails EvolutionDetails { get; set; }
		[JsonProperty("evolves_to")]
		public IList<object> _EvolvesTo { get; set; }
	}

	public class Chain
    {

        [JsonProperty("is_baby")]
        public bool IsBaby { get; set; }

        [JsonProperty("species")]
        public Species Species { get; set; }

        [JsonProperty("evolution_details")]
        public object EvolutionDetails { get; set; }

        [JsonProperty("evolves_to")]
        public IList<EvolvesTo> EvolvesTo { get; set; }
    }
	public class EvolutionChain
	{
		[JsonProperty("id")]
		public int Id { get; set; }
		[JsonProperty("baby_trigger_item")]
		public object BabyTriggerItem { get; set; }
		[JsonProperty("chain")]
		public Chain Chain { get; set; }
		[JsonProperty("url")]
		public string Url { get; set; }
	}

	public class EvolutionTrigger
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("names")]
        public IList<Name> Names { get; set; }

        [JsonProperty("pokemon_species")]
        public IList<PokemonSpecy> PokemonSpecies { get; set; }
    }
	public class PokemonSpecies
	{
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("url")]
		public string Url { get; set; }
		[JsonProperty("id")]
		public int Id { get; set; }
		[JsonProperty("order")]
		public int Order { get; set; }
		[JsonProperty("gender_rate")]
		public int GenderRate { get; set; }
		[JsonProperty("capture_rate")]
		public int CaptureRate { get; set; }
		[JsonProperty("base_happiness")]
		public int BaseHappiness { get; set; }
		[JsonProperty("is_baby")]
		public bool IsBaby { get; set; }
		[JsonProperty("hatch_counter")]
		public int HatchCounter { get; set; }
		[JsonProperty("has_gender_differences")]
		public bool HasGenderDifferences { get; set; }
		[JsonProperty("forms_switchable")]
		public bool FormsSwitchable { get; set; }
		[JsonProperty("growth_rate")]
		public GrowthRate GrowthRate { get; set; }
		[JsonProperty("pokedex_numbers")]
		public IList<PokedexNumber> PokedexNumbers { get; set; }
		[JsonProperty("egg_groups")]
		public IList<EggGroup> EggGroups { get; set; }
		[JsonProperty("color")]
		public Color Color { get; set; }
		[JsonProperty("shape")]
		public Shape Shape { get; set; }
		[JsonProperty("evolves_from_species")]
		public object EvolvesFromSpecies { get; set; }
		[JsonProperty("evolution_chain")]
		public EvolutionChain EvolutionChain { get; set; }
		[JsonProperty("habitat")]
		public Habitat Habitat { get; set; }
		[JsonProperty("generation")]
		public Generation Generation { get; set; }
		[JsonProperty("names")]
		public IList<Name> Names { get; set; }
		[JsonProperty("pal_park_encounters")]
		public IList<PalParkEncounter> PalParkEncounters { get; set; }
		[JsonProperty("form_descriptions")]
		public IList<object> FormDescriptions { get; set; }
		[JsonProperty("flavor_text_entries")]
		public IList<FlavorTextEntry> FlavorTextEntries { get; set; }
		[JsonProperty("genera")]
		public IList<Genera> Genera { get; set; }
		[JsonProperty("varieties")]
		public IList<Variety> Varieties { get; set; }
	}

	public class PokemonSpeciesDetail
    {

        [JsonProperty("rate")]
        public int Rate { get; set; }

        [JsonProperty("pokemon_species")]
        public PokemonSpecies PokemonSpecies { get; set; }
    }
	public class RequiredForEvolution
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
	public class Gender
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pokemon_species_details")]
        public IList<PokemonSpeciesDetail> PokemonSpeciesDetails { get; set; }

        [JsonProperty("required_for_evolution")]
        public IList<RequiredForEvolution> RequiredForEvolution { get; set; }
    }
	public class MainRegion
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
	public class Move
	{
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("url")]
		public string Url { get; set; }
		[JsonProperty("id")]
		public int Id { get; set; }
		[JsonProperty("accuracy")]
		public int Accuracy { get; set; }
		[JsonProperty("effect_chance")]
		public object EffectChance { get; set; }
		[JsonProperty("pp")]
		public int Pp { get; set; }
		[JsonProperty("priority")]
		public int Priority { get; set; }
		[JsonProperty("power")]
		public int Power { get; set; }
		[JsonProperty("contest_combos")]
		public ContestCombos ContestCombos { get; set; }
		[JsonProperty("contest_type")]
		public ContestType ContestType { get; set; }
		[JsonProperty("contest_effect")]
		public ContestEffect ContestEffect { get; set; }
		[JsonProperty("damage_class")]
		public DamageClass DamageClass { get; set; }
		[JsonProperty("effect_entries")]
		public IList<EffectEntry> EffectEntries { get; set; }
		[JsonProperty("effect_changes")]
		public IList<object> EffectChanges { get; set; }
		[JsonProperty("generation")]
		public Generation Generation { get; set; }
		[JsonProperty("meta")]
		public Meta Meta { get; set; }
		[JsonProperty("names")]
		public IList<Name> Names { get; set; }
		[JsonProperty("past_values")]
		public IList<object> PastValues { get; set; }
		[JsonProperty("stat_changes")]
		public IList<object> StatChanges { get; set; }
		[JsonProperty("super_contest_effect")]
		public SuperContestEffect SuperContestEffect { get; set; }
		[JsonProperty("target")]
		public Target Target { get; set; }
		[JsonProperty("type")]
		public Type Type { get; set; }
		[JsonProperty("move")]
		public Move _Move { get; set; }
		[JsonProperty("version_group_details")]
		public IList<VersionGroupDetail> VersionGroupDetails { get; set; }
	}

	public class Type
	{
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("url")]
		public string Url { get; set; }
		[JsonProperty("slot")]
		public int Slot { get; set; }
		[JsonProperty("type")]
		public Type _Type { get; set; }
		[JsonProperty("id")]
		public int Id { get; set; }
		[JsonProperty("damage_relations")]
		public DamageRelations DamageRelations { get; set; }
		[JsonProperty("game_indices")]
		public IList<GameIndice> GameIndices { get; set; }
		[JsonProperty("generation")]
		public Generation Generation { get; set; }
		[JsonProperty("move_damage_class")]
		public MoveDamageClass MoveDamageClass { get; set; }
		[JsonProperty("names")]
		public IList<Name> Names { get; set; }
		[JsonProperty("pokemon")]
		public IList<Pokemon> Pokemon { get; set; }
		[JsonProperty("moves")]
		public IList<Move> Moves { get; set; }
	}

	public class Level
    {

        [JsonProperty("level")]
        public int _Level { get; set; }

        [JsonProperty("experience")]
        public int Experience { get; set; }
    }
	public class GrowthRate
	{
		[JsonProperty("id")]
		public int Id { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("formula")]
		public string Formula { get; set; }
		[JsonProperty("descriptions")]
		public IList<Description> Descriptions { get; set; }
		[JsonProperty("levels")]
		public IList<Level> Levels { get; set; }
		[JsonProperty("pokemon_species")]
		public IList<PokemonSpecy> PokemonSpecies { get; set; }
		[JsonProperty("url")]
		public string Url { get; set; }
	}

	public class Attribute
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
	public class Category
	{
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("url")]
		public string Url { get; set; }
	}

	public class GameIndice
	{
		[JsonProperty("game_index")]
		public int GameIndex { get; set; }
		[JsonProperty("generation")]
		public Generation Generation { get; set; }
		[JsonProperty("version")]
		public Version Version { get; set; }
	}

	public class Sprites
	{
		[JsonProperty("default")]
		public string Default { get; set; }
		[JsonProperty("back_female")]
		public object BackFemale { get; set; }
		[JsonProperty("back_shiny_female")]
		public object BackShinyFemale { get; set; }
		[JsonProperty("back_default")]
		public string BackDefault { get; set; }
		[JsonProperty("front_female")]
		public object FrontFemale { get; set; }
		[JsonProperty("front_shiny_female")]
		public object FrontShinyFemale { get; set; }
		[JsonProperty("back_shiny")]
		public string BackShiny { get; set; }
		[JsonProperty("front_default")]
		public string FrontDefault { get; set; }
		[JsonProperty("front_shiny")]
		public string FrontShiny { get; set; }
	}

	public class ItemAttribute
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("descriptions")]
        public IList<Description> Descriptions { get; set; }

        [JsonProperty("items")]
        public IList<Item> Items { get; set; }

        [JsonProperty("names")]
        public IList<Name> Names { get; set; }
    }
	public class Pocket
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
	public class ItemCategory
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("items")]
        public IList<Item> Items { get; set; }

        [JsonProperty("names")]
        public IList<Name> Names { get; set; }

        [JsonProperty("pocket")]
        public Pocket Pocket { get; set; }
    }
	public class ItemFlingEffect
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("effect_entries")]
        public IList<EffectEntry> EffectEntries { get; set; }

        [JsonProperty("items")]
        public IList<Item> Items { get; set; }
    }
	public class ItemPocket
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("categories")]
        public IList<Category> Categories { get; set; }

        [JsonProperty("names")]
        public IList<Name> Names { get; set; }
    }
	public class Region
	{
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("url")]
		public string Url { get; set; }
		[JsonProperty("id")]
		public int Id { get; set; }
		[JsonProperty("locations")]
		public IList<Location> Locations { get; set; }
		[JsonProperty("main_generation")]
		public MainGeneration MainGeneration { get; set; }
		[JsonProperty("names")]
		public IList<Name> Names { get; set; }
		[JsonProperty("pokedexes")]
		public IList<Pokedex> Pokedexes { get; set; }
		[JsonProperty("version_groups")]
		public IList<VersionGroup> VersionGroups { get; set; }
	}

	public class Area
	{
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("url")]
		public string Url { get; set; }
	}

	public class Location
	{
		[JsonProperty("id")]
		public int Id { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("region")]
		public Region Region { get; set; }
		[JsonProperty("names")]
		public IList<Name> Names { get; set; }
		[JsonProperty("game_indices")]
		public IList<GameIndice> GameIndices { get; set; }
		[JsonProperty("areas")]
		public IList<Area> Areas { get; set; }
		[JsonProperty("url")]
		public string Url { get; set; }
	}

	public class Version
	{
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("url")]
		public string Url { get; set; }
		[JsonProperty("id")]
		public int Id { get; set; }
		[JsonProperty("names")]
		public IList<Name> Names { get; set; }
		[JsonProperty("version_group")]
		public VersionGroup VersionGroup { get; set; }
	}

	public class VersionDetail
	{
		[JsonProperty("rate")]
		public int Rate { get; set; }
		[JsonProperty("version")]
		public Version Version { get; set; }
		[JsonProperty("max_chance")]
		public int MaxChance { get; set; }
		[JsonProperty("encounter_details")]
		public IList<EncounterDetail> EncounterDetails { get; set; }
	}

	public class EncounterMethodRate
    {

        [JsonProperty("encounter_method")]
        public EncounterMethod EncounterMethod { get; set; }

        [JsonProperty("version_details")]
        public IList<VersionDetail> VersionDetails { get; set; }
    }
	public class Method
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
	public class EncounterDetail
    {

        [JsonProperty("min_level")]
        public int MinLevel { get; set; }

        [JsonProperty("max_level")]
        public int MaxLevel { get; set; }

        [JsonProperty("condition_values")]
        public IList<object> ConditionValues { get; set; }

        [JsonProperty("chance")]
        public int Chance { get; set; }

        [JsonProperty("method")]
        public Method Method { get; set; }
    }
	public class PokemonEncounter
	{
		[JsonProperty("pokemon")]
		public Pokemon Pokemon { get; set; }
		[JsonProperty("version_details")]
		public IList<VersionDetail> VersionDetails { get; set; }
		[JsonProperty("base_score")]
		public int BaseScore { get; set; }
		[JsonProperty("rate")]
		public int Rate { get; set; }
		[JsonProperty("pokemon_species")]
		public PokemonSpecies PokemonSpecies { get; set; }
	}

	public class LocationArea
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("game_index")]
        public int GameIndex { get; set; }

        [JsonProperty("encounter_method_rates")]
        public IList<EncounterMethodRate> EncounterMethodRates { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("names")]
        public IList<Name> Names { get; set; }

        [JsonProperty("pokemon_encounters")]
        public IList<PokemonEncounter> PokemonEncounters { get; set; }
    }
	public class UseBefore
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
	public class Normal
    {

        [JsonProperty("use_before")]
        public IList<UseBefore> UseBefore { get; set; }

        [JsonProperty("use_after")]
        public object UseAfter { get; set; }
    }
	public class Super
    {

        [JsonProperty("use_before")]
        public object UseBefore { get; set; }

        [JsonProperty("use_after")]
        public object UseAfter { get; set; }
    }
	public class ContestCombos
    {

        [JsonProperty("normal")]
        public Normal Normal { get; set; }

        [JsonProperty("super")]
        public Super Super { get; set; }
    }
	public class DamageClass
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
	public class Ailment
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
	public class Meta
    {

        [JsonProperty("ailment")]
        public Ailment Ailment { get; set; }

        [JsonProperty("category")]
        public Category Category { get; set; }

        [JsonProperty("min_hits")]
        public object MinHits { get; set; }

        [JsonProperty("max_hits")]
        public object MaxHits { get; set; }

        [JsonProperty("min_turns")]
        public object MinTurns { get; set; }

        [JsonProperty("max_turns")]
        public object MaxTurns { get; set; }

        [JsonProperty("drain")]
        public int Drain { get; set; }

        [JsonProperty("healing")]
        public int Healing { get; set; }

        [JsonProperty("crit_rate")]
        public int CritRate { get; set; }

        [JsonProperty("ailment_chance")]
        public int AilmentChance { get; set; }

        [JsonProperty("flinch_chance")]
        public int FlinchChance { get; set; }

        [JsonProperty("stat_chance")]
        public int StatChance { get; set; }
    }
	public class SuperContestEffect
	{
		[JsonProperty("url")]
		public string Url { get; set; }
		[JsonProperty("id")]
		public int Id { get; set; }
		[JsonProperty("appeal")]
		public int Appeal { get; set; }
		[JsonProperty("flavor_text_entries")]
		public IList<FlavorTextEntry> FlavorTextEntries { get; set; }
		[JsonProperty("moves")]
		public IList<Move> Moves { get; set; }
	}

	public class Target
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
	public class MoveAilment
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("moves")]
        public IList<Move> Moves { get; set; }

        [JsonProperty("names")]
        public IList<Name> Names { get; set; }
    }
	public class MoveBattleStyle
	{
		[JsonProperty("id")]
		public int Id { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("names")]
		public IList<Name> Names { get; set; }
		[JsonProperty("url")]
		public string Url { get; set; }
	}

	public class MoveCategory
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("descriptions")]
        public IList<Description> Descriptions { get; set; }

        [JsonProperty("moves")]
        public IList<Move> Moves { get; set; }
    }
	public class MoveDamageClass
	{
		[JsonProperty("id")]
		public int Id { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("descriptions")]
		public IList<Description> Descriptions { get; set; }
		[JsonProperty("moves")]
		public IList<Move> Moves { get; set; }
		[JsonProperty("names")]
		public IList<Name> Names { get; set; }
		[JsonProperty("url")]
		public string Url { get; set; }
	}

	public class MoveLearnMethod
	{
		[JsonProperty("id")]
		public int Id { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("names")]
		public IList<Name> Names { get; set; }
		[JsonProperty("descriptions")]
		public IList<Description> Descriptions { get; set; }
		[JsonProperty("version_groups")]
		public IList<VersionGroup> VersionGroups { get; set; }
		[JsonProperty("url")]
		public string Url { get; set; }
	}

	public class MoveTarget
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("descriptions")]
        public IList<Description> Descriptions { get; set; }

        [JsonProperty("moves")]
        public IList<Move> Moves { get; set; }

        [JsonProperty("names")]
        public IList<Name> Names { get; set; }
    }
	public class PokeathlonStat
	{
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("url")]
		public string Url { get; set; }
		[JsonProperty("id")]
		public int Id { get; set; }
		[JsonProperty("affecting_natures")]
		public AffectingNatures AffectingNatures { get; set; }
		[JsonProperty("names")]
		public IList<Name> Names { get; set; }
	}

	public class PokeathlonStatChange
    {

        [JsonProperty("max_change")]
        public int MaxChange { get; set; }

        [JsonProperty("pokeathlon_stat")]
        public PokeathlonStat PokeathlonStat { get; set; }
    }
	public class MoveBattleStylePreference
    {

        [JsonProperty("low_hp_preference")]
        public int LowHpPreference { get; set; }

        [JsonProperty("high_hp_preference")]
        public int HighHpPreference { get; set; }

        [JsonProperty("move_battle_style")]
        public MoveBattleStyle MoveBattleStyle { get; set; }
    }
	public class Nature
	{
		[JsonProperty("id")]
		public int Id { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("decreased_stat")]
		public object DecreasedStat { get; set; }
		[JsonProperty("increased_stat")]
		public object IncreasedStat { get; set; }
		[JsonProperty("likes_flavor")]
		public object LikesFlavor { get; set; }
		[JsonProperty("hates_flavor")]
		public object HatesFlavor { get; set; }
		[JsonProperty("pokeathlon_stat_changes")]
		public IList<PokeathlonStatChange> PokeathlonStatChanges { get; set; }
		[JsonProperty("move_battle_style_preferences")]
		public IList<MoveBattleStylePreference> MoveBattleStylePreferences { get; set; }
		[JsonProperty("names")]
		public IList<Name> Names { get; set; }
		[JsonProperty("url")]
		public string Url { get; set; }
	}

	public class PalParkArea
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("names")]
        public IList<Name> Names { get; set; }

        [JsonProperty("pokemon_encounters")]
        public IList<PokemonEncounter> PokemonEncounters { get; set; }
    }
	public class Increase
	{
		[JsonProperty("max_change")]
		public int MaxChange { get; set; }
		[JsonProperty("nature")]
		public Nature Nature { get; set; }
		[JsonProperty("change")]
		public int Change { get; set; }
		[JsonProperty("move")]
		public Move Move { get; set; }
	}

	public class Decrease
    {

        [JsonProperty("max_change")]
        public int MaxChange { get; set; }

        [JsonProperty("nature")]
        public Nature Nature { get; set; }
    }
	public class AffectingNatures
	{
		[JsonProperty("increase")]
		public IList<Increase> Increase { get; set; }
		[JsonProperty("decrease")]
		public IList<Decrease> Decrease { get; set; }
	}

	public class PokemonEntry
    {

        [JsonProperty("entry_number")]
        public int EntryNumber { get; set; }

        [JsonProperty("pokemon_species")]
        public PokemonSpecies PokemonSpecies { get; set; }
    }
	public class Pokedex
	{
		[JsonProperty("id")]
		public int Id { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("is_main_series")]
		public bool IsMainSeries { get; set; }
		[JsonProperty("descriptions")]
		public IList<Description> Descriptions { get; set; }
		[JsonProperty("names")]
		public IList<Name> Names { get; set; }
		[JsonProperty("pokemon_entries")]
		public IList<PokemonEntry> PokemonEntries { get; set; }
		[JsonProperty("region")]
		public object Region { get; set; }
		[JsonProperty("version_groups")]
		public IList<object> VersionGroups { get; set; }
		[JsonProperty("url")]
		public string Url { get; set; }
	}

	public class Form
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
	public class VersionGroupDetail
    {

        [JsonProperty("level_learned_at")]
        public int LevelLearnedAt { get; set; }

        [JsonProperty("version_group")]
        public VersionGroup VersionGroup { get; set; }

        [JsonProperty("move_learn_method")]
        public MoveLearnMethod MoveLearnMethod { get; set; }
    }
	public class Stat
	{
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("url")]
		public string Url { get; set; }
		[JsonProperty("base_stat")]
		public int BaseStat { get; set; }
		[JsonProperty("effort")]
		public int Effort { get; set; }
		[JsonProperty("stat")]
		public Stat _Stat { get; set; }
		[JsonProperty("id")]
		public int Id { get; set; }
		[JsonProperty("game_index")]
		public int GameIndex { get; set; }
		[JsonProperty("is_battle_only")]
		public bool IsBattleOnly { get; set; }
		[JsonProperty("affecting_moves")]
		public AffectingMoves AffectingMoves { get; set; }
		[JsonProperty("affecting_natures")]
		public AffectingNatures AffectingNatures { get; set; }
		[JsonProperty("characteristics")]
		public IList<Characteristic> Characteristics { get; set; }
		[JsonProperty("move_damage_class")]
		public object MoveDamageClass { get; set; }
		[JsonProperty("names")]
		public IList<Name> Names { get; set; }
	}

	public class PokemonColor
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("names")]
        public IList<Name> Names { get; set; }

        [JsonProperty("pokemon_species")]
        public IList<PokemonSpecy> PokemonSpecies { get; set; }
    }
	public class PokemonForm
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("form_order")]
        public int FormOrder { get; set; }

        [JsonProperty("is_default")]
        public bool IsDefault { get; set; }

        [JsonProperty("is_battle_only")]
        public bool IsBattleOnly { get; set; }

        [JsonProperty("is_mega")]
        public bool IsMega { get; set; }

        [JsonProperty("form_name")]
        public string FormName { get; set; }

        [JsonProperty("pokemon")]
        public Pokemon Pokemon { get; set; }

        [JsonProperty("sprites")]
        public Sprites Sprites { get; set; }

        [JsonProperty("version_group")]
        public VersionGroup VersionGroup { get; set; }
    }
	public class PokemonHabitat
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("names")]
        public IList<Name> Names { get; set; }

        [JsonProperty("pokemon_species")]
        public IList<PokemonSpecy> PokemonSpecies { get; set; }
    }
	public class AwesomeName
    {

        [JsonProperty("awesome_name")]
        public string _AwesomeName { get; set; }

        [JsonProperty("language")]
        public Language Language { get; set; }
    }
	public class PokemonShape
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("awesome_names")]
        public IList<AwesomeName> AwesomeNames { get; set; }

        [JsonProperty("names")]
        public IList<Name> Names { get; set; }

        [JsonProperty("pokemon_species")]
        public IList<PokemonSpecy> PokemonSpecies { get; set; }
    }
	public class PokedexNumber
    {

        [JsonProperty("entry_number")]
        public int EntryNumber { get; set; }

        [JsonProperty("pokedex")]
        public Pokedex Pokedex { get; set; }
    }
	public class Color
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
	public class Shape
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
	public class Habitat
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
	public class PalParkEncounter
    {

        [JsonProperty("base_score")]
        public int BaseScore { get; set; }

        [JsonProperty("rate")]
        public int Rate { get; set; }

        [JsonProperty("area")]
        public Area Area { get; set; }
    }
	public class Genera
    {

        [JsonProperty("genus")]
        public string Genus { get; set; }

        [JsonProperty("language")]
        public Language Language { get; set; }
    }
	public class Variety
    {

        [JsonProperty("is_default")]
        public bool IsDefault { get; set; }

        [JsonProperty("pokemon")]
        public Pokemon Pokemon { get; set; }
    }
	public class MainGeneration
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
	public class AffectingMoves
    {

        [JsonProperty("increase")]
        public IList<Increase> Increase { get; set; }

        [JsonProperty("decrease")]
        public IList<object> Decrease { get; set; }
    }
	public class NoDamageTo
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
	public class HalfDamageTo
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
	public class NoDamageFrom
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
	public class DoubleDamageFrom
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
	public class DamageRelations
    {

        [JsonProperty("no_damage_to")]
        public IList<NoDamageTo> NoDamageTo { get; set; }

        [JsonProperty("half_damage_to")]
        public IList<HalfDamageTo> HalfDamageTo { get; set; }

        [JsonProperty("double_damage_to")]
        public IList<object> DoubleDamageTo { get; set; }

        [JsonProperty("no_damage_from")]
        public IList<NoDamageFrom> NoDamageFrom { get; set; }

        [JsonProperty("half_damage_from")]
        public IList<object> HalfDamageFrom { get; set; }

        [JsonProperty("double_damage_from")]
        public IList<DoubleDamageFrom> DoubleDamageFrom { get; set; }
    }
}
