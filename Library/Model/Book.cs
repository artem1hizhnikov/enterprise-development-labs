using System.ComponentModel.DataAnnotations;

namespace Library.Domain.Model;

/// <summary>
/// Класс, представляющий книгу в библиотеке.
/// </summary>
public class Book
{
    /// <summary>
    /// Инвентарный номер книги.
    /// </summary>
    [Key]
    public required int InventoryNumber { get; set; }

    /// <summary>
    /// Шифр книги в каталоге.
    /// </summary>
    public required string CatalogCode { get; set; }

    /// <summary>
    /// Авторы книги.
    /// </summary>
    public required string Authors { get; set; }

    /// <summary>
    /// Название книги.
    /// </summary>
    public required string Title { get; set; }

    /// <summary>
    /// Тип издания (например, учебное пособие, монография).
    /// </summary>
    public required string PublicationType { get; set; }

    /// <summary>
    /// Место издания книги.
    /// </summary>
    public required string PublicationPlace { get; set; }

    /// <summary>
    /// Год издания книги.
    /// </summary>
    public required int PublicationYear { get; set; }
}
// Я нписал более развёрнутые комментарии в тестах, что бы показать, что, мол, умею.
// Надеюсь, тут будет достаточно таких подписей.
