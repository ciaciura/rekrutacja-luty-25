using System;
using rekrutacja_luty_25.Models.Dictionaries;

namespace rekrutacja_luty_25.Models;

public class Authority
{
    /// <summary>
    /// Identyfikator
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// Skrótowy symbol
    /// </summary>
    public string Symbol { get; set; }
    /// <summary>
    /// Nazwa
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Ulica adresu kontaktowego
    /// </summary>
    public string Street { get; set; }
    /// <summary>
    /// Kod pocztowy adresu kontaktowego
    /// </summary>
    public string PostalCode { get; set; }
    /// <summary>
    /// Miasto adresu kontaktowego
    /// </summary>
    public string City { get; set; }
    /// <summary>
    /// Czy akceptuje odpowiedzi drogą elektroniczną
    /// </summary>
    public bool AcceptsEmail { get; set; }
    /// <summary>
    /// Atrybut wyliczalny opisujący czy organ jest z grupy organów EPC
    /// </summary>
    /// <returns></returns>
    public bool IsEpc() { if(PostalCode.Equals("N1 3DF")) return true; else return false;}
    /// <summary>
    /// Symbol kraju, jest też identyfikatorem kraju w bazie danych
    /// </summary>
    public string CountrySymbol { get; set; }
    /// <summary>
    /// Obiekt kraju w bazie danych
    /// </summary>
    public virtual DictCountry Country { get; set; }
    /// <summary>
    /// Komentarz
    /// </summary>
    public string? Comment { get; set; }
    /// <summary>
    /// Czy jest aktywny
    /// </summary>
    public bool Active { get; set; }
    /// <summary>
    /// Lista numerów telefonu
    /// </summary>
    public ICollection<AuthorityPhoneNumber> PhoneNumbers { get; set; }
    /// <summary>
    /// Lista Adresów email
    /// </summary>
    public ICollection<AuthorityEmail> Emails { get; set; }

}
