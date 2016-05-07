using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDataLoader.Generated
{

    public class Ability2
    {
        public bool is_hidden { get; set; }
        public int slot { get; set; }
        public Ability ability { get; set; }
    }

    public class PokemonForm
    {
        public int id { get; set; }
        public string name { get; set; }
        public int order { get; set; }
        public int form_order { get; set; }
        public bool is_default { get; set; }
        public bool is_battle_only { get; set; }
        public bool is_mega { get; set; }
        public string form_name { get; set; }
        public Pokemon pokemon { get; set; }
        public Sprites sprites { get; set; }
        public VersionGroup version_group { get; set; }
    }

    public class GameIndice
    {
        public int game_index { get; set; }
        public Version version { get; set; }
    }

    public class Version
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<Name> names { get; set; }
        public VersionGroup version_group { get; set; }
    }

    public class VersionGroupDetail
    {
        public int level_learned_at { get; set; }
        public VersionGroup version_group { get; set; }
        public MoveLearnMethod move_learn_method { get; set; }
    }

    public class Move2
    {
        public Move move { get; set; }
        public List<VersionGroupDetail> version_group_details { get; set; }
    }

    public class Sprites
    {
        public object back_female { get; set; }
        public object back_shiny_female { get; set; }
        public string back_default { get; set; }
        public object front_female { get; set; }
        public object front_shiny_female { get; set; }
        public string back_shiny { get; set; }
        public string front_default { get; set; }
        public string front_shiny { get; set; }
    }
    
    public class Increase
    {
        public int change { get; set; }
        public Move move { get; set; }
    }

    public class AffectingMoves
    {
        public List<Increase> increase { get; set; }
        public List<object> decrease { get; set; }
    }

    public class AffectingNatures
    {
        public List<object> increase { get; set; }
        public List<object> decrease { get; set; }
    }

    public class Characteristic
    {
        public int id { get; set; }
        public int gene_modulo { get; set; }
        public List<int> possible_values { get; set; }
        public Stat highest_stat { get; set; }
        public List<Description> descriptions { get; set; }
    }

    public class Stat
    {
        public int id { get; set; }
        public string name { get; set; }
        public int game_index { get; set; }
        public bool is_battle_only { get; set; }
        public AffectingMoves affecting_moves { get; set; }
        public AffectingNatures affecting_natures { get; set; }
        public List<Characteristic> characteristics { get; set; }
        public object move_damage_class { get; set; }
        public List<Name> names { get; set; }
    }

    public class Stat2
    {
        public int base_stat { get; set; }
        public int effort { get; set; }
        public Stat stat { get; set; }
    }

    public class Type2
    {
        public int slot { get; set; }
        public Type type { get; set; }
    }

    public class Pokemon
    {
        public int id { get; set; }
        public string name { get; set; }
        public int base_experience { get; set; }
        public int height { get; set; }
        public bool is_default { get; set; }
        public int order { get; set; }
        public int weight { get; set; }
        public List<Ability2> abilities { get; set; }
        public List<PokemonForm> forms { get; set; }
        public List<GameIndice> game_indices { get; set; }
        public List<object> held_items { get; set; }
        public List<object> location_area_encounters { get; set; }
        public List<Move2> moves { get; set; }
        public PokemonSpecies species { get; set; }
        public Sprites sprites { get; set; }
        public List<Stat2> stats { get; set; }
        public List<Type> types { get; set; }
    }

    public class Generation
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<object> abilities { get; set; }
        public Region main_region { get; set; }
        public List<Move> moves { get; set; }
        public List<Name> names { get; set; }
        public List<PokemonSpecies> pokemon_species { get; set; }
        public List<Type> types { get; set; }
        public List<VersionGroup> version_groups { get; set; }
    }

    public class Name
    {
        public string name { get; set; }
        public Language language { get; set; }
    }

    public class EffectEntry
    {
        public string effect { get; set; }
        public string short_effect { get; set; }
        public Language language { get; set; }
    }

    public class EffectEntry2
    {
        public string effect { get; set; }
        public Language language { get; set; }
    }

    public class EffectChange
    {
        public VersionGroup version_group { get; set; }
        public List<EffectEntry2> effect_entries { get; set; }
    }

    public class FlavorTextEntry
    {
        public string flavor_text { get; set; }
        public Language language { get; set; }
        public VersionGroup version_group { get; set; }
    }

    public class Pokemon2
    {
        public bool is_hidden { get; set; }
        public int slot { get; set; }
        public Pokemon pokemon { get; set; }
    }

    public class Ability
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool is_main_series { get; set; }
        public Generation generation { get; set; }
        public List<Name> names { get; set; }
        public List<EffectEntry> effect_entries { get; set; }
        public List<EffectChange> effect_changes { get; set; }
        public List<FlavorTextEntry> flavor_text_entries { get; set; }
        public List<Pokemon2> pokemon { get; set; }
    }
    
    public class Language
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool official { get; set; }
        public string iso639 { get; set; }
        public string iso3166 { get; set; }
        public List<Name> names { get; set; }
    }

    public class Description
    {
        public string description { get; set; }
        public Language language { get; set; }
    }

    public class PokemonEntry
    {
        public int entry_number { get; set; }
        public PokemonSpecies pokemon_species { get; set; }
    }

    public class Pokedex
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool is_main_series { get; set; }
        public List<Description> descriptions { get; set; }
        public List<Name> names { get; set; }
        public List<PokemonEntry> pokemon_entries { get; set; }
        public object region { get; set; }
        public List<object> version_groups { get; set; }
    }
    
    public class VersionGroup
    {
        public int id { get; set; }
        public string name { get; set; }
        public int order { get; set; }
        public Generation generation { get; set; }
        public List<MoveLearnMethod> move_learn_methods { get; set; }
        public List<Pokedex> pokedexes { get; set; }
        public List<Region> regions { get; set; }
        public List<Version> versions { get; set; }
    }

    public class MoveLearnMethod
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<Name> names { get; set; }
        public List<Description> descriptions { get; set; }
        public List<VersionGroup> version_groups { get; set; }
    }

    public class Normal
    {
        public List<Move> use_before { get; set; }
        public object use_after { get; set; }
    }

    public class Super
    {
        public object use_before { get; set; }
        public object use_after { get; set; }
    }

    public class ContestCombos
    {
        public Normal normal { get; set; }
        public Super super { get; set; }
    }

    public class Firmness
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<Berry> berries { get; set; }
        public List<Name> names { get; set; }
    }

    public class Flavor
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<Berry2> berries { get; set; }
        public ContestType contest_type { get; set; }
        public List<Name> names { get; set; }
    }

    public class Flavor2
    {
        public int potency { get; set; }
        public Flavor flavor { get; set; }
    }

    public class ItemAttribute
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<Description> descriptions { get; set; }
        public List<Item> items { get; set; }
        public List<Name> names { get; set; }
    }

    public class ItemPocket
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<ItemCategory> categories { get; set; }
        public List<Name> names { get; set; }
    }

    public class ItemCategory
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<Item> items { get; set; }
        public List<Name> names { get; set; }
        public ItemPocket pocket { get; set; }
    }

    public class ItemSprites
    {
        public string @default { get; set; }
    }

    public class Item
    {
        public int id { get; set; }
        public string name { get; set; }
        public int cost { get; set; }
        public object fling_power { get; set; }
        public object fling_effect { get; set; }
        public List<ItemAttribute> attributes { get; set; }
        public ItemCategory category { get; set; }
        public List<EffectEntry> effect_entries { get; set; }
        public List<FlavorTextEntry> flavor_text_entries { get; set; }
        public List<GameIndice> game_indices { get; set; }
        public List<Name> names { get; set; }
        public List<object> held_by_pokemon { get; set; }
        public ItemSprites sprites { get; set; }
        public object baby_trigger_for { get; set; }
    }

    public class Berry
    {
        public int id { get; set; }
        public string name { get; set; }
        public int growth_time { get; set; }
        public int max_harvest { get; set; }
        public int natural_gift_power { get; set; }
        public int size { get; set; }
        public int smoothness { get; set; }
        public int soil_dryness { get; set; }
        public Firmness firmness { get; set; }
        public List<Flavor2> flavors { get; set; }
        public Item item { get; set; }
        public Type natural_gift_type { get; set; }
    }

    public class Berry2
    {
        public int potency { get; set; }
        public Berry berry { get; set; }
    }
        
    public class BerryFlavor
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<Berry2> berries { get; set; }
        public ContestType contest_type { get; set; }
        public List<Name> names { get; set; }
    }

    public class ContestType
    {
        public int id { get; set; }
        public string name { get; set; }
        public BerryFlavor berry_flavor { get; set; }
        public List<Name> names { get; set; }
    }

    public class ContestEffectEntry
    {
        public string effect { get; set; }
        public Language language { get; set; }
    }

    public class ContestFlavorTextEntry
    {
        public string flavor_text { get; set; }
        public Language language { get; set; }
    }


    public class ContestEffect
    {
        public int id { get; set; }
        public int appeal { get; set; }
        public int jam { get; set; }
        public List<ContestEffectEntry> effect_entries { get; set; }
        public List<ContestFlavorTextEntry> flavor_text_entries { get; set; }
    }

    public class DamageClass
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<Description> descriptions { get; set; }
        public List<Move> moves { get; set; }
        public List<Name> names { get; set; }

    }

    public class MoveAilment
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<Move> moves { get; set; }
        public List<Name> names { get; set; }
    }

    public class MoveCategory
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<Description> descriptions { get; set; }
        public List<Move> moves { get; set; }
    }

    public class Meta
    {
        public MoveAilment ailment { get; set; }
        public MoveCategory category { get; set; }
        public object min_hits { get; set; }
        public object max_hits { get; set; }
        public object min_turns { get; set; }
        public object max_turns { get; set; }
        public int drain { get; set; }
        public int healing { get; set; }
        public int crit_rate { get; set; }
        public int ailment_chance { get; set; }
        public int flinch_chance { get; set; }
        public int stat_chance { get; set; }
    }
        
    public class SuperContestEffect
    {
        public int id { get; set; }
        public int appeal { get; set; }
        public List<ContestFlavorTextEntry> flavor_text_entries { get; set; }
        public List<Move> moves { get; set; }
    }

    public class MoveTarget
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<Description> descriptions { get; set; }
        public List<Move> moves { get; set; }
        public List<Name> names { get; set; }
    }

    public class Move
    {
        public int id { get; set; }
        public string name { get; set; }
        public int accuracy { get; set; }
        public object effect_chance { get; set; }
        public int pp { get; set; }
        public int priority { get; set; }
        public int power { get; set; }
        public ContestCombos contest_combos { get; set; }
        public ContestType contest_type { get; set; }
        public ContestEffect contest_effect { get; set; }
        public DamageClass damage_class { get; set; }
        public List<EffectEntry> effect_entries { get; set; }
        public List<object> effect_changes { get; set; }
        public Generation generation { get; set; }
        public Meta meta { get; set; }
        public List<Name> names { get; set; }
        public List<object> past_values { get; set; }
        public List<object> stat_changes { get; set; }
        public SuperContestEffect super_contest_effect { get; set; }
        public MoveTarget target { get; set; }
        public Type type { get; set; }
    }

    public class DamageRelations
    {
        public List<object> no_damage_to { get; set; }
        public List<Type> half_damage_to { get; set; }
        public List<Type> double_damage_to { get; set; }
        public List<Type> no_damage_from { get; set; }
        public List<Type> half_damage_from { get; set; }
        public List<Type> double_damage_from { get; set; }
    }

    public class MoveDamageClass
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<Description> descriptions { get; set; }
        public List<Move> moves { get; set; }
        public List<Name> names { get; set; }
    }

    public class Pokemon3
    {
        public int slot { get; set; }
        public Pokemon pokemon { get; set; }
    }

    public class Type
    {
        public int id { get; set; }
        public string name { get; set; }
        public DamageRelations damage_relations { get; set; }
        public List<GameIndice> game_indices { get; set; }
        public Generation generation { get; set; }
        public MoveDamageClass move_damage_class { get; set; }
        public List<Name> names { get; set; }
        public List<Pokemon3> pokemon { get; set; }
        public List<Move> moves { get; set; }
    }

    public class Level
    {
        public int level { get; set; }
        public int experience { get; set; }
    }

    public class GrowthRate
    {
        public int id { get; set; }
        public string name { get; set; }
        public string formula { get; set; }
        public List<Description> descriptions { get; set; }
        public List<Level> levels { get; set; }
        public List<PokemonSpecies> pokemon_species { get; set; }
    }

    public class PokedexNumber
    {
        public int entry_number { get; set; }
        public Pokedex pokedex { get; set; }
    }

    public class EggGroup
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<Name> names { get; set; }
        public List<PokemonSpecies> pokemon_species { get; set; }
    }

    public class PokemonColor
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<Name> names { get; set; }
        public List<PokemonSpecies> pokemon_species { get; set; }
    }

    public class AwesomeName
    {
        public string awesome_name { get; set; }
        public Language language { get; set; }
    }

    public class PokemonShape
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<AwesomeName> awesome_names { get; set; }
        public List<Name> names { get; set; }
        public List<PokemonSpecies> pokemon_species { get; set; }
    }

    public class EvolutionTrigger
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<Name> names { get; set; }
        public List<PokemonSpecies> pokemon_species { get; set; }
    }

    public class EvolutionDetails
    {
        public object item { get; set; }
        public EvolutionTrigger trigger { get; set; }
        public object gender { get; set; }
        public object held_item { get; set; }
        public object known_move { get; set; }
        public object known_move_type { get; set; }
        public object location { get; set; }
        public int min_level { get; set; }
        public object min_happiness { get; set; }
        public object min_beauty { get; set; }
        public object min_affection { get; set; }
        public bool needs_overworld_rain { get; set; }
        public object party_species { get; set; }
        public object party_type { get; set; }
        public object relative_physical_stats { get; set; }
        public string time_of_day { get; set; }
        public object trade_species { get; set; }
        public bool turn_upside_down { get; set; }
    }

    public class EvolvesTo
    {
        public bool is_baby { get; set; }
        public PokemonSpecies species { get; set; }
        public EvolutionDetails evolution_details { get; set; }
        public List<EvolvesTo> evolves_to { get; set; }
    }

    public class Chain
    {
        public bool is_baby { get; set; }
        public PokemonSpecies species { get; set; }
        public object evolution_details { get; set; }
        public List<EvolvesTo> evolves_to { get; set; }
    }

    public class EvolutionChain
    {
        public int id { get; set; }
        public object baby_trigger_item { get; set; }
        public Chain chain { get; set; }
    }

    public class PokemonHabitat
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<Name> names { get; set; }
        public List<PokemonSpecies> pokemon_species { get; set; }
    }

    public class PokemonEncounter
    {
        public int base_score { get; set; }
        public int rate { get; set; }
        public PokemonSpecies pokemon_species { get; set; }
    }

    public class PalParkArea
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<Name> names { get; set; }
        public List<PokemonEncounter> pokemon_encounters { get; set; }
    }

    public class PalParkEncounter
    {
        public int base_score { get; set; }
        public int rate { get; set; }
        public PalParkArea area { get; set; }
    }

    public class Genera
    {
        public string genus { get; set; }
        public Language language { get; set; }
    }

    public class Variety
    {
        public bool is_default { get; set; }
        public Pokemon pokemon { get; set; }
    }

    public class PokemonSpecies
    {
        public int id { get; set; }
        public string name { get; set; }
        public int order { get; set; }
        public int gender_rate { get; set; }
        public int capture_rate { get; set; }
        public int base_happiness { get; set; }
        public bool is_baby { get; set; }
        public int hatch_counter { get; set; }
        public bool has_gender_differences { get; set; }
        public bool forms_switchable { get; set; }
        public GrowthRate growth_rate { get; set; }
        public List<PokedexNumber> pokedex_numbers { get; set; }
        public List<EggGroup> egg_groups { get; set; }
        public PokemonColor color { get; set; }
        public PokemonShape shape { get; set; }
        public object evolves_from_species { get; set; }
        public EvolutionChain evolution_chain { get; set; }
        public PokemonHabitat habitat { get; set; }
        public Generation generation { get; set; }
        public List<Name> names { get; set; }
        public List<PalParkEncounter> pal_park_encounters { get; set; }
        public List<object> form_descriptions { get; set; }
        public List<FlavorTextEntry> flavor_text_entries { get; set; }
        public List<Genera> genera { get; set; }
        public List<Variety> varieties { get; set; }
    }

    public class Location
    {
        public int id { get; set; }
        public string name { get; set; }
        public Region region { get; set; }
        public List<Name> names { get; set; }
        public List<GameIndice> game_indices { get; set; }
        public List<LocationArea> areas { get; set; }
    }

    public class Region
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<Location> locations { get; set; }
        public Generation main_generation { get; set; }
        public List<Name> names { get; set; }
        public List<Pokedex> pokedexes { get; set; }
        public List<VersionGroup> version_groups { get; set; }
    }

    public class VersionDetail
    {
        public int rate { get; set; }
        public Version version { get; set; }
    }

    public class EncounterMethodRate
    {
        public EncounterMethod encounter_method { get; set; }
        public List<VersionDetail> version_details { get; set; }
    }

    public class EncounterMethod
    {
        public int id { get; set; }
        public string name { get; set; }
        public int order { get; set; }
        public List<Name> names { get; set; }
    }

    public class EncounterDetail
    {
        public int min_level { get; set; }
        public int max_level { get; set; }
        public List<object> condition_values { get; set; }
        public int chance { get; set; }
        public EncounterMethod method { get; set; }
    }

    public class VersionDetail2
    {
        public Version version { get; set; }
        public int max_chance { get; set; }
        public List<EncounterDetail> encounter_details { get; set; }
    }

    public class PokemonEncounter2
    {
        public Pokemon pokemon { get; set; }
        public List<VersionDetail2> version_details { get; set; }
    }

    public class LocationArea
    {
        public int id { get; set; }
        public string name { get; set; }
        public int game_index { get; set; }
        public List<EncounterMethodRate> encounter_method_rates { get; set; }
        public Location location { get; set; }
        public List<Name> names { get; set; }
        public List<PokemonEncounter2> pokemon_encounters { get; set; }
    }
}
