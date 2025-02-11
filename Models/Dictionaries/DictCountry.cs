using System;

namespace rekrutacja_luty_25.Models.Dictionaries;

public class DictCountry : DictBase
{
        public ICollection<Authority> Authorities { get; set; }
}
