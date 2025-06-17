using System.ComponentModel.DataAnnotations;

namespace Library.Domain.Model;

/// <summary>
/// Класс, представляющий выдачу книги читателю.
/// </summary>
public class BookIssue
{
    /// <summary>
    /// Идентификатор выдачи.
    /// </summary>
    [Key]
    public required int Id { get; set; }

    /// <summary>
    /// Инвентарный номер выданной книги.
    /// </summary>
    public required int InventoryNumber { get; set; }

    /// <summary>
    /// Идентификатор читателя, которому выдана книга.
    /// </summary>
    public required int ReaderId { get; set; }

    /// <summary>
    /// Дата выдачи книги.
    /// </summary>
    public required DateTime IssueDate { get; set; }

    /// <summary>
    /// Количество дней, на которые выдана книга.
    /// </summary>
    public required int DaysIssued { get; set; }

    /// <summary>
    /// Дата возврата книги (если книга уже возвращена).
    /// </summary>
    public DateTime? ReturnDate { get; set; }

    /// <summary>
    /// Навигационное свойство для связи с книгой.
    /// </summary>
    public Book? Book { get; set; }
}
