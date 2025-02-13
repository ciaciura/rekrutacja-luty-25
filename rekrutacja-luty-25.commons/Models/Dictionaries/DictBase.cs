using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace rekrutacja_luty_25.commons.Models.Dictionaries;

public class DictBase
{

        /// <summary>
        /// Prefix, który oznacza klasy reprezentujące słowniki
        /// </summary>
        public const string DictionaryPrefix = "Dict";
        /// <summary>
        /// Identyfikator
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }
        /// <summary>
        /// Czy rekord słownika jest aktywny
        /// </summary>
        [JsonPropertyName("active")]
        public bool Active { get; set; } = true;
        /// <summary>
        /// Unikalny symbol wartości słownika
        /// </summary>
        [Column("symbol")]
        public string? Symbol { get; set; } = null;
        /// <summary>
        /// Nazwa wartości
        /// </summary>
        [Column("name")]
        public string? Name { get; set; }
        /// <summary>
        /// Opis wartości
        /// </summary>
        [Column("description")]
        public string? Description { get; set; } = null;
}
