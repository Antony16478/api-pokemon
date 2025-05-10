using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PokeApiWinForms
{
    // Clases para deserializar el JSON de la PokeAPI
    public class PokemonType
    {
        [JsonPropertyName("type")]
        public TypeInfo Type { get; set; }
    }

    public class TypeInfo
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class Sprites
    {
        [JsonPropertyName("front_default")]
        public string FrontDefault { get; set; }
    }

    public class PokemonData
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("height")]
        public int Height { get; set; }

        [JsonPropertyName("weight")]
        public int Weight { get; set; }

        [JsonPropertyName("types")]
        public List<PokemonType> Types { get; set; }

        [JsonPropertyName("sprites")]
        public Sprites Sprites { get; set; }
    }
}
