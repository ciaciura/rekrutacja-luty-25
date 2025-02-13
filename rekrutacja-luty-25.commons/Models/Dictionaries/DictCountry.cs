using System;

namespace rekrutacja_luty_25.commons.Models.Dictionaries;

public class DictCountry : DictBase
{
        public ICollection<Authority> Authorities { get; set; }
}
