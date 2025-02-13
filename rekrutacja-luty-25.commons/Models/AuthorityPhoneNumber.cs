using System;
using System.Text.Json.Serialization;

namespace rekrutacja_luty_25.commons.Models;

public class AuthorityPhoneNumber
{
        /// <summary>
        /// Identyfikator
        /// </summary>
        [JsonIgnore]
        public int Id { get; set; }
        /// <summary>
        /// Numer telefonu
        /// </summary>
        public string Number { get; set; }
        /// <summary>
        /// Czy jest aktywny
        /// </summary>
        public bool Active { get; set; }
        /// <summary>
        /// Identyfikator organu ścigania w bazie danych
        /// </summary>
        [JsonIgnore]
        public int AuthorityId { get; set; }
        /// <summary>
        /// Obiekt organu ścigania w bazie danych
        /// </summary>
        [JsonIgnore]
        public Authority Authority { get; set; }
}
