using Library.Domain.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Library.Domain.Services;

/// <summary>
/// Интерфейс репозитория для работы с выдачами книг.
/// </summary>
public interface IBookIssueRepository
{
    /// <summary>
    /// Получить все выдачи книг.
    /// </summary>
    /// <returns>Список всех выдач книг.</returns>
    Task<IList<BookIssue>> GetAll();

    /// <summary>
    /// Получить выдачу книги по идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор выдачи.</param>
    /// <returns>Выдача книги или null, если выдача не найдена.</returns>
    Task<BookIssue?> GetById(int id);

    /// <summary>
    /// Добавить новую выдачу книги.
    /// </summary>
    /// <param name="bookIssue">Данные о выдаче книги.</param>
    /// <returns>Добавленная выдача книги.</returns>
    Task<BookIssue> Add(BookIssue bookIssue);

    /// <summary>
    /// Обновить данные о выдаче книги.
    /// </summary>
    /// <param name="bookIssue">Обновленные данные о выдаче книги.</param>
    /// <returns>Обновленная выдача книги.</returns>
    Task<BookIssue> Update(BookIssue bookIssue);

    /// <summary>
    /// Удалить выдачу книги по идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор выдачи.</param>
    /// <returns>True, если удаление прошло успешно, иначе False.</returns>
    Task<bool> Delete(int id);

    /// <summary>
    /// Получить список выданных книг, упорядоченных по названию.
    /// </summary>
    /// <returns>Список выданных книг, упорядоченных по названию.</returns>
    Task<IList<BookIssue>> GetIssuedBooksOrderedByTitle();

    /// <summary>
    /// Получить топ-5 читателей по количеству взятых книг за указанный период.
    /// </summary>
    /// <param name="startDate">Начальная дата периода.</param>
    /// <param name="endDate">Конечная дата периода.</param>
    /// <returns>Список из не более чем 5 читателей, упорядоченных по количеству взятых книг.</returns>
    Task<IList<Reader>> GetTop5ReadersByPeriod(DateTime startDate, DateTime endDate);

    /// <summary>
    /// Получить список читателей, задержавших возврат книг.
    /// </summary>
    /// <returns>Список читателей, задержавших возврат книг.</returns>
    Task<IList<Reader>> GetReadersWithDelayedBooks();
}
