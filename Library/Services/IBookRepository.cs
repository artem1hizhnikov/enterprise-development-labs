using Library.Domain.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Library.Domain.Services;

/// <summary>
/// Интерфейс репозитория для работы с книгами.
/// </summary>
public interface IBookRepository
{
    /// <summary>
    /// Получить список всех книг.
    /// </summary>
    /// <returns>Список всех книг.</returns>
    Task<IList<Book>> GetAll();

    /// <summary>
    /// Получить книгу по инвентарному номеру.
    /// </summary>
    /// <param name="inventoryNumber">Инвентарный номер книги.</param>
    /// <returns>Книга или null, если книга не найдена.</returns>
    Task<Book?> GetByInventoryNumber(int inventoryNumber);

    /// <summary>
    /// Получить книгу по шифру в каталоге.
    /// </summary>
    /// <param name="catalogCode">Шифр книги в каталоге.</param>
    /// <returns>Книга или null, если книга не найдена.</returns>
    Task<Book?> GetByCatalogCode(string catalogCode);

    /// <summary>
    /// Добавить новую книгу.
    /// </summary>
    /// <param name="book">Данные о книге.</param>
    /// <returns>Добавленная книга.</returns>
    Task<Book> Add(Book book);

    /// <summary>
    /// Обновить данные о книге.
    /// </summary>
    /// <param name="book">Обновленные данные о книге.</param>
    /// <returns>Обновленная книга.</returns>
    Task<Book> Update(Book book);

    /// <summary>
    /// Удалить книгу по инвентарному номеру.
    /// </summary>
    /// <param name="inventoryNumber">Инвентарный номер книги.</param>
    /// <returns>True, если удаление прошло успешно, иначе False.</returns>
    Task<bool> Delete(int inventoryNumber);

    /// <summary>
    /// Получить информацию о наличии книги в отделах.
    /// </summary>
    /// <param name="inventoryNumber">Инвентарный номер книги.</param>
    /// <returns>Список отделов, в которых доступна книга, и количество экземпляров.</returns>
    Task<IList<BookInDepartment>> GetBookAvailability(int inventoryNumber);

    /// <summary>
    /// Получить количество книг по типу издания.
    /// </summary>
    /// <returns>Список кортежей, где каждый кортеж содержит тип издания и количество книг.</returns>
    Task<IList<(string PublicationType, int Quantity)>> GetBooksCountByPublicationType();
}
