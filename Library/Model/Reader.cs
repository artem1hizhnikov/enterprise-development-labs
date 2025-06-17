using System.ComponentModel.DataAnnotations;

namespace Library.Domain.Model;

/// <summary>
/// Класс, представляющий читателя библиотеки.
/// </summary>
public class Reader
{
    /// <summary>
    /// Идентификатор читателя.
    /// </summary>
    [Key]
    public required int Id { get; set; }

    /// <summary>
    /// Полное имя читателя (ФИО).
    /// </summary>
    public required string FullName { get; set; }

    /// <summary>
    /// Адрес читателя.
    /// </summary>
    public required string Address { get; set; }

    /// <summary>
    /// Телефон читателя.
    /// </summary>
    public required string Phone { get; set; }

    /// <summary>
    /// Дата регистрации читателя в библиотеке.
    /// </summary>
    public required DateTime RegistrationDate { get; set; }
}
// Какие ж эти комментарии получаются объёмные...
// Если будет построковая оплата на работе, обязательно возьму на вооружение)
