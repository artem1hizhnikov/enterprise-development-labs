using System.ComponentModel.DataAnnotations;

namespace Library.Domain.Model;

/// <summary>
/// Класс, представляющий связь книги с отделом библиотеки.
/// </summary>
public class BookInDepartment
{
    /// <summary>
    /// Идентификатор записи.
    /// </summary>
    [Key]
    public required int Id { get; set; }

    /// <summary>
    /// Инвентарный номер книги.
    /// </summary>
    public required int InventoryNumber { get; set; }

    /// <summary>
    /// Идентификатор отдела, в котором находится книга.
    /// </summary>
    public required int DepartmentId { get; set; }

    /// <summary>
    /// Количество книг данного экземпляра в отделе.
    /// </summary>
    public required int Quantity { get; set; }
}
