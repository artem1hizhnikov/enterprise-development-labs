using System.ComponentModel.DataAnnotations;

namespace Library.Domain.Model;

/// <summary>
/// Класс, представляющий отдел библиотеки.
/// </summary>
public class Department
{
    /// <summary>
    /// Идентификатор отдела.
    /// </summary>
    [Key]
    public required int Id { get; set; }

    /// <summary>
    /// Название отдела.
    /// </summary>
    public required string Name { get; set; }
}
